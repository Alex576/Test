using MapDAL.Banks;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapDAL.Entity;

namespace MapDAL.Context
{
    public class BanksContext : DbContext
    {
        public BanksContext() : base("BankConnectionString")
        {

        }
         protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kurs>().Property(p => p.By).HasPrecision(18, 5);
            modelBuilder.Entity<Kurs>().Property(p => p.Sell).HasPrecision(18, 5);

            base.OnModelCreating(modelBuilder);

        // Database.SetInitializer(new DropCreateDatabaseAlways<BanksContext>());
        }
        public DbSet<Bank> Banks { get; set; }     
        public DbSet<Kurs> Kurses { get; set; }
    }
}
