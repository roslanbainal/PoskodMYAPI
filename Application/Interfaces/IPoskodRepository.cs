using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPoskodRepository
    {
        Task<PoskodInfoBaruDTO> MaklumatPoskod(string poskod);
        Task<MaklumatPoskodDTO> SenaraiMaklumatPoskod(string poskod);
        Task<PoskodNegeriDTO> MaklumatPoskodNegeri(string negeri);
        Task<PoskodBandarDTO> MaklumatPoskodBandar(string bandar);
    }
}
