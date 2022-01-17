using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static class ManipulasiNamaNegeri
    {
        public static string NamaPenuhNegeri(this string negeri)
        {
            switch (negeri)
            {
                case "JHR":
                    return "Johor";
                case "MLK":
                    return "Melaka";
                case "NSN":
                    return "Negeri Sembilan";
                case "SGR":
                    return "Selangor";
                case "KUL":
                    return "Kuala Lumpur";
                case "PRK":
                    return "Perak";
                case "KDH":
                    return "Kedah";
                case "PNG":
                    return "Pulau Pinang";
                case "PLS":
                    return "Perlis";
                case "KTN":
                    return "Kelantan";
                case "PHG":
                    return "Pahang";
                case "TRG":
                    return "Terengganu";
                case "PJY":
                    return "Putrajaya";
                case "SRW":
                    return "Sarawak";
                case "SBH":
                    return "Sabah";
                case "LBN":
                    return "Labuan";
                default: return "";
            }
        }

        public static string NamaSingkatNegeri(this string negeri)
        {
            switch (negeri.ToUpper())
            {
                case "JOHOR":
                    return "JHR";
                case "MELAKA":
                    return "MLK";
                case "NEGERISEMBILAN":
                    return "NSN";
                case "SELANGOR":
                    return "SGR";
                case "KUALALUMPUR":
                    return "KUL";
                case "PERAK":
                    return "PRK";
                case "KEDAH":
                    return "KDH";
                case "PULAUPINANG":
                    return "PNG";
                case "PERLIS":
                    return "PLS";
                case "KELANTAN":
                    return "KTN";
                case "PAHANG":
                    return "PHG";
                case "TERENGGANU":
                    return "TRG";
                case "PUTRAJAYA":
                    return "PJY";
                case "SARAWAK":
                    return "SRW";
                case "SABAH":
                    return "SBH";
                case "LABUAN":
                    return "LBN";
                default: return "";
            }
        }
    }
}
