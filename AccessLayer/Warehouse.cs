using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Ibrahimahmed
{
    public class WareHouse : Country
    {
        [Key]
        public Guid WarehouseID { get; set; }

        [MaxLength(50)]
        public string WareHouseName { get; set; }

        public List<City> Cities { get; set; }




        public void Configure(EntityTypeBuilder<WareHouse> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("WareHouses");
        }
    }
}