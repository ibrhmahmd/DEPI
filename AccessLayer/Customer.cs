using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Ibrahimahmed.Entity
{
    public class Customer : BaseEntity<long>
    {
        [Key]
        public Guid CustomerID { get; set; } = Guid.NewGuid();
        [MaxLength(50)]
        public string? Address { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();

        //public void Configure(EntityTypeBuilder<Customer> entityTypeBuilder)
        //{
        //    entityTypeBuilder.HasKey(c => c.ID);
        //}
    }
}
   