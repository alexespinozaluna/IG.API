using Dapper;
using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace IG.API.SUNAT.FE.Repository
{
    public class SUNATFEXMLEspacioNombreTagRepo : RepositoryBase<SUNATFEXMLEspacioNombreTag>, ISUNATFEXMLEspacioNombreTagRepo
    {
        public SUNATFEXMLEspacioNombreTagRepo(IGAPIFEAppDbContext context) : base(context)
        {
        }
        public async Task<string?> GetByCodAndProveedor(string Codigo, string proveedor)
        {
            var sql = $"SELECT {proveedor} AS Nombre FROM SUNATFEXMLEspacioNombreTag WHERE Codigo = '{Codigo}'";

            var query = await Context.Database.GetDbConnection()
              .QueryAsync<string>(sql, commandType: CommandType.Text);

            return query.First();


        }

    }
}
