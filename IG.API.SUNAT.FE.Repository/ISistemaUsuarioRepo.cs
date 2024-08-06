using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Repository
{
    public interface ISistemaUsuarioRepo : IRepositoryBase<SistemaUsuario>
    {
        Task<SistemaUsuario> GetUsuario(string CodUsuario);

    }
}
