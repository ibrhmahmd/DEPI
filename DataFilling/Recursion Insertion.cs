using EFCoreTask.Ibrahimahmed.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Ibrahimahmed
{
    public class RecursionInsertion
    {
        public static string InsertIntoCategory(int i)
        {
            if (i <= 0)
            {
                return $"Done For {i} Rows";
            }
            else
            {
                using (MyDbContext ContextDemo = new MyDbContext())
                {
                    var categoryInstance = new Category
                    {
                        CategoryID = Guid.NewGuid(),
                        Name = "Category " + i,
                        Discription = "this is discription for category " + i,
                        CreatedOn = DateTime.Now,
                        CreatedBy = "Initial Insertion "
                    };
                    ContextDemo.Add(categoryInstance);
                    ContextDemo.SaveChanges(); // Save the category to ensure it's inserted
                    Console.WriteLine($"category Row {i} written");
                }
                return InsertIntoCategory(i - 1);
            }
        }

        public static string InsertIntoSuppliers(int i)
        {
 
            if (i <= 0)
            {
                return $"Done For {i} Rows";
            }

            else
            {
                using (MyDbContext ContextDemo = new MyDbContext())
                {
                    var categoryInstance = new Supplier
                    {
                        SupplierID = Guid.NewGuid(),
                        Name = "Suppliers " + i,
                        City = GenerateRandomData.RandomCity(),
                        Address = GenerateRandomData.RandomAddress(),
                        Phone = GenerateRandomData.RandomPhoneNumber(),
                        CreatedOn = DateTime.Now,
                        CreatedBy = "Initial Insertion "
                    };
                    ContextDemo.Add(categoryInstance);
                    ContextDemo.SaveChanges(); // Save the category to ensure it's inserted
                    Console.WriteLine($"Supplier Row {i} written");
                }
                return InsertIntoSuppliers(i - 1);
            }
        }

        public static string InsertIntoShippers(int i)
        {
            if (i <= 0)
            {
                return $"Done For {i} Rows";
            }

            else
            {
                using (MyDbContext ContextDemo = new MyDbContext())
                {
                    var categoryInstance = new Shiper
                    {
                        shiperid = Guid.NewGuid(),
                        Name = "Shiper " + i,
                        Phone = GenerateRandomData.RandomPhoneNumber(),
                        CreatedOn = DateTime.Now,
                        CreatedBy = "Initial Insertion "
                    };
                    ContextDemo.Add(categoryInstance);
                    ContextDemo.SaveChanges(); // Save the category to ensure it's inserted
                    Console.WriteLine($"Shippers Row {i} written");
                }
                return InsertIntoShippers(i - 1);
            }
        }

        public static string InsertIntoSCustomers(int i)
        {
            if (i <= 0)
            {
                return $"Done For {i} Rows";
            }

            else
            {
                using (MyDbContext ContextDemo = new MyDbContext())
                {
                    var categoryInstance = new Customer
                    {
                        CustomerID = Guid.NewGuid(),
                        Name = "Customer " + i,
                        Address = GenerateRandomData.RandomAddress(),
                        Phone = GenerateRandomData.RandomPhoneNumber(),
                        CreatedOn = DateTime.Now,
                        CreatedBy = "Initial Insertion "
                    };
                    ContextDemo.Add(categoryInstance);
                    ContextDemo.SaveChanges(); // Save the category to ensure it's inserted
                    Console.WriteLine($"Customers Row {i} written");
                }
                return InsertIntoSCustomers(i - 1);
            }
        }

        public static string InsertIntoSEmployees(int i)
        {
            if (i <= 0)
            {
                return $"Done For {i} Rows";
            }

            else
            {
                using (MyDbContext ContextDemo = new MyDbContext())
                {
                    var categoryInstance = new Employee
                    {
                        EmployeeID = Guid.NewGuid(),
                        bio = $"This ic bio for Employee {i}",
                        Name = "Employee " + i,
                        //Phone = GenerateRandomPhoneNumber(),
                        joined = DateTime.Now,
                        CreatedOn = DateTime.Now,
                        CreatedBy = "Initial Insertion "
                    };
                    ContextDemo.Add(categoryInstance);
                    ContextDemo.SaveChanges(); // Save the category to ensure it's inserted
                    Console.WriteLine($"Employee Row {i} written");
                }
                return InsertIntoSEmployees(i - 1);
            }
        }

        public static string InsertIntoProduct(int i)
        {
            if (i <= 0)
            {
                return $"Done For {i} Rows";
            }

            else
            {
                using (MyDbContext ContextDemo = new MyDbContext())
                {
                    var supplierIds = ContextDemo.Suppliers.Select(s => s.SupplierID).ToList();
                    var CategoryIds = ContextDemo.Categories.Select(c => c.CategoryID).ToList();

                    if (i >= supplierIds.Count || i >= CategoryIds.Count)
                    {
                        Console.WriteLine(" i out of range");
                    }
                    else
                    {
                        var product = new Product
                        {
                            ProductID = Guid.NewGuid(),
                            SupplierID = supplierIds[i],
                            CategoryID = CategoryIds[i],
                            Name = "Product " + i,
                            Price = GenerateRandomData.RandomFloat(),
                            CreatedOn = DateTime.Now,
                            CreatedBy = "Initial Insertion "
                        };
                        ContextDemo.Add(product);
                        ContextDemo.SaveChanges(); // Save all products in one batch
                        Console.WriteLine($"Product Row {i} written");
                    }
                }
                return InsertIntoProduct(i - 1);
                //foreach (var categoryID in CategoryIds)
                //{
                //    foreach (var supplierid in supplierIds){}
                //}
            }
        }

        public static string InsertIntoOrders(int i)
        {
            if (i <= 0)
            {
                return $"Done For {i} Rows";
            }
            else
            {
                using (MyDbContext ContextDemo = new MyDbContext())
                {
                    var customerids = ContextDemo.Customers.Select(s => s.CustomerID).ToList();
                    var shipperids = ContextDemo.Shipers.Select(c => c.shiperid).ToList();

                    if (i >= shipperids.Count || i >= customerids.Count)
                    {
                        Console.WriteLine(" i out of range");
                    }
                    else
                    {
                        var order = new Order
                        {
                            OrderID = Guid.NewGuid(),
                            CustomerID = customerids[i],
                            ShiperID = shipperids[i],
                            Name = "Order " + i,
                            OrderDate = GenerateRandomData.RandomDateTime(),
                            CreatedOn = DateTime.Now,
                            CreatedBy = "Initial Insertion "
                        };
                        ContextDemo.Add(order);
                        ContextDemo.SaveChanges(); // Save all products in one batch
                        Console.WriteLine($"Order Row {i} written");
                    }
                }
                return InsertIntoOrders(i - 1);
            }
        }

        public static string InsertIntoOrderDetails(int i)
        {
            if (i <= 0)
            {
                return $"Done For {i} Rows";
            }
            else
            {
                using (MyDbContext ContextDemo = new MyDbContext())
                {
                    var orderids = ContextDemo.Orders.Select(s => s.OrderID).ToList();
                    var productids = ContextDemo.Products.Select(c => c.ProductID).ToList();

                    if (i >= orderids.Count || i >= productids.Count)
                    {
                        Console.WriteLine(" i out of range");
                    }
                    else
                    {
                        var orderdetails = new OrderDetails
                        {
                            OrderDetailsID = Guid.NewGuid(),
                            OrderID = orderids[i],
                            ProductID = productids[i],
                            Name = "Order Details " + i,
                            CreatedOn = DateTime.Now,
                            CreatedBy = "Initial Insertion "
                        };
                        ContextDemo.Add(orderdetails);
                        ContextDemo.SaveChanges(); // Save all products in one batch
                        Console.WriteLine($"Order Details Row {i} written");
                    }
                }
                return InsertIntoOrderDetails(i - 1);
            }
        }
    }
}