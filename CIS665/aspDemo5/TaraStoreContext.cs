﻿//Demo 5 - CRUD Basics; LV
// This and the classes - Product.cs, SubCategory.cs, Category.cs - were auto-generated by running the following command at the Package Manager Console prompt.
// Scaffold-Dbcontext "Server=buscissql1601\cisweb;Database=TaraStore;User ID=csu;Password=rams;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Tables Product,SubCategory,Category

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Demo5.Models
{
    public partial class TaraStoreContext : DbContext
    {
        public TaraStoreContext()
        {
        }

        public TaraStoreContext(DbContextOptions<TaraStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.

            // this connnection string information has been moved

            // check appsettings.json and Startup.cs    
            //                optionsBuilder.UseSqlServer("Server=buscissql1601\\cisweb;Database=TaraStore;User ID=csu;Password=rams;");
            //            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryPk)
                    .HasName("PK_Categories");

                entity.Property(e => e.CategoryPk).HasColumnName("CategoryPK");

                entity.Property(e => e.CategoryImage)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Thumbnail).HasMaxLength(50);

                entity.Property(e => e.TinyThumb).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductPk)
                    .HasName("PK_Products");

                entity.Property(e => e.ProductPk).HasColumnName("ProductPK");

                entity.Property(e => e.Availability).HasMaxLength(50);

                entity.Property(e => e.CategoryFk).HasColumnName("CategoryFK");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductImage).HasMaxLength(50);

                entity.Property(e => e.SubCategoryFk).HasColumnName("SubCategoryFK");

                entity.Property(e => e.Thumbnail).HasMaxLength(50);

                entity.Property(e => e.UnitCost).HasColumnType("money");

                entity.HasOne(d => d.CategoryFkNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Category");

                entity.HasOne(d => d.SubCategoryFkNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.SubCategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_SubCategory");
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasKey(e => e.SubCategoryPk)
                    .HasName("PK_SubCategories");

                entity.Property(e => e.SubCategoryPk).HasColumnName("SubCategoryPK");

                entity.Property(e => e.CategoryFk).HasColumnName("CategoryFK");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.SubCategoryImage).HasMaxLength(50);

                entity.Property(e => e.SubCategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Thumbnail).HasMaxLength(50);

                entity.HasOne(d => d.CategoryFkNavigation)
                    .WithMany(p => p.SubCategory)
                    .HasForeignKey(d => d.CategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategory_Category");
            });
        }
    }
}
