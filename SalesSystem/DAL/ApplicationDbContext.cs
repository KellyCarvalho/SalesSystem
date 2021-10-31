using Microsoft.EntityFrameworkCore;
using SalesSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.DAL
{
    public class ApplicationDbContext : DbContext
    {
     

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<ProductsSales> ProductsSales { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductsSales>()
                .HasKey(x => new { x.SaleId, x.ProductId });

            modelBuilder.Entity<ProductsSales>()
                .HasOne(x => x.Product)
                .WithMany(y=>y.Sales)
                .HasForeignKey(x=>x.SaleId);
        }



    }
}
