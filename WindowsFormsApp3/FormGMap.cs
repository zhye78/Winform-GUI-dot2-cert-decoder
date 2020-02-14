using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form
    {
        private GMapMarker marker; //마커
        private List<PointLatLng> polList; //polygon 그릴때 좌표들 저장하는 리스트
        private GMapPolygon polygon; //지도에 그릴 도형 생성할때 사용
        private GMapOverlay overlay = new GMapOverlay("overlay"); //지도에 마커 찍고 도형 그릴때 사용

        private void map_Load(object sender, EventArgs e)
        {
            map.ShowCenter = false;
        }

        //map attribute
        private void setMap(PointLatLng point)
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap; //YahooMap, BingMap 다 가능
            map.Position = point;
            map.MinZoom = 1;
            map.MaxZoom = 100;
            map.Zoom = 10; //default zoom level
        }

        //원 그리기
        private void addCirclePolList(PointLatLng point, double radius)
        {
            double seg = Math.PI * 2 / 1000;

            for (int i = 0; i < 1000; i++)
            {
                double theta = seg * i;
                //double a = point.Lat + (Math.Cos(theta) * radius);
                double a = point.Lat + (Math.Cos(theta) * radius * ((-(point.Lat * point.Lat) / 8100) + ((1 / 270) * point.Lat) + 1));
                double b = point.Lng + (Math.Sin(theta) * radius);

                PointLatLng p = new PointLatLng(a, b);

                polList.Add(p);
            }

            //polygon 생성하고 등록
            polygon = new GMapPolygon(polList, "polList");
            polygon.Stroke = new Pen(Color.Blue, 1);
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.LightSkyBlue));

            overlay.Polygons.Add(polygon);
        }

        //다각형 그리기
        private void addPolyPolList(Dot2CertValidRegion region)
        {
            for (int i = 0; i < region.polygonal.point_num; i++)
            {
                PointLatLng point = new PointLatLng(region.polygonal.point_lat[i], region.polygonal.point_lon[i]);
                polList.Add(point);
            }

            //polygon 생성하고 등록
            polygon = new GMapPolygon(polList, "polList");
            polygon.Stroke = new Pen(Color.Blue, 1);
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.LightSkyBlue));

            overlay.Polygons.Add(polygon);
        }

        //add polygon to map
        private void addPolygon(PointLatLng point, double radius, Dot2CertValidRegion region)
        {
            if (polygon != null) //기존 polygon이 이미 있으면
            {
                polList.Clear();
                overlay.Polygons.Remove(polygon); //polygon 없앰
            }
            else
            {
                polList = new List<PointLatLng>();
            }

            switch (region.region_type)
            {
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_Circular:
                    addCirclePolList(point, radius);
                    break;
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_Polygonal:
                    addPolyPolList(region);
                    break;
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_RectangularSet:
                    break;
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_Identified:
                    break;
            }
            
        }

        //add marker to map
        private void addMarker(PointLatLng point)
        {
            if (marker != null)
            {
                marker.Position = point; //marker 위치변경
            }
            else
            {
                marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot); //marker 생성

                //marker 등록
                overlay.Markers.Add(marker);
            }
        }

        private void btnMapLoad_Click(object sender, EventArgs e)
        {
            try
            {
                double latitude = double.Parse(txtBoxLat.Text); //위도-y
                double longitude = double.Parse(txtBoxLng.Text); //경도-x

                PointLatLng point = new PointLatLng(latitude, longitude); //(y,x)

                if (-90 < latitude && latitude < 90 && -180 < longitude && longitude < 180)
                {
                    ////////map attribute///////
                    setMap(point);

                    ///////////////////marker////////////////
                    addMarker(point);

                    /////////////////polygon/////////////////
                    //if (polygon != null) //map에 있는 polygon 없애기
                    //{
                    //    polList.Clear();
                    //    overlay.Polygons.Remove(polygon);
                    //    polygon = null;
                    //}

                    ///////////marker+polygon///////////////
                    map.Overlays.Add(overlay);

                    //////////listview enabled region image//////////////
                    addListViewEnabledRegion(latitude, longitude);
                }
                else
                {
                    MessageBox.Show("Enter the correct number");
                }
            }
            catch (Exception) { }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            map.Zoom += 1;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            map.Zoom -= 1;
        }

        private void mapLoadByCert(Dot2CertValidRegion region)
        {
            PointLatLng point;

            switch (region.region_type)
            {
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_Circular:
                    {
                        double latitude = (double)region.circular.center.lat / 10000000;
                        double longitude = (double)region.circular.center.lon / 10000000;
                        point = new PointLatLng(latitude, longitude); //(y,x)

                        setMap(point);
                        addMarker(point);
                        addPolygon(point, ((double)region.circular.radius / 88400), region); //0.01-약 885.9m //0.1-약 8.84km //1-약 88km
                        map.Overlays.Add(overlay);
                        map.Zoom++;
                        map.Zoom--;
                    }
                    break;
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_RectangularSet:
                    {
                    }
                    break;
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_Polygonal:
                    {
                        point = new PointLatLng(region.polygonal.point_lat[0], region.polygonal.point_lon[0]);
                        overlay.Markers.Remove(marker);
                        marker = null;

                        setMap(point);
                        addPolygon(point, 0, region);
                        map.Overlays.Add(overlay);
                    }
                    break;
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_Identified:
                    {
                    }
                    break;
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_Unknown: break;
            }
        }
    }
}
