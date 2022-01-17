using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoskodMYAPI.Controllers
{
    public class PoskodController : BaseApiController
    {
        private readonly IPoskodRepository poskodRepository;

        public PoskodController(IPoskodRepository poskodRepository)
        {
            this.poskodRepository = poskodRepository;
        }

        [HttpGet("MaklumatPoskod/{poskod}")]
        public async Task<ActionResult> Poskod(string poskod)
        {
            var poskodInfo = await poskodRepository.MaklumatPoskod(poskod);

            if (string.IsNullOrEmpty(poskodInfo.Poskod)) return NotFound(new { errorMessage = "Maklumat Tidak Dijumpai" }); 

            return Ok(poskodInfo);
        }

        [HttpGet("SenaraiMaklumatPoskod/{poskod}")]
        public async Task<ActionResult> SenaraiMaklumatPoskod(string poskod)
        {
            var poskodInfo = await poskodRepository.SenaraiMaklumatPoskod(poskod);

            if (string.IsNullOrEmpty(poskodInfo.Poskod)) return NotFound(new { errorMessage = "Maklumat Tidak Dijumpai" });

            return Ok(poskodInfo);
        }

        [HttpGet("SenaraiPoskodNegeri/{negeri}")]
        public async Task<ActionResult> SenaraiMaklumatPoskodNegeri(string negeri)
        {
            var poskodInfo = await poskodRepository.MaklumatPoskodNegeri(negeri);

            if (string.IsNullOrEmpty(poskodInfo.Negeri)) return NotFound(new { errorMessage = "Maklumat Tidak Dijumpai" });

            return Ok(poskodInfo);
        }

        [HttpGet("SenaraiPoskodBandar/{bandar}")]
        public async Task<ActionResult> SenaraiMaklumatPoskodBandar(string bandar)
        {
            var poskodInfo = await poskodRepository.MaklumatPoskodBandar(bandar);

            if (string.IsNullOrEmpty(poskodInfo.Bandar)) return NotFound(new { errorMessage = "Maklumat Tidak Dijumpai" });

            return Ok(poskodInfo);
        }
    }
}
