using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace ShoppingListApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//unique key usage
        {

            

            modelBuilder.Entity<Address>()
                .HasOne(a => a.Country)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            

            modelBuilder.Entity<Address>()
                .HasOne(a => a.District)
                .WithMany(d => d.Addresses)
                .HasForeignKey(a => a.DistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<FavoriteItemUser>()
                .HasOne(f => f.User)
                .WithMany(u => u.FavoriteItemUsers)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Order)
                .WithMany(o => o.Invoices)
                .HasForeignKey(i => i.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(id => id.Item)
                .WithMany(i => i.InvoiceDetails)
                .HasForeignKey(id => id.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(id => id.OrderDetail)
                .WithMany(od => od.InvoiceDetails)
                .HasForeignKey(id => id.OrderDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull);



            // Other entity configurations

            base.OnModelCreating(modelBuilder);


        }

        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<ItemCategory> ItemCategories { get; set; }

        public DbSet<FavoriteItemUser> FavoriteItemUsers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<PaymentType> PaymentTypes { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }


    }
}
