using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Ibrahimahmed.Entity
{
    public abstract class BaseEntity<T>
    {
        //public T ID { get; set; } 
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        [MaxLength(50)]
        public string? CreatedBy { get; set; }
        [MaxLength(50)]
        public string? UpdatedBy { get; set; }
    }
}


////transaction demo 
//using (MyDbContext ContextDemo = new MyDbContext())
//{
//    using (var transaction = ContextDemo.Database.BeginTransaction())
//    {
//        var emp1 = ContextDemo.Employees.Single(x=>x.bio== "test");
//        var emp2 = ContextDemo.Employees.Single(x=>x.bio== "test2");

//        emp1.bio = "test bio 0";
//        emp2.bio = "test bio 1";

//        ContextDemo.SaveChanges();
//        transaction.Commit();
//    }   
//}