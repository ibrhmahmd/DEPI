using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Ibrahimahmed.Entity
{
    public class Supplier : BaseEntity<long>
    {

        [Key]
        public Guid SupplierID { get; set; } = Guid.NewGuid();
        [MaxLength(50)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();

        //public void Configure(EntityTypeBuilder<Supplier> entityTypeBuilder)
        //{
        //    entityTypeBuilder.HasKey(c => c.ID);
        //}
    }
}
