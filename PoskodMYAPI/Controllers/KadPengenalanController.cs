using Application.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoskodMYAPI.Controllers
{
    public class KadPengenalanController : BaseApiController
    {
        [HttpGet]
        public IActionResult MaklumatKadPengenalan(string kadPengenalan)
        {
            var kadInfo = MaklumatPeribadi.MaklumatKadPengenalan(kadPengenalan);

            if (kadInfo.Umur == 0 || string.IsNullOrEmpty(kadInfo.TarikhLahir) || string.IsNullOrEmpty(kadInfo.NegeriKelahiran))
                return BadRequest(new { errorMessage = "Sila masukkan format yang betul" }); 
            return Ok(kadInfo);
        }
    }
}
