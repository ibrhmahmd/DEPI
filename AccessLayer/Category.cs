using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Ibrahimahmed.Entity
{
    public class Category : BaseEntity<long>
    {
        [Key]
        public Guid CategoryID { get; set; } = Guid.NewGuid();

        [MaxLength(200)]
        public string? Discription { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        //public void Configure(EntityTypeBuilder<Category> entityTypeBuilder)
        //{
        //    entityTypeBuilder.HasKey(c => c.ID);
        //}
    }
}
