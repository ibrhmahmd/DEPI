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
        
    }

    // TPH 
    // Table per hierarchy 

    public class PermenantEmployee : Employee
    {
        public int AnnualSalary { get; set; }
    }

    public class ContractEmployee : Employee
    {
        public int  HourseWorked{ get; set; }
        public int  HourlyPay{ get; set; }
    }
}