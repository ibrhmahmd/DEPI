using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTask.Ibrahimahmed.Entity
{
    public class Product : BaseEntity<long>
    {
        [Key]
        public Guid ProductID { get; set; } = Guid.NewGuid();

        public Guid? SupplierID { get; set; }
        public Supplier Supplier { get; set; }

        public Guid? CategoryID { get; set; }
        public Category Category { get; set; }

        public double Price { get; set; }

        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }


    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Configure primary key
            builder.HasKey(p => p.ProductID);

            // Configure relationships
            builder.HasOne(p => p.Category)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.CategoryID)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(p => p.OrderDetails)
                   .WithOne(od => od.Product)
                   .HasForeignKey(od => od.ProductID)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(p => p.Supplier)
                   .WithMany(s => s.Products)
                   .HasForeignKey(p => p.SupplierID)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
