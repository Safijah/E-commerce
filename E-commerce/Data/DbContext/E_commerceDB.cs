using Data.EntityModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace Data.DbContext
{
   public  class E_commerceDB : IdentityDbContext
    {
        public E_commerceDB(DbContextOptions options): base(options)
        {

        }
        public DbSet<Account> Account  { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<BrandCategory> BrandCategory { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Check> Check { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Coupon> Coupon { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<GenderCategory> GenderCategory { get; set; }
        public DbSet<HistoryOfPayments> HistoryOfPayments { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemCostHistory> ItemCostHistory { get; set; }
        public DbSet<ItemSize> ItemSize { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {




            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Check>()
           .HasOne<HistoryOfPayments>(s => s.HistoryOfPayments)
           .WithOne(ad => ad.Check)
           .HasForeignKey<HistoryOfPayments>(ad => ad.CheckID);

            modelBuilder.Entity<Check>()
          .HasOne<ShoppingCart>(s => s.ShoppingCart)
          .WithOne(ad => ad.Check)
          .HasForeignKey<ShoppingCart>(ad => ad.CheckID);





        }

    }
}
