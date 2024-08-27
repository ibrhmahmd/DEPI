using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EFCoreTask.Ibrahimahmed;
using EFCoreTask.Ibrahimahmed.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


public class City : Country
{

    [Key]
    public Guid CityID { get; set; }

    [MaxLength(50)]
    public string CityName { get; set; }

    [MaxLength(50)]
    public string DeliveryZone { get; set; }

    public float DeliveryCost { get; set; }

    public List<WareHouse> WareHouses { get; set; }


    public void Configure(EntityTypeBuilder<City> entityTypeBuilder)
    {
        entityTypeBuilder.ToTable("Cities");

        entityTypeBuilder.HasMany(c => c.WareHouses)
            .WithMany(w => w.Cities)
            .UsingEntity<Dictionary<string, object>>
            (
                "CityWarehouse", // join table
                j => j.HasOne<WareHouse>().WithMany().HasForeignKey("WarehouseID"),
                j => j.HasOne<City>().WithMany().HasForeignKey("CityID")
            );
    }

}