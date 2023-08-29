using Microsoft.EntityFrameworkCore;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
        .HasMany(e => e.Tags) // YourEntity has many Tags
        .WithMany()           // Tags have many YourEntities
        .UsingEntity<Dictionary<string, object>>(
            "CategoriesTags",      // Intermediary table name
            j => j
                .HasOne<Tag>()
                .WithMany()
                .HasForeignKey("TagId"),
            j => j
                .HasOne<Categories>()
                .WithMany()
                .HasForeignKey("CategoryId")
        );
        modelBuilder.Entity<Products>()
       .HasMany(e => e.Tags) // YourEntity has many Tags
       .WithMany()           // Tags have many YourEntities
       .UsingEntity<Dictionary<string, object>>(
           "ProductTags",      // Intermediary table name
           j => j
               .HasOne<Tag>()
               .WithMany()
               .HasForeignKey("TagId"),
           j => j
               .HasOne<Products>()
               .WithMany()
               .HasForeignKey("ProductId")
       );
        }
        public virtual DbSet<CartItems> CartItems { get; set; }
        public virtual DbSet<Carts> Carts { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<OrderLines> OrderLines { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<SocialProfiles> SocialProfiles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
