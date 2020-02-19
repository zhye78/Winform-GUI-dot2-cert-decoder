using System;
using System.Windows.Forms;
using static WindowsFormsApp3.DllImport;

namespace WindowsFormsApp3
{
    public partial class Form
    {
        private void PrintDot2CertType(Dot2CertType type)
        {
            this.gridView[0, 0].Value = "인증서 유형";
            this.gridView[1, 0].Value = "";

            if (type.ToString() == "kDot2CertType_Explicit")
                this.gridView[1, 0].Value = "explicit";
            else
                this.gridView[1, 0].Value = "implicit";
        }

        private void PrintDot2CertIssuerId(Dot2CertIssuerId id)
        {
            this.gridView[0, 1].Value = "발행자 ID";
            this.gridView[1, 1].Value = "";
            
            switch (id.issuer_id_type)
            {
                case Dot2CertIssuerIdType.kDot2CertIssuerIdType_Sha256HashedId8:
                    this.gridView[1, 1].Value = "-type: sha256 hashedid8" + Environment.NewLine
                        + "-id: 0x" 
                        + Convert.ToString(id.issuer_hashedid8[0], 16) + Convert.ToString(id.issuer_hashedid8[1], 16) 
                        + Convert.ToString(id.issuer_hashedid8[2], 16) + Convert.ToString(id.issuer_hashedid8[3], 16) 
                        + Convert.ToString(id.issuer_hashedid8[4], 16) + Convert.ToString(id.issuer_hashedid8[5], 16) 
                        + Convert.ToString(id.issuer_hashedid8[6], 16) + Convert.ToString(id.issuer_hashedid8[7], 16);
                    break;
                case Dot2CertIssuerIdType.kDot2CertIssuerIdType_HashAlgorithm:
                    this.gridView[1, 1].Value = "-type: sha256 hashedid8" + Environment.NewLine
                        + "-id: 0x" + id.issuer_alg;
                    break;
                case Dot2CertIssuerIdType.kDot2CertIssuerIdType_Sha384HashedId8:
                    this.gridView[1, 1].Value = "-type: sha256 hashedid8" + Environment.NewLine
                        + "-id: 0x" 
                        + Convert.ToString(id.issuer_hashedid8[0], 16) + Convert.ToString(id.issuer_hashedid8[1], 16) 
                        + Convert.ToString(id.issuer_hashedid8[2], 16) + Convert.ToString(id.issuer_hashedid8[3], 16) 
                        + Convert.ToString(id.issuer_hashedid8[4], 16) + Convert.ToString(id.issuer_hashedid8[5], 16) 
                        + Convert.ToString(id.issuer_hashedid8[6], 16) + Convert.ToString(id.issuer_hashedid8[7], 16);
                    break;
                case Dot2CertIssuerIdType.kDot2CertIssuerIdType_Unknown:
                default:
                    this.gridView[1, 1].Value = "-type: unknown";
                    break;
            }
        }

        private void PrintDot2CertValidPeriod(Dot2CertValidPeriod period)
        {
            this.gridView[0, 2].Value = "유효 기간";
            this.gridView[1, 2].Value = "";

            this.gridView[1, 2].Value = "-Start: " + period.start.year + "-" + changeStr(period.start.month.ToString()) + "-" + changeStr(period.start.day.ToString()) + " "
                + changeStr(period.start.hour.ToString()) + ":" + changeStr(period.start.minute.ToString()) + ":" + changeStr(period.start.second.ToString()) 
                + Environment.NewLine
                + "-End: " + period.end.year + "-" + changeStr(period.end.month.ToString()) + "-" + changeStr(period.end.day.ToString()) + " "
                + changeStr(period.end.hour.ToString()) + ":" + changeStr(period.end.minute.ToString()) + ":" + changeStr(period.end.second.ToString());
        }

