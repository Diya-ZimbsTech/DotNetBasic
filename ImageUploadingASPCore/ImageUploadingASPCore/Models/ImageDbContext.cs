using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ImageUploadingASPCore.Models;

public partial class ImageDbContext : DbContext
{
    public ImageDbContext()
    {
    }

    public ImageDbContext(DbContextOptions<ImageDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {
        if (!optionsBuilder.IsConfigured)
        {
           
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC076B7BD883");

            entity.ToTable("Product");

            entity.Property(e => e.ImagePath)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Image_path");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
