using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using static WindowsFormsApp3.DllImport;

namespace WindowsFormsApp3
{
    public partial class Form
    {
        private int count = 1;
        private string fileForePath;
        private int sortColumn = -1; //정렬기준 column
        private bool resizing = false;

        private Dot2CertificateInfo setListInfo = new Dot2CertificateInfo();

        //[HandleProcessCorruptedStateExceptions]
        private void getFileList(string openPath)
        {
            try
            {
                //dir open
                if (openDirPath != null)
                {
                    DirectoryInfo di = new DirectoryInfo(openPath);

                    //이곳의 파일 탐색
                    foreach (FileInfo file in di.GetFiles())
                    {
                        if(file.Extension.ToLower().CompareTo(".cert") == 0 || file.Extension.ToLower().CompareTo("") == 0)
                        {
                            setList(file, count);
                            count++;
                        }
                    }
                    //이곳의 디렉토리 탐색
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        getFileList(dir.FullName); //재귀호출
                    }
                }

                //file open
                else
                {
                    FileInfo fi = new FileInfo(openPath);

                    if (fi.Extension.ToLower().CompareTo(".cert") == 0 || fi.Extension.ToLower().CompareTo("") == 0)
                        setList(fi, 1);
                    else
                        MessageBox.Show("인증서 파일을 선택해 주세요");
                }
            }
            catch (Exception) { }
}

        //한자리 숫자 앞에 0 붙여서 리턴
        private string changeStr(string s)
        {
            int a = int.Parse(s);
            if (a == 0)
                return "01";
            else if (0 < a && a < 10)
                return "0" + s;
            else return s;
        }
        
        private string changeYearStr(string s)
        {
            if (int.Parse(s) == 0)
                return "100" + s;
            else
                return s;
        }

        //listview에 항목 추가하는 함수
        private void setList(FileInfo file, int num)
        {
            ListViewItem item = new ListViewItem(num.ToString());
            item.UseItemStyleForSubItems = false;

            byte[] certValue = File.ReadAllBytes(file.FullName); //인증서 파일 내용 읽어오기
            DllImport.DecodeDot2Certificate(certValue, certValue.Length, ref setListInfo); //읽어온 파일 내용 분석

            item.SubItems.Add(getSimplePath(file.FullName)); //파일 경로
            if (setListInfo.result == 0) //분석 성공시
            {
                String regionType = setListInfo.valid_region.region_type.ToString()
                    .Substring(26, setListInfo.valid_region.region_type.ToString().Length - 26);

                Dot2CertTime starTime = setListInfo.valid_period.start;
                Dot2CertTime endTime = setListInfo.valid_period.end;

                string start = changeYearStr(starTime.year.ToString()) + changeStr(starTime.month.ToString()) + changeStr(starTime.day.ToString()) + " " 
                    + changeStr(starTime.hour.ToString()) + changeStr(starTime.minute.ToString()) + changeStr(starTime.second.ToString());
                string end = changeYearStr(endTime.year.ToString()) + changeStr(endTime.month.ToString()) + changeStr(endTime.day.ToString()) + " " 
                    + changeStr(endTime.hour.ToString()) + changeStr(endTime.minute.ToString()) + changeStr(endTime.second.ToString());
                DateTime startDay = DateTime.ParseExact(start, "yyyyMMdd HHmmss", CultureInfo.InvariantCulture);
                DateTime endDay = DateTime.ParseExact(end, "yyyyMMdd HHmmss", CultureInfo.InvariantCulture);
                
                //파일 유효기간
                item.SubItems.Add(starTime.year + "." + changeStr(starTime.month.ToString()) + "." + changeStr(starTime.day.ToString())
                    + "  " + changeStr(starTime.hour.ToString()) + ":" + changeStr(starTime.minute.ToString()) + ":" + changeStr(starTime.second.ToString())
                    + " ~ " 
                    + endTime.year + "." + changeStr(endTime.month.ToString()) + "." + changeStr(endTime.day.ToString())
                    + "  " + changeStr(endTime.hour.ToString()) + ":" + changeStr(endTime.minute.ToString()) + ":" + changeStr(endTime.second.ToString()));
                item.SubItems.Add(regionType); //파일 유효지역

                //현재 날짜와 시간이 인증서 유효기간 내에 있으면 활성표시
                if (DateTime.Compare(currentTime, startDay) >= 0 && DateTime.Compare(currentTime, endDay) <= 0)
                    item.SubItems.Add("●");
                else
                    item.SubItems.Add("");

                if (regionType == "Identified")
                    item.SubItems.Add("-");
                else
                    item.SubItems.Add(""); //입력된 지역 유효여부-초기값 빈칸

                this.listView.Items.Add(item);
                item.SubItems[4].ForeColor = Color.Green;
                item.SubItems[5].ForeColor = Color.Black;
            }
            else //분석 실패시
            {
                item.SubItems.Add("00.00.00 00:00:00 ~ 00.00.00 00:00:00");
                item.SubItems.Add(""); //파일 유효지역
                item.SubItems.Add("");
                item.SubItems.Add(""); //입력된 지역 유효여부-초기값 빈칸
                this.listView.Items.Add(item);
            }
        }

        private double gn_GetBearingBetweenPoints(double lat1, double lon1, double lat2, double lon2)
        {
            double lat1_rad = (lat1 * Math.PI / 180);
            double lat2_rad = (lat2 * Math.PI / 180);
            double lon_diff_rad = ((lon2 - lon1) * Math.PI / 180);
            double y = Math.Sin(lon_diff_rad) * Math.Cos(lat2_rad);
            double x = Math.Cos(lat1_rad) * Math.Sin(lat2_rad) - Math.Sin(lat1_rad) * Math.Cos(lat2_rad) * Math.Cos(lon_diff_rad);

            return ((int)((Math.Atan2(y, x)) * 180 / Math.PI) + 360) % 360;
        }

        private double gn_GetDistanceBetweenPoints(double lat1, double lon1, double lat2, double lon2)
        {
            double theta, dist;

            if ((lat1 == lat2) && (lon1 == lon2))
                return 0;
            else
            {
                theta = lon1 - lon2;
                dist = Math.Sin((lat1 * Math.PI / 180)) * Math.Sin((lat2 * Math.PI / 180)) +
                       Math.Cos((lat1 * Math.PI / 180)) * Math.Cos((lat2 * Math.PI / 180)) *
                       Math.Cos((theta * Math.PI / 180));
                dist = Math.Acos(dist);
                dist = (dist * 180 / Math.PI);
                dist = dist * 60 * 1.1515;
                dist = dist * 1.609344 * 1000;  // 미터 단위로 변환
                return dist;
            }
        }

        //입력한 위도 경도에서 사용 가능한 인증서 표시하는 함수
        private void addListViewEnabledRegion(double lat, double lon)
        {
            double distance;
            double bearing;
            double relative_angle;
            double x;
            double y;
            double a;

            Dot2CertificateInfo certInfoForRegion = new Dot2CertificateInfo();

            //현재 리스트 순서대로 유효지역 확인
            for(int i = 0; i < this.listView.Items.Count; i++)
            {
                this.listView.Items[i].SubItems[5].Text = ""; //기존의 enabled region 표시 제거

                byte[] certValue = File.ReadAllBytes(fileForePath + this.listView.Items[i].SubItems[1].Text); //현재 리스트의 인증서 파일 내용 읽어오기
                DecodeDot2Certificate(certValue, certValue.Length, ref certInfoForRegion); //인증서 파일 분석
                Dot2CircularRegion circle = certInfoForRegion.valid_region.circular;

                distance = gn_GetDistanceBetweenPoints(lat, lon, (double)circle.center.lat / 10000000, (double)circle.center.lon / 10000000);
                bearing = gn_GetBearingBetweenPoints(lat, lon, (double)circle.center.lat / 10000000, (double)circle.center.lon / 10000000);
                relative_angle = bearing - 360;
                x = distance * Math.Cos(relative_angle * Math.PI / 180);
                y = distance * Math.Sin(relative_angle * Math.PI / 180);
                a = circle.radius;

                //비교하며 표기
                if ((1 - Math.Pow(x / a, 2) - Math.Pow(y / a, 2)) > 0)
                {
                    this.listView.Items[i].SubItems[5].ForeColor = Color.Blue;
                    this.listView.Items[i].SubItems[5].Text = "●";
                }
            }
        }

        //listview에 띄울 경로명 구하는 함수
        private string getSimplePath(string fullName)
        {
            string[] path = fullName.Split('\\');
            string simplePath = "";
            fileForePath = "";

            for (int i = 3; i > 0; i--)
                simplePath += path[path.Length - i] += '\\';

            for(int i = 0; i < path.Length - 3; i++)
                fileForePath += path[i] += "\\";

            return simplePath.Substring(0, (simplePath.Length - 1));
        }
        
        //listview의 각 항목 클릭할 때 호출되는 함수
        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            this.richTxtBox.Clear();
            this.gridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            int indexNum = this.listView.FocusedItem.Index;
            string path = fileForePath + this.listView.Items[indexNum].SubItems[1].Text;

            try
            {
                Dot2CertificateInfo certInfo = new Dot2CertificateInfo();

                byte[] certValue = File.ReadAllBytes(path); //인증서 파일 내용 읽어오기
                DecodeDot2Certificate(certValue, certValue.Length, ref certInfo); //인증서 분석 c 함수

                if (certInfo.result == 0) //분석 성공시
                {
                    //table(gridview)에 인증서 분석 내용 출력
                    PrintDot2CertType(certInfo.cert_type);
                    PrintDot2CertIssuerId(certInfo.issuer_id);
                    PrintDot2CertValidPeriod(certInfo.valid_period);
                    PrintDot2CertValidRegion(certInfo.valid_region);
                    PrintDot2CertAppPermissions(certInfo.app_permissions);
                    PrintDot2CertHash(certInfo.cert_hash);
                    PrintDot2CertHashedid10(certInfo.cert_hashedid10);
                    PrintDot2CertHashedid8(certInfo.cert_hashedid8);

                    //richTextBox에 인증서 분석 full contents 출력
                    string[] fullContents = certInfo.contents_str.Split('\n');
                    for(int i = 0; i < fullContents.Length; i++)
                        this.richTxtBox.AppendText(fullContents[i] + "\r\n");

                    mapLoadByCert(certInfo.valid_region); //지도 로드
                }
                else //분석 실패시
                {
                    for (int i = 0; i < 2; i++)
                        for (int j = 0; j < 8; j++)
                            this.gridView[i, j].Value = "";
                    this.gridView[1, 0].Value = "인증서 분석에 실패했습니다.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }

        //column header 클릭시 정렬
        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column.ToString() == "0")
                return;

            //클릭한 column이 이전 column과 다르면
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column; //정렬기준 column 갱신
                listView.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (listView.Sorting == SortOrder.Ascending)
                    listView.Sorting = SortOrder.Descending;
                else
                    listView.Sorting = SortOrder.Ascending;
            }

            this.listView.ListViewItemSorter = new Sorter();
            Sorter s = (Sorter)listView.ListViewItemSorter;
            s.order = listView.Sorting;
            s.column = e.Column;

            listView.Sort();
        }

        private void listView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        //폼 크기 조절될때 listview 항목 비율 자동조정
        private void listView_SizeChanged(object sender, EventArgs e)
        {
            if (!resizing)
            {
                resizing = true;

                if (listView != null)
                {
                    float totalColumnWidth = 0;

                    for (int i = 0; i < listView.Columns.Count; i++)
                        totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

                    for (int i = 0; i < listView.Columns.Count; i++)
                    {
                        float colPercentage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
                        listView.Columns[i].Width = (int)(colPercentage * listView.ClientRectangle.Width);
                    }
                }
            }
            resizing = false;
        }

        //listview 새로 갱신하기 직전
        private void setListView()
        {
            count = 1; //이전 listview의 item 개수 초기화
            this.listView.Items.Clear(); //listview clear
            this.richTxtBox.Clear();
            this.txtBoxLat.Clear();
            this.txtBoxLng.Clear();

            this.gridView.Rows.Clear();
            setGridView();
            this.gridView.Refresh();

            //새로운 파일이나 폴더가 open될 때마다 map도 초기화 해야함
            if (polygon != null) //map에 있는 polygon, marker 없애기
            {
                polList.Clear();
                overlay.Polygons.Remove(polygon);
                polygon = null;

                overlay.Markers.Remove(marker);
                marker = null;
            }
        }
    }
}
