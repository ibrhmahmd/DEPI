using EFCoreTask.Ibrahimahmed.Entity;
using static System.Net.Mime.MediaTypeNames;
using System.Net;

namespace EFCoreTask.Ibrahimahmed
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 1000;
            RecursionInsertion.InsertIntoCategory(i);
            RecursionInsertion.InsertIntoSuppliers(i);
            RecursionInsertion.InsertIntoShippers(i);
            RecursionInsertion.InsertIntoSCustomers(i);
            RecursionInsertion.InsertIntoSEmployees(i);
            RecursionInsertion.InsertIntoProduct(i);
            RecursionInsertion.InsertIntoOrders(i);
            RecursionInsertion.InsertIntoOrderDetails(i);
        }
    }
}