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
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });



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
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 2,
                    CategoryID = 3,
                    Title = "Polyurethan Clogs - Pu03",
                    Descripton = "Some description 2",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 3,
                    CategoryID = 1,
                    Title = "Spring Clogs - F200",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 4,
                    CategoryID = 1,
                    Title = "Spring Clogs - F202",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 5,
                    CategoryID = 3,
                    Title = "Polyurethan Clogs - Pu200",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 6,
                    CategoryID = 2,
                    Title = "Memory Clogs - A01",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    ID = 7,
                    CategoryID = 2,
                    Title = "Memory Clogs - A01",
                    Descripton = "Some description",
                    ImageLink = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                }

            );

            modelBuilder.Entity<Edition>().HasData(
                new Edition { ID = 1, Name = "Default"},
                new Edition { ID = 2, Name = "White"},
                new Edition { ID = 3, Name = "Black"},
                new Edition { ID = 4, Name = "Red"},
                new Edition { ID = 5, Name = "Green"},
                new Edition { ID = 6, Name = "Pink"},
                new Edition { ID = 7, Name = "Dark Blue"},
                new Edition { ID = 8, Name = "Gold"}
            );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant { ProductId = 1, EditionId = 2, Price = 24.55m, OriginalPrice = 30.00m},
                new ProductVariant { ProductId = 1, EditionId = 3, Price = 27.55m, OriginalPrice = 31.50m},
                new ProductVariant { ProductId = 1, EditionId = 6, Price = 21.55m, OriginalPrice = 32.00m},

                new ProductVariant { ProductId = 2, EditionId = 2, Price = 20.55m, OriginalPrice = 30.00m},
                new ProductVariant { ProductId = 2, EditionId = 4, Price = 21.55m, OriginalPrice = 31.00m},
                new ProductVariant { ProductId = 2, EditionId = 5, Price = 22.55m, OriginalPrice = 32.06m},
                new ProductVariant { ProductId = 2, EditionId = 8, Price = 23.55m, OriginalPrice = 33.00m},

                new ProductVariant { ProductId = 3, EditionId = 2, Price = 29.55m, OriginalPrice = 30.00m},
                new ProductVariant { ProductId = 3, EditionId = 3, Price = 12.55m, OriginalPrice = 30.00m},

                new ProductVariant { ProductId = 4, EditionId = 2, Price = 19.55m, OriginalPrice = 33.00m},
                new ProductVariant { ProductId = 4, EditionId = 7, Price = 27.55m, OriginalPrice = 30.30m},

                new ProductVariant { ProductId = 5, EditionId = 2, Price = 21.55m, OriginalPrice = 30.00m},
                new ProductVariant { ProductId = 5, EditionId = 7, Price = 22.55m, OriginalPrice = 39.00m},
                new ProductVariant { ProductId = 5, EditionId = 3, Price = 23.55m, OriginalPrice = 38.00m},
                new ProductVariant { ProductId = 5, EditionId = 6, Price = 24.55m, OriginalPrice = 37.00m},
                new ProductVariant { ProductId = 5, EditionId = 8, Price = 25.55m, OriginalPrice = 34.00m},

                new ProductVariant { ProductId = 6, EditionId = 2, Price = 35.55m, OriginalPrice = 40.00m},
                new ProductVariant { ProductId = 6, EditionId = 6, Price = 34.55m, OriginalPrice = 41.00m},
                new ProductVariant { ProductId = 6, EditionId = 7, Price = 31.55m, OriginalPrice = 49.00m},

                new ProductVariant { ProductId = 7, EditionId = 2, Price = 19.55m, OriginalPrice = 50.00m},
                new ProductVariant { ProductId = 7, EditionId = 7, Price = 29.55m, OriginalPrice = 60.00m},
                new ProductVariant { ProductId = 7, EditionId = 8, Price = 39.55m, OriginalPrice = 70.00m}
            );
        }
    }
}
