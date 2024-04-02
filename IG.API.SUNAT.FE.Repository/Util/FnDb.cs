using Dapper;
using IG.API.SUNAT.FE.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace IG.API.SUNAT.FE.Repository.Util
{
    public class FnDb : IFnDb
    {
        protected readonly DbContext Context;
        public FnDb(IGAPIFEAppDbContext context)
        {
            Context = context;
        }
        public async Task<DateTime> GetDateTimeDb()
        {
            var query = await Context.Database.GetDbConnection()
                .QueryAsync<DateTime>("SELECT GETDATE() AS DateTimeDb", commandType: CommandType.Text);
            return query.First();
        }
    }
}
