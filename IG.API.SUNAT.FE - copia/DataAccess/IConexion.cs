using System.Collections;
using System.Data;

namespace IG.API.SUNAT.FE.DataAccess
{
    public interface IConexion
    {
        Task<DataTable> getDataAsync(string sql);
        Task<string> getNamespaceDataAsync(string cod, string nom);
        Task<int> InsertAsync(string sql, ArrayList sqlParametros);     
    }
}
