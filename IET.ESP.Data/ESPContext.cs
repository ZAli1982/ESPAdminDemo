using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IET.ESP.Model.Entities;
using System.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace IET.ESP.Data
{
    public class ESPContext : DbContext
    {
        public ESPContext()
            : base(nameOrConnectionString: ESPContext.ConnectionStringName)
        {
            var _ = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            Database.SetInitializer<ESPContext>(null);
        }

        public DbSet<ContentType> ContentTypeSet { get; set; }
        public DbSet<Sale> SaleSet { get; set; }

        public static string ConnectionStringName
        {
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionStringName"] != null)
                {
                    return ConfigurationManager.AppSettings["ConnectionStringName"].ToString();
                }

                return "DefaultConnect";
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<ContentType>().HasKey<int>(e => e.Id);
        }
    }
}
