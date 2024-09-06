using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using EFCoreTask.Ibrahimahmed.Entity;

namespace EFCoreTask.Ibrahimahmed
{
    public class GenDataFromBogus
    {
        public void EmployeesGenData()
        {
            //var employeename = new Faker<Employee>()
            //    .RuleFor(x => x.Name, x => x.Name.FullName())
            //    .RuleFor(x=>x.EmployeeID,x=>x.Random.Guid())
            //    .RuleFor(x=>x.joined,x=>x.DateTimeReference)
            //    .RuleFor(x=>x.)
        }





        //public static void GenerateCategories(ICollection<Category> categories, int start, int end, int Createdby = 0)
        //{
        //    if (start >= end)
        //        return;
        //    var categoryFaker = new Faker();
        //    var randomCreatedDate = categoryFaker.Date.Between(new DateTime(2000, 1, 1), DateTime.Today);
        //    var randomUpdatedDate = categoryFaker.Date.Between(randomCreatedDate, randomCreatedDate.AddYears(1));
        //    var category = new Category
        //    {
        //        Name = categoryFaker.Commerce.Categories(1)[0],
        //        CreatedOn = randomCreatedDate,
        //        UpdatedOn = randomUpdatedDate
        //    };
        //    if (Createdby != 0)
        //    {
        //        category.CreatedBy = Random.Shared.Next(0, Createdby);
        //    }
        //    categories.Add(category);
        //    GenerateCategories(categories, start + 1, end);
        //}s
    }
}