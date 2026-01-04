using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class ShopProjetContext : DbContext
{
    public ShopProjetContext()
    {
    }

    public ShopProjetContext(DbContextOptions<ShopProjetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsInSale> ProductsInSales { get; set; }

    public virtual DbSet<Salse> Salses { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=shop_projet;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("customers");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(9)
                .IsFixedLength();
            entity.Property(e => e.Address).HasMaxLength(25);
            entity.Property(e => e.CustomerFirstName)
                .HasMaxLength(25)
                .HasColumnName("customerFirstName");
            entity.Property(e => e.CustomerLastName)
                .HasMaxLength(25)
                .HasColumnName("customerLastName");
            entity.Property(e => e.Email).HasMaxLength(25);
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("products");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductName).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductsInSale>(entity =>
        {
            entity.HasKey(e => e.ProductInSaleId);

            entity.ToTable("ProductsInSale");

            entity.Property(e => e.ProductInSaleId).ValueGeneratedNever();
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.SumPriceThisProductInSale).HasColumnName("sumPriceThisProductInSale");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductsInSales)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductsInSale_products");

            entity.HasOne(d => d.ProductInSale).WithOne(p => p.ProductsInSale)
                .HasForeignKey<ProductsInSale>(d => d.ProductInSaleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductsInSale_salse");
        });

        modelBuilder.Entity<Salse>(entity =>
        {
            entity.HasKey(e => e.SaleId);

            entity.ToTable("salse");

            entity.Property(e => e.SaleId).ValueGeneratedNever();
            entity.Property(e => e.CustomerId)
                .HasMaxLength(9)
                .IsFixedLength();
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(9)
                .IsFixedLength();

            entity.HasOne(d => d.Customer).WithMany(p => p.Salses)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_salse_customers");

            entity.HasOne(d => d.Worker).WithMany(p => p.Salses)
                .HasForeignKey(d => d.WorkerId)
                .HasConstraintName("FK_salse_salse");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.Tz);

            entity.ToTable("workers");

            entity.Property(e => e.Tz)
                .HasMaxLength(9)
                .IsFixedLength();
            entity.Property(e => e.Address)
                .HasMaxLength(25)
                .HasColumnName("address");
            entity.Property(e => e.DateBeginWork)
                .HasMaxLength(25)
                .HasColumnName("dateBeginWork");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .HasColumnName("email");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.FirstName)
                .HasMaxLength(25)
                .HasColumnName("firstName");
            entity.Property(e => e.IsManager).HasColumnName("isManager");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .HasColumnName("lastName");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("phoneNumber");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
