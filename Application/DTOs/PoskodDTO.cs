using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class PoskodBandarDTO
    {
        public string Bandar { get; set; }
        public string Negeri { get; set; }
        public int Jumlah { get; set; }
        public List<string> SenaraiPoskod { get; set; }
    }

    public class PoskodInfoBaruDTO
    {
        public string Poskod { get; set; }
        public string Bandar { get; set; }
        public string Negeri { get; set; }
        public string Negara { get; set; } = "Malaysia";
    }

    public class MaklumatPoskodDTO
    {
        public string Poskod { get; set; }
        public string Bandar { get; set; }
        public string Negeri { get; set; }
        public string Negara { get; set; }

        public List<string> SenaraiMaklumatPoskod { get; set; }
    }

    public class PoskodNegeriDTO
    {
        public string Negeri { get; set; }
        public int Jumlah { get; set; }
        public List<PoskodDanKawasanDTO> SenaraiPoskodKawasan { get; set; }
    }

    public class PoskodDanKawasanDTO
    {
        public string Poskod { get; set; }
        public string Bandar { get; set; }
    }
}
