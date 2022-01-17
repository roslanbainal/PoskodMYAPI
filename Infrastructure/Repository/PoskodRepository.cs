using Application.DTOs;
using Application.Extensions;
using Application.Interfaces;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PoskodRepository : IPoskodRepository
    {
        private readonly AppDbContext context;

        public PoskodRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<PoskodInfoBaruDTO> MaklumatPoskod(string poskod)
        {
            var poskodInfo = await context.Maklumat_Poskod.AsNoTracking().FirstOrDefaultAsync(x => x.Poskod == poskod);

            if (poskodInfo == null)
            {
                return new PoskodInfoBaruDTO();
            }

            return new PoskodInfoBaruDTO
            {
                Poskod = poskodInfo.Poskod,
                Bandar = poskodInfo.Bandar,
                Negeri = poskodInfo.Negeri.NamaPenuhNegeri(),
                Negara = "Malaysia"
            };
        }

        public async Task<PoskodBandarDTO> MaklumatPoskodBandar(string bandar)
        {

            var infoBandar = await context.Maklumat_Poskod.FirstOrDefaultAsync(x => x.Bandar.ToLower().Contains(bandar.ToLower()));
            //var t = await context.Maklumat_Poskod.FromSqlInterpolated($"Select * From \"poskod_baru\".\"Alamat_Penuh\" Where \"Bandar\" Like {bandar}").FirstOrDefaultAsync();

            if (infoBandar == null) return new PoskodBandarDTO();

            var infoFull = await context.Maklumat_Poskod.Where(x => x.Bandar.ToLower().Contains(bandar.ToLower())).
                Select(x => new { x.Poskod }).Distinct().AsNoTracking().ToListAsync();

            return new PoskodBandarDTO
            {
                Bandar = infoBandar.Bandar,
                Negeri = infoBandar.Negeri.NamaPenuhNegeri(),
                Jumlah = infoFull.Count(),
                SenaraiPoskod = infoFull.Select(x => x.Poskod).ToList()
            };
        }

        public async Task<PoskodNegeriDTO> MaklumatPoskodNegeri(string negeri)
        {
            var infoNegeri = await context.Maklumat_Poskod.AsNoTracking().FirstOrDefaultAsync(x => x.Negeri == negeri.NamaSingkatNegeri());

            if (infoNegeri == null)
            {
                return new PoskodNegeriDTO();
            }
            else
            {

                var fullInfo = await context.Maklumat_Poskod.Where(x => x.Negeri == negeri.NamaSingkatNegeri())
                    .Select(x => new { x.Poskod, x.Bandar }).Distinct().AsNoTracking().ToListAsync();

                return new PoskodNegeriDTO
                {
                    Negeri = infoNegeri.Negeri.NamaPenuhNegeri(),
                    Jumlah = fullInfo.Count(),
                    SenaraiPoskodKawasan = fullInfo.Select(x => new PoskodDanKawasanDTO
                    {
                        Poskod = x.Poskod,
                        Bandar = x.Bandar
                    }).OrderBy(x => x.Poskod).ToList(),
                };
            }

        }

        public async Task<MaklumatPoskodDTO> SenaraiMaklumatPoskod(string poskod)
        {

            var poskodInfo = await context.Maklumat_Poskod.FirstOrDefaultAsync(x => x.Poskod == poskod);

            if (poskodInfo == null)
            {
                return new MaklumatPoskodDTO();
            }

            return new MaklumatPoskodDTO
            {
                Poskod = poskodInfo.Poskod,
                Bandar = poskodInfo.Bandar,
                Negeri = poskodInfo.Negeri.NamaPenuhNegeri(),
                Negara = "Malaysia",
                SenaraiMaklumatPoskod = await context.Maklumat_Poskod.Where(x => x.Poskod == poskodInfo.Poskod).Select(x => x.Lokasi).ToListAsync()
            };

        }


    }
}
