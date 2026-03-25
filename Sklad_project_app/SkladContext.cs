using Microsoft.EntityFrameworkCore;
using Sklad_project_2.Models;
using System.Reflection.Emit;

namespace Sklad_project_2
{
    public class SkladContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShipmentItem> ShipmentItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(DbConfig.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //roles
            modelBuilder.Entity<Role>().ToTable("roles");
            modelBuilder.Entity<Role>().HasKey(r => r.Id);
            modelBuilder.Entity<Role>().Property(r => r.Id).HasColumnName("id");
            modelBuilder.Entity<Role>().Property(r => r.RoleName).HasColumnName("role");

            //users
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Id).HasColumnName("id");
            modelBuilder.Entity<User>().Property(u => u.Name).HasColumnName("name");
            modelBuilder.Entity<User>().Property(u => u.Surname).HasColumnName("surname");
            modelBuilder.Entity<User>().Property(u => u.Patronymic).HasColumnName("patronymic");
            modelBuilder.Entity<User>().Property(u => u.Role_id).HasColumnName("role_id");
            modelBuilder.Entity<User>().Property(u => u.Login).HasColumnName("login");
            modelBuilder.Entity<User>().Property(u => u.Password).HasColumnName("password");
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.Role_id);

            //categories
            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Category>().HasKey(c => c.Id);
            modelBuilder.Entity<Category>().Property(c => c.Id).HasColumnName("id");
            modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("name");

            //units
            modelBuilder.Entity<Unit>().ToTable("units");
            modelBuilder.Entity<Unit>().HasKey(u => u.Id);
            modelBuilder.Entity<Unit>().Property(u => u.Id).HasColumnName("id");
            modelBuilder.Entity<Unit>().Property(u => u.Name).HasColumnName("name");

            //products
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Product>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<Product>().Property(p => p.Article).HasColumnName("article");
            modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnName("name");
            modelBuilder.Entity<Product>().Property(p => p.CategoryId).HasColumnName("category_id");
            modelBuilder.Entity<Product>().Property(p => p.UnitId).HasColumnName("unit_id");
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Unit)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UnitId);

            //stock
            modelBuilder.Entity<Stock>().ToTable("stock");
            modelBuilder.Entity<Stock>().HasKey(s => s.Id);
            modelBuilder.Entity<Stock>().Property(s => s.Id).HasColumnName("id");
            modelBuilder.Entity<Stock>().Property(s => s.ProductId).HasColumnName("product_id");
            modelBuilder.Entity<Stock>().Property(s => s.PurchasePrice).HasColumnName("purchase_price");
            modelBuilder.Entity<Stock>().Property(s => s.Rest).HasColumnName("rest");
            modelBuilder.Entity<Stock>()
                .HasOne(s => s.Product)
                .WithOne(p => p.Stock)
                .HasForeignKey<Stock>(s => s.ProductId);

            //clients
            modelBuilder.Entity<Client>().ToTable("clients");
            modelBuilder.Entity<Client>().HasKey(c => c.Id);
            modelBuilder.Entity<Client>().Property(c => c.Id).HasColumnName("id");
            modelBuilder.Entity<Client>().Property(c => c.Name).HasColumnName("name");

            //shipments
            modelBuilder.Entity<Shipment>().ToTable("shipments");
            modelBuilder.Entity<Shipment>().HasKey(s => s.Id);
            modelBuilder.Entity<Shipment>().Property(s => s.Id).HasColumnName("id");
            modelBuilder.Entity<Shipment>().Property(s => s.ClientId).HasColumnName("client_id");
            modelBuilder.Entity<Shipment>().Property(s => s.UserId).HasColumnName("user_id");
            modelBuilder.Entity<Shipment>().Property(s => s.ShipmentDate).HasColumnName("shipment_date");
            modelBuilder.Entity<Shipment>()
                .HasOne(s => s.Client)
                .WithMany(c => c.Shipments)
                .HasForeignKey(s => s.ClientId);

            //shipment_items
            modelBuilder.Entity<ShipmentItem>().ToTable("shipment_items");
            modelBuilder.Entity<ShipmentItem>().HasKey(si => si.Id);
            modelBuilder.Entity<ShipmentItem>().Property(si => si.Id).HasColumnName("id");
            modelBuilder.Entity<ShipmentItem>().Property(si => si.ShipmentId).HasColumnName("shipment_id");
            modelBuilder.Entity<ShipmentItem>().Property(si => si.ProductId).HasColumnName("product_id");
            modelBuilder.Entity<ShipmentItem>().Property(si => si.Quantity).HasColumnName("quantity");
            modelBuilder.Entity<ShipmentItem>()
                .HasOne(si => si.Shipment)
                .WithMany(s => s.ShipmentItems)
                .HasForeignKey(si => si.ShipmentId);
            modelBuilder.Entity<ShipmentItem>()
                .HasOne(si => si.Product)
                .WithMany()
                .HasForeignKey(si => si.ProductId);

            base.OnModelCreating(modelBuilder);
        }
    }
}