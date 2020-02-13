using System;
using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{
    public partial class Form
    {
        //처리 결과 코드
        public enum Dot2Result
        {
            kDot2Result_Success,
        };

        /// 인증서 유형
        public enum Dot2CertType
        {
            kDot2CertType_Explicit,  ///< Explicit 인증서
            kDot2CertType_Implicit,  ///< Implicit 인증서
        };

        /// 인증서 발행자 식별자 유형
        public enum Dot2CertIssuerIdType
        {
            kDot2CertIssuerIdType_Sha256HashedId8,  ///< SHA-256 HashedID8 를 통해 식별
            kDot2CertIssuerIdType_HashAlgorithm,    ///< 해시알고리즘을 통해 식별 
            kDot2CertIssuerIdType_Sha384HashedId8,  ///< SHA-384 HashedID8 를 통해 식별
            kDot2CertIssuerIdType_Unknown,          ///< 알 수 없는 유형
        };

        /// 해시 알고리즘 유형
        public enum Dot2HashAlgorithm
        {
            kDot2HashAlgorithm_Sha256, ///< SHA-256 해시 알고리즘
            kDot2HashAlgorithm_Sha384, ///< SHA-384 해시 알고리즘
        };

        /// 영역정보 유형
        public enum Dot2GeogarphicRegionType
        {
            kDot2GeogarphicRegionType_Circular,        ///< 원형 영역정보
            kDot2GeogarphicRegionType_RectangularSet,  ///< 사각형 영역정보집합
            kDot2GeogarphicRegionType_Polygonal,       ///< 폴리곤(다각형) 영역정보
            kDot2GeogarphicRegionType_Identified,      ///< 식별자 기반 영역정보 (예: 한국은 X 번)
            kDot2GeogarphicRegionType_Unknown,         ///< 알 수 없는 영역정보 유형
        };

        /// 식별자 기반 영역정보 유형
        public enum Dot2IdentifiedRegionType
        {
            kDot2IdentifiedRegionType_CountryOnly,          ///< 국가 식별자만 포함된 영역정보
            kDot2IdentifiedRegionType_CountryAndRegions,    ///< 국가 및 지역 식별자 포함 영역정보
            kDot2IdentifiedRegionType_CountryAndSubregions, ///< 국가 및 지역, 부지역 식별자 포함 영역정보
            kDot2IdentifiedRegionType_Unknown,              ///< 알 수 없는 영역정보 유형
        };

        /// 인증서 발행자에 대한 식별자 정보
        public struct Dot2CertIssuerId
        {
            /// 인증서 발행자를 나타내는 식별자 유형.
            /// 본 유형의 값에 따라 아래 issuer_alg, issuer_hashedid8 변수 중 하나가 저장된다.
            public Dot2CertIssuerIdType issuer_id_type;
            public Dot2HashAlgorithm issuer_alg;             ///< 알고리즘 유형으로 표시되는 인증서 발행자 식별자
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public byte[] issuer_hashedid8;  ///< Hashedid8 형식으로 표시되는 인증서 발행자 식별자
            //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)] public String issuer_hashedid8;
        }

        public struct Dot2CertTime
        {
            public uint year;
            public uint month;
            public uint day;
            public uint hour;
            public uint minute;
            public uint second;
        }

        /// 인증서 유효기간 정보
        public struct Dot2CertValidPeriod
        {
            public Dot2CertTime start;  ///< 유효기간 시작 시점
            public Dot2CertTime end;
        }

        /// 좌표 정보
        public struct Dot2TwoDLocation
        {
            public int lat;  ///< 위도
            public int lon;  ///< 경도
        }

        /// 원형 영역정보
        public struct Dot2CircularRegion
        {
            public Dot2TwoDLocation center;   ///< 중심점 좌표
            public uint radius;              ///< 반지름(미터단위)
        }

        /// 사각형 영역정보
        public struct Dot2RectangularRegion
        {
            public Dot2TwoDLocation north_west;   ///< 북서 지점 좌표
            public Dot2TwoDLocation south_east;   ///< 남동 지점 좌표
        }

        /// 사각형 영역정보 집합
        public struct Dot2RectangularRegionSet
        {
            public uint region_num;    ///< 사각형 영역정보 개수
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public int[] north_west_lat;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public int[] north_west_lon;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public int[] south_west_lat;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public int[] south_west_lon;
        }

        /// 폴리곤(다각형) 영역정보 
        public struct Dot2PolygoanlRegion
        {
            public uint point_num;     ///< 포인트 개수
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] public Dot2TwoDLocation[] point;  ///< 포인트(들)
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public int[] point_lat;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public int[] point_lon;
        }

        /// 국가 및 지역 식별자 기반 영역정보
        public struct Dot2CountryAndRegions
        {
            public uint country;
            public uint region_num;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public uint[] region;
        }

        /// 지역 및 부지역 식별자 기반 영역정보
        public struct Dot2RegionAndSubregions
        {
            public uint region;
            public uint subregion_num;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public uint[] subregion;
        }

        /// 국가 및 지역, 부지역 식별자 기반 영역정보
        public struct Dot2CountryAndSubregions
        {
            public uint country;
            public uint region_subregion_num;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public Dot2RegionAndSubregions[] region_subregion;
        }

        /// 식별자 기반 영역정보
        public struct Dot2IdentifiedRegion
        {
            /// 영역정보 유형
            /// 본 유형에 따라 아래 union 내 변수 중 하나가 저장된다.
            public Dot2IdentifiedRegionType type;
            public uint country;
            public Dot2CountryAndRegions country_and_regions;
            public Dot2CountryAndSubregions country_and_subregions;
        }

        /// 식별자 기반 영역정보 집합
        public struct Dot2IdentifiedRegionSet
        {
            public uint num;      ///< 영역정보 개수
            //public Dot2IdentifiedRegion[] region;  ///< 영역정보(들)
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public Dot2IdentifiedRegionType[] type;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public uint[] country;
        }

        /// 인증서 유효지역 정보
        public struct Dot2CertValidRegion
        {
            /// 유효지역 정보 존재 여부 (본 정보는 옵션으로써, 인증서에 따라 존재하지 않을 수 있음)
            public bool present;
            /// 인증서 유효지역 유형
            /// 본 유형에 따라 아래 union 내 변수 중 하나가 저장된다.
            public Dot2GeogarphicRegionType region_type;
            public Dot2CircularRegion circular;
            public Dot2RectangularRegionSet rectangular;
            public Dot2PolygoanlRegion polygonal;
            public Dot2IdentifiedRegionSet identified;
        }

        /// PSID 정보
        public struct Dot2Psid
        {
            public uint psid;    ///< 10진수 숫자로 표시되는 PSID
            public uint p_encoded_psid_len;                  ///< p-encoded PSID 길이
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] byte[] p_encoded_psid;   ///< p-encoded PSID
        }

        /// SSP(Service Specific Permission) 정보
        public struct Dot2Ssp
        {
            public uint ssp_len;     ///< SSP 정보 길이
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] byte[] ssp; ///< SSP 정보
        }

        /// PSID & SSP 정보
        public struct Dot2PsidSsp
        {
            public Dot2Psid psid;       ///< PSID 정보
            public Dot2Ssp ssp;         ///< SSP 정보
        }

        /// 어플리케이션 권한 정보
        public struct Dot2CertAppPermissions
        {
            /// 어플리케이션 권한 정보 존재 여부 (본 정보는 옵션으로써, 인증서에 따라 존재하지 않을 수 있음)
            public bool present;
            /// 권한 개수
            public uint permission_num;
            /// 권한 리스트
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public uint[] psid;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public uint[] ssp_len;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] public String ssp;
        }

        /// 인증서 정보
        ///
        /// DecodeDot2Certificate() API 호출 시 반환되는 정보
        public struct Dot2CertificateInfo
        {
            /// API 수행 결과
            /// 성공 시 0, 실패 시 -1이 저장된다.
            public int result;

            /// 인증서 유형
            public Dot2CertType cert_type;

            /// 인증서 발행자에 대한 식별자
            public Dot2CertIssuerId issuer_id;

            /// 인증서 유효기간
            public Dot2CertValidPeriod valid_period;

            /// 인증서 유효지역
            public Dot2CertValidRegion valid_region;

            /// 어플리케이션 권한
            public Dot2CertAppPermissions app_permissions;

            /// 인증서에 대한 SHA-256 해시 값
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public byte[] cert_hash;

            /// 인증서에 대한 HashedID10 값 - cert_hash 의 마지막 10바이트
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)] public byte[] cert_hashedid10;

            /// 인증서에 대한 HashedID8 값 - cert_hash 의 마지막 8바이트
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public byte[] cert_hashedid8;

            /// 인증서 컨텐츠 문자열
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2000)] public String contents_str;
        };

        [DllImport("dot2-cert-decoder.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DecodeDot2Certificate(byte[] cert, int cert_size, ref Dot2CertificateInfo info);
    }
}
