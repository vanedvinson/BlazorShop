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
        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "Spring", URL = "spring", Icon = "book" },
                new Category { ID = 2, Name = "Memory Cushion", URL = "memory", Icon = "fire" },
                new Category { ID = 3, Name = "Polyurethan", URL = "poly", Icon = "check" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    CategoryID = 1,
                    Title = "Spring Clogs - F01",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 2,
                    CategoryID = 3,
                    Title = "Polyurethan Clogs - Pu03",
                    Descripton = "Some description 2",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 19.99m,
                    OriginalPrice = 29.99m,
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 3,
                    CategoryID = 1,
                    Title = "Spring Clogs - F200",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 4,
                    CategoryID = 1,
                    Title = "Spring Clogs - F202",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 5,
                    CategoryID = 3,
                    Title = "Polyurethan Clogs - Pu200",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 6,
                    CategoryID = 2,
                    Title = "Memory Clogs - A01",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 7,
                    CategoryID = 2,
                    Title = "Memory Clogs - A01",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                    DateCreated = new DateTime(2021, 1, 1)
                }

            );
            modelBuilder.Entity<Edition>().HasData(
                new Edition { ID = 1, Name = "Blue" },
                new Edition { ID = 2, Name = "Green" },
                new Edition { ID = 3, Name = "Red" },
                new Edition { ID = 4, Name = "Yellow" },
                new Edition { ID = 5, Name = "Pink" },
                new Edition { ID = 6, Name = "White" },
                new Edition { ID = 7, Name = "Black" }
            );

            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct")
                .HasData(
                    new { EditionsID = 1, ProductsID = 1 },
                    new { EditionsID = 1, ProductsID = 2 },
                    new { EditionsID = 1, ProductsID = 5 },
                    new { EditionsID = 2, ProductsID = 3 },
                    new { EditionsID = 2, ProductsID = 2 },
                    new { EditionsID = 2, ProductsID = 5 },
                    new { EditionsID = 3, ProductsID = 5 },
                    new { EditionsID = 3, ProductsID = 4 },
                    new { EditionsID = 4, ProductsID = 4 },
                    new { EditionsID = 4, ProductsID = 1 },
                    new { EditionsID = 5, ProductsID = 2 },
                    new { EditionsID = 5, ProductsID = 4 },
                    new { EditionsID = 5, ProductsID = 5 },
                    new { EditionsID = 6, ProductsID = 6 },
                    new { EditionsID = 6, ProductsID = 2 },
                    new { EditionsID = 6, ProductsID = 1 },
                    new { EditionsID = 6, ProductsID = 3 },
                    new { EditionsID = 6, ProductsID = 4 }
                );


        }
    }
}
