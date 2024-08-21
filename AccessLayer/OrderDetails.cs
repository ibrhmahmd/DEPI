using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Ibrahimahmed.Entity
{
    public class OrderDetails : BaseEntity<long>
    {

        [Key]
        public Guid OrderDetailsID { get; set; } = Guid.NewGuid();

        public Guid OrderID { get; set; }
        public Order Order { get; set; }

        public Guid ProductID { get; set; }
        public Product Product { get; set; }

        public int? Quantity { get; set; }





        //public void Configure(EntityTypeBuilder<OrderDetails> entityTypeBuilder)
        //{
        //    entityTypeBuilder.HasKey(c => c.ID);
        //}
    }
}
