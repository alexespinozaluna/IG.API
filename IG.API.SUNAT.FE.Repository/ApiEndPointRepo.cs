using Dapper;
using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace IG.API.SUNAT.FE.Repository
{
    public class ApiEndPointRepo : RepositoryBase<APIEndPoint>, IApiEndPointRepo
    {
        public ApiEndPointRepo(IGAPIFEAppDbContext context) : base(context)
        {
        }

        public async Task<ApiEndPointInfo> GetApiEndPointInfoAsync(int IdmaeEmpresa, string CodApiEndPoint)
        {

            var query = await Context.Database.GetDbConnection()
              .QueryAsync<ApiEndPointInfo>("spGetApiEndPointInfo",
              commandType: CommandType.StoredProcedure,
              param: new
              {
                  IdmaeEmpresa = IdmaeEmpresa,
                  CodApiEndPoint = CodApiEndPoint
              });

            return query.First();


        }
    }
}
