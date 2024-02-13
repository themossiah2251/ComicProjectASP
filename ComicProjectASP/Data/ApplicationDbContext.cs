using ComicProjectASP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ComicProjectASP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Call base method to configure Identity-related model

            modelBuilder.Entity<Products>().HasData(
                new Products { Id = 1, BrandId = 1,BrandName="Marvel", CategoryId = 1, Name = "Storm 002", Price = 10.00, Images = "storm.jpg" },
                new Products { Id = 2, BrandId = 1, BrandName = "Marvel", CategoryId = 1, Name = "Flag Of Our Fathers", Price = 4.00, Images = "capbp.jpg" },
                new Products { Id = 3, BrandId = 1, BrandName = "Marvel", CategoryId = 1, Name = "Black Panter vs Luke Cage", Price = 3.00, Images = "bp.jpg" },
                new Products { Id = 4, BrandId = 2, BrandName = "Dc", CategoryId = 1, Name = "Green Lantern", Price = 1.5, Images = "gl.jpg" },
                new Products { Id = 5, BrandId = 2, BrandName = "Dc", CategoryId = 1, Name = "The Flash", Price = 1.00, Images = "flash.jpg" },
                new Products { Id = 6, BrandId = 2, BrandName = "Dc", CategoryId = 1, Name = "Wonder Woman", Price = 2.00, Images = "ww.jpg" },
                new Products { Id = 7, BrandId = 1, BrandName = "Marvel", CategoryId = 1, Name = "The Uncanny DeadPool", Price = 4.00, Images = "xmen.jpg" },
                new Products { Id = 8, BrandId = 1, BrandName = "Marvel", CategoryId = 1, Name = "Marvel Zomvies: DeadPool", Price = 4.00, Images = "dp.jpg" },
                new Products { Id = 9, BrandId = 2, BrandName = "Dc", CategoryId = 2, Name = "Joker", Price = 20.00, Images = "joker.jpg" },
                new Products { Id = 10, BrandId = 2, BrandName = "Dc", CategoryId = 2, Name = "Joker Boss", Price = 20.00, Images = "joker_boss.jpg" },
                new Products { Id = 11, BrandId = 2, BrandName = "Dc", CategoryId = 2, Name = "Harley Quinn", Price = 20.00, Images = "harley.jpg" },
                new Products {  Id = 12, BrandId = 3, BrandName = "WOTC", CategoryId = 3, Name = "Mind Flayer Deck", Price = 100.00, Images = "dndmtg.jpg" },
                new Products { Id = 13, BrandId = 3, BrandName = "WOTC", CategoryId = 3, Name = "Faceless Menace Deck", Price = 100.00, Images = "faceless_menace.jpg" } 
            );
            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Brand_Name = "Marvel" },
    new Brand { Id = 2, Brand_Name = "DC" },
    new Brand { Id = 3, Brand_Name = "WOTC" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Books" },
    new Category { Id = 2, CategoryName = "Toys" },
    new Category { Id = 3, CategoryName = "Games" });

        }
    }
}