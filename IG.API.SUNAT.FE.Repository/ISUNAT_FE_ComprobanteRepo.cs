using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Repository
{
    public interface ISUNAT_FE_ComprobanteRepo : IRepositoryBase<SUNAT_FE_Comprobante>
    {
       Task<int> GetIdByIdComprobanteAndTicket(string IdComprobante, string Ticket);
       Task<ICollection<SUNAT_FE_Comprobante>> GetByDate(ComprobanteFilterDto request);
    }
}
