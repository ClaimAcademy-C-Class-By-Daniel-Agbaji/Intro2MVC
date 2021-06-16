using System;
using AppConsole.Entities;

namespace AppConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CustomerDbContext())
            {
               
                db.Customers.AddRange(
                    new Customer
                    {
                        id = 244,
                        CustomerName = "Daniel Way",
                        DidCustomerOrdered = false,
                        CustomerOrderNumber = 2323
                    }/*,
                    new Customer
                    {
                        iD = 244,
                        CustomerName = "Daniel Way",
                        DidCustomerOrdered = false,
                        CustomerOrderNumber = 2323
                    }*/);
                var count = db.SaveChanges();

                
                Console.WriteLine($"{count} records added");

                foreach (var customer in db.Customers)
                {
                    Console.WriteLine($"ID - {customer.id},\t\t" +
                                      $"Name: {customer.CustomerName},\t\t" +
                                      $"OrderNumber: {customer.CustomerOrderNumber}" +
                                      $"OrderExist: {customer.DidCustomerOrdered}");
                }
                Console.ReadLine();
            }
        }
    }
}
