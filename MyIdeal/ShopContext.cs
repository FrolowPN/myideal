using MyIdeal.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIdeal
{
    public class ShopContext: DbContext
    {
        public ShopContext()
            : base("Flamingo")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ShopContext, Configuration>(true));

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Label> Label { get; set; }
        public DbSet<SaleProduct> SaleProduct { get; set; }

    }
}
