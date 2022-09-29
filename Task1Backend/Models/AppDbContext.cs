using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.Models;

namespace Task1.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Customers Table
            modelBuilder.Entity<Customer>().HasData(
                new Customer { 
                    Id = 1, 
                    FirstName = "Aline",
                    LastName = "Abboud",
                    Email ="alineabboud32@gmail.com",
                    PhoneNumber=76456643
                });
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 2,
                    FirstName = "Edwar",
                    LastName = "Abboud",
                    Email = "edwarabboud1@gmail.com",
                    PhoneNumber = 71052321
                });


            // Seed Product Table
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Ring",
                Price = 210
                
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Necklace",
                Price = 320

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "earrings",
                Price = 180

            });

            // Seed Sales Table
            modelBuilder.Entity<Sales>().HasData(new Sales
            {
                Id = 1,
                CustomerId = 1,
                ProductId = 1,
                Date=new DateTime(2022,05,09)

            });
            modelBuilder.Entity<Sales>().HasData(new Sales
            {
                Id = 2,
                CustomerId = 1,
                ProductId = 2,
                Date = new DateTime(2022, 05, 12)

            });
            modelBuilder.Entity<Sales>().HasData(new Sales
            {
                Id = 3,
                CustomerId = 1,
                ProductId = 3,
                Date = new DateTime(2022, 05, 15)

            });
            modelBuilder.Entity<Sales>().HasData(new Sales
            {
                Id = 4,
                CustomerId = 2,
                ProductId = 1,
                Date = new DateTime(2022, 05, 16)

            });
            modelBuilder.Entity<Sales>().HasData(new Sales
            {
                Id = 5,
                CustomerId = 2,
                ProductId = 2,
                Date = new DateTime(2022, 05, 18)

            });
            modelBuilder.Entity<Sales>().HasData(new Sales
            {
                Id = 6,
                CustomerId = 2,
                ProductId = 3,
                Date = new DateTime(2022, 05, 19)

            });

        }
    }


}
