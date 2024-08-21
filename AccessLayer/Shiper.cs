using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Ibrahimahmed.Entity
{
    public class Shiper : BaseEntity<long>
    {

        [Key]
        
        public Guid shiperid { get; set; } = Guid.NewGuid();
        [MaxLength(20)]
        public string Phone { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();

        //public void Configure(EntityTypeBuilder<Shiper> entityTypeBuilder)
        //{
        //    entityTypeBuilder.HasKey(c => c.ID);
        //}
    }
}