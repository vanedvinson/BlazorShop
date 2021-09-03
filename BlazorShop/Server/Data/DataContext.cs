using BlazorShop.Shared.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "Category 1", URL = "category1", Icon = "book" },
                new Category { ID = 2, Name = "Category 2", URL = "category2", Icon = "fire" },
                new Category { ID = 3, Name = "Category 3", URL = "category3", Icon = "check" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    CategoryID = 1,
                    Title = "Proizvod 1 - kat1",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    ID = 2,
                    CategoryID = 3,
                    Title = "Proizvod 2 - kat3",
                    Descripton = "Some description 2",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new Product
                {
                    ID = 3,
                    CategoryID = 1,
                    Title = "Proizvod 3 - kat1",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    ID = 4,
                    CategoryID = 1,
                    Title = "Proizvod 4 - kat1",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    ID = 5,
                    CategoryID = 3,
                    Title = "Proizvod 5 - kat3",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    ID = 6,
                    CategoryID = 2,
                    Title = "Proizvod 6 - kat2",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }
                
            );


        }
    }
}
