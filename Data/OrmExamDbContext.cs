using Microsoft.EntityFrameworkCore;
using OrmExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class OrmExamDbContext : DbContext
    {
        public DbSet<ItemInfo> ItemInfos{ get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shiping> Shipings { get; set; }
        public DbSet<Total> Totals { get; set; }
        public DbSet<Unit> Units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FHVE43L\\SQLEXPRESS;Database=OrmExam;Trusted_Connection=True;");
    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Unit>().HasOne(a => a.ItemInfo).WithOne(a => a.Unit).HasForeignKey<ItemInfo>(x => x.Id);
        }
    }
}
