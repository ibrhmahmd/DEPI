using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Ibrahimahmed.Entity
{
    public class Order : BaseEntity<long>
    {
        [Key]
        public Guid OrderID { get; set; } = Guid.NewGuid();

        public Guid CustomerID { get; set; }
        public  Customer Customer{ get; set; }

        public Guid ShiperID { get; set; }
        public Shiper Shiper{ get; set; }

        public int ItemCount { get; set; }
        public DateTime OrderDate { get; set; }

        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();

        public void Configure(EntityTypeBuilder<Order> entityTypeBuilder)
        {

            //entityTypeBuilder.HasKey(c => c.ID);

            entityTypeBuilder.HasOne(s => s.Shiper).WithMany(o => o.Orders).HasForeignKey(s => s.ShiperID).OnDelete(DeleteBehavior.SetNull);

            entityTypeBuilder.HasMany(D => D.OrderDetails).WithOne(s => s.Order).HasForeignKey(o => o.OrderID).OnDelete(DeleteBehavior.SetNull);

            entityTypeBuilder.HasOne(C => C.Customer).WithMany(c => c.Orders).HasForeignKey(c => c.CustomerID).OnDelete(DeleteBehavior.SetNull);
        }
    }
}