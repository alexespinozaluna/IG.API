using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace IG.API.SUNAT.FE.Repository
{
    public class SUNAT_FE_ComprobanteRepo : RepositoryBase<SUNAT_FE_Comprobante>, ISUNAT_FE_ComprobanteRepo
    {
        public SUNAT_FE_ComprobanteRepo(IGAPIFEAppDbContext context) : base(context)
        {
        }

        public async Task<ICollection<SUNAT_FE_Comprobante>> GetByDate(ComprobanteFilterDto request)
        {
            // Codigo
            var response = await Task.Run(() =>
            {
                return Context.Set<SUNAT_FE_Comprobante>()
                .AsNoTracking()
                      .Where(p =>
                      p.IdmaeEmpresa == request.IdmaeEmpresa
                      && (p.FechaCreacion.Date >= request.FechaInicio.Date && p.FechaCreacion.Date <= request.FechaFin.Date))
                      .ToList();
            });

            return response;
        }

        public async Task<int> GetIdByIdComprobanteAndTicket(string IdComprobante, string Ticket)
        {
            // Codigo
            int maxId = await Task.Run(() =>
            {
                return Context.Set<SUNAT_FE_Comprobante>()
                      .AsNoTracking()
                      .Where(p => p.IdComprobante == IdComprobante && p.Ticket == Ticket)
                      .Max(c => (int?)c.Id) ?? 0;
            });

            return maxId;
        }
    }
}