        private void PrintDot2CertValidRegion(Dot2CertValidRegion region)
        {
            this.gridView[0, 3].Value = "유효 지역";
            this.gridView[1, 3].Value = "";

            if (region.present == false)
                return;

            switch (region.region_type)
            {
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_Circular:
                    {
                        Dot2CircularRegion c = region.circular;
                        this.gridView[0, 3].Value += "(circular)";
                        this.gridView[1, 3].Value = "-center lat: " + c.center.lat
                            + Environment.NewLine + "-center lon: " + c.center.lon
                            + Environment.NewLine + "-radius: " + c.radius + "m";
                    }
                    break;
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_RectangularSet:
                    {
                        Dot2RectangularRegionSet set = region.rectangular;

                        this.gridView[0, 3].Value += "(rectangular)";
                        this.gridView[1, 3].Value = "-region num: " + set.region_num + Environment.NewLine;

                        for (int i = 0; i < set.region_num; i++)
                        {
                            this.gridView[1,3].Value += "Region[" + i + "] notrh/west lat: " + set.north_west_lat[i] + ", lon: " + set.north_west_lon[i]
                                + ", south/east lat: " + set.south_east_lat + ", lon: " + set.south_east_lon;
                            if (i != set.region_num - 1)
                                this.gridView[1, 3].Value += Environment.NewLine;
                        }
                    }
                    break;
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_Polygonal:
                    {
                        Dot2PolygoanlRegion p = region.polygonal;

                        this.gridView[0, 3].Value += "(polygonal)";
                        this.gridView[1, 3].Value = "-point num: " + p.point_num + Environment.NewLine;

                        for (int i = 0; i < p.point_num; i++)
                        {
                            this.gridView[1, 3].Value += "Point[" + i + "] lat: " + p.point_lat[i] + ", lon: " + p.point_lon[i];
                            if (i != p.point_num - 1)
                                this.gridView[1, 3].Value += Environment.NewLine;
                        }
                    }
                    break;
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_Identified:
                    {
                        Dot2IdentifiedRegionSet set = region.identified;

                        this.gridView[0, 3].Value += "(identified)";
                        this.gridView[1, 3].Value = "-num :" + set.num + Environment.NewLine;

                        for (int i = 0; i < set.num; i++)
                        {
                            this.gridView[1, 3].Value += "Region[" + i + "] - Type: " + set.type[i].ToString().Substring(26, set.type[i].ToString().Length - 26) 
                                + ", Country: " + set.country[i];
                            if (i != set.num - 1)
                                this.gridView[1, 3].Value += Environment.NewLine;
                        }
                    }
                    break;
                case Dot2GeogarphicRegionType.kDot2GeogarphicRegionType_Unknown:
                    this.gridView[0, 3].Value += "(unknown)";
                    break;
                default: break;
            }
        }

        private void PrintDot2CertAppPermissions(Dot2CertAppPermissions permissions)
        {
            int count = 0;
            this.gridView[1, 4].Value = "";

            if (permissions.present == false)
                return;

            this.gridView[0, 4].Value = "어플리케이션 권한";
            this.gridView[1, 4].Value = "-num: " + permissions.permission_num + Environment.NewLine;

            for(int i = 0; i < permissions.permission_num; i++)
            {
                this.gridView[1, 4].Value += "permission[" + i + "] - psid: " + permissions.psid[i] + ", ssp: ";
                for (int j = 0; j < permissions.ssp_len[i]; j++)
                {
                    this.gridView[1, 4].Value += permissions.ssp;
                    count += permissions.ssp.Length;
                }
                if (count == 0)
                    this.gridView[1, 4].Value += "null";
                if (i != permissions.permission_num - 1)
                    this.gridView[1, 4].Value += Environment.NewLine;
            }
        }

        private void PrintDot2CertHash(byte[] certHash)
        {
            this.gridView[0, 5].Value = "SHA256 Hash";
            this.gridView[1, 5].Value = "0x";
            for(int i = 0; i < 32; i++)
                this.gridView[1, 5].Value += Convert.ToString(certHash[i], 16);
        }

        private void PrintDot2CertHashedid10(byte[] certHashid10)
        {
            this.gridView[0, 6].Value = "HashedId10";
            this.gridView[1, 6].Value = "0x";
            for (int i = 0; i < 10; i++)
                this.gridView[1, 6].Value += Convert.ToString(certHashid10[i], 16);
        }

        private void PrintDot2CertHashedid8(byte[] certHashid8)
        {
            this.gridView[0, 7].Value = "HashedId8";
            this.gridView[1, 7].Value = "0x";
            for (int i = 0; i < 8; i++)
                this.gridView[1, 7].Value += Convert.ToString(certHashid8[i], 16);
        }
    }
}
