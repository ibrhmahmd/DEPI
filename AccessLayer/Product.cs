using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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




        public void Configure(EntityTypeBuilder<Product> entityTypeBuilder)
        {
            //entityTypeBuilder.HasKey(c => c.ID);

            entityTypeBuilder.HasOne(x => x.Category).WithMany(p => p.Products).HasForeignKey(s => s.CategoryID).OnDelete(DeleteBehavior.SetNull);
            entityTypeBuilder.HasMany(x => x.OrderDetails).WithOne(x => x.Product).HasForeignKey(x => x.ProductID).OnDelete(DeleteBehavior.SetNull);
            entityTypeBuilder.HasOne(x => x.Supplier).WithMany(x => x.Products).HasForeignKey(x => x.SupplierID).OnDelete(DeleteBehavior.SetNull);

        }
    }
}
