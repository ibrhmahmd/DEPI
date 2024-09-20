using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EFCoreTask.Ibrahimahmed.Entity
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=IBRAHIM;Initial Catalog=\"EntityFramwork DB\";Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Shiper> Shipers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        //TPH
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ContractEmployee> ContractEmployees{ get; set; }
        public DbSet<PermenantEmployee> PermenantEmployees { get; set; }
        //TP
        public DbSet<City> Cities { get; set; }
        public DbSet<WareHouse> WareHouses { get; set; }

        // mariam commit 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Employee>().UseTphMappingStrategy();
            
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }








        //public override int SaveChanges()
        //{

        //    var entries = ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

        //    foreach (var entry in entries)
        //    {
        //        if (entry.State == EntityState.Added)
        //        {
        //            entry.Property("CreatedOn").CurrentValue = DateTime.Now;
        //            entry.Property("CreatedBy").CurrentValue = "GUID";         //User GUID here

        //        }

        //        else if (entry.State == EntityState.Modified)
        //        {
        //            entry.Property("UpdatedOn").CurrentValue = DateTime.Now;
        //            entry.Property("UpdatedBy").CurrentValue = "GUID";          //User GUID here

        //        }
        //    }

        //    return base.SaveChanges();
        //}
    }
}