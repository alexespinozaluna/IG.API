using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IG.API.SUNAT.FE.Persistence
{
    public class IGAPIFEAppDbContext :DbContext
    {
        public IGAPIFEAppDbContext(DbContextOptions<IGAPIFEAppDbContext> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            // Esta linea va a traer toda la configuracion de las tablas asociadas a la aplicacion
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
