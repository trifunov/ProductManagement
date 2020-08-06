using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductManagement.Data.Models
{
    public class ProductManagementContext : IdentityDbContext<ApplicationUser>
    {
        public ProductManagementContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductImage>().HasKey(pi => new { pi.ProductId, pi.ImageId });
            modelBuilder.Entity<ProductImage>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductImages)
                .HasForeignKey(pi => pi.ProductId);
            modelBuilder.Entity<ProductImage>()
                .HasOne(pi => pi.Image)
                .WithMany(p => p.ProductImages)
                .HasForeignKey(pi => pi.ImageId);
        }
    }
}
