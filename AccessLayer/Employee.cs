using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreTask.Ibrahimahmed.Entity;

namespace EFCoreTask.Ibrahimahmed
{
    public class Employee : BaseEntity<long>
    {
        [Key]
        public Guid EmployeeID { get; set; } = Guid.NewGuid();
        [MaxLength(200)]
        public string? bio { get; set; }
        public DateTime joined { get; set; }


        //public override string ToString()
        //{
        //    return $"ID: {ID}, First Name: {Name},  Bio: {bio}, Joined: {joined}";
        //}
    }
}

