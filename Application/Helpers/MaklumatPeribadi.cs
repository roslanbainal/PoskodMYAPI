using Application.DTOs;
using Application.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helpers
{
    public static class MaklumatPeribadi
    {
        public static Maklumat_IC_DTO MaklumatKadPengenalan(this string ic)
        {
            try
            {
                var tahun = ic.Substring(0, 2);
                var bulan = ic.Substring(2, 2);
                var hari = ic.Substring(4, 2);
                var kodNegeri = ic.Substring(6, 2);
                var icAkhir = ic.Substring(8,4);

                int umur = 0;
                string jantina = string.Empty;
                string tarikhLahir = string.Empty;

                var tahunSekarang = DateTime.Now.Year;

                if (int.Parse(tahun) <= 20)
                {
                    var tkhlahir = hari + "/" + bulan + "/20" + tahun;
                    tarikhLahir = tkhlahir;
                    var getyear = "20" + tahun;
                    umur = tahunSekarang - int.Parse(getyear);
                }
                else
                {
                    var tkhlahir = hari + "/" + bulan + "/19" + tahun;
                    tarikhLahir = tkhlahir;
                    var getyear = "19" + tahun;
                    umur = tahunSekarang - int.Parse(getyear);
                }

                //cek jantina 
                if (int.Parse(icAkhir) % 2 == 0)
                {
                    jantina = "Perempuan";
                }
                else
                {
                    jantina = "Lelaki";
                }

                return new Maklumat_IC_DTO
                {
                    KadPengenalan = ic,
                    Umur = umur,
                    Jantina = jantina,
                    TarikhLahir = tarikhLahir,
                    NegeriKelahiran = kodNegeri.KodNegeriKelahiran()
                };
            }
            catch (Exception)
            {
                return new Maklumat_IC_DTO();
            }

        }
    }
}
