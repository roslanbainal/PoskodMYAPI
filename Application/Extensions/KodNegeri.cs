using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static class KodNegeri
    {
        public static string KodNegeriKelahiran(this string kodIc)
        {
            switch (kodIc)
            {
                case "01":
                    return "Johor";
                case "02":
                    return "Kedah";
                case "03":
                    return "Kelantan";
                case "04":
                    return "Melaka";
                case "05":
                    return "Negeri Sembilan";
                case "06":
                    return "Pahang";
                case "07":
                    return "Pulau Pinang";
                case "08":
                    return "Perak";
                case "09":
                    return "Perlis";
                case "10":
                    return "Selangor";
                case "11":
                    return "Terengganu";
                case "12":
                    return "Sabah";
                case "13":
                    return "Sarawak";
                case "14":
                    return "Wilayah Perseketuan (KL)";
                case "15":
                    return "Wilayah Perseketuan (Labuan)";
                case "16":
                    return "Wilayah Perseketuan (Putrajaya)";
                case "82":
                    return "Negeri Tidak Diketahui";
                default: return "";

            }
        }
    }
}
