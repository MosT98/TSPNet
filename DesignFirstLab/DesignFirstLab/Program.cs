using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignFirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Design First");
            TestOneToMany();

        }

        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                Person person = new Person();
                person.FirstName = "Andrei";
                person.LastName = "Halauca";
                person.MiddleName = "F";
                person.PhoneNumber = "0722222222";
                context.People.Add(person);
                context.SaveChanges();

                var items = context.People;

                foreach (var item in items)
                {
                    Console.WriteLine("{0}-{1} {2}", item.Id, item.FirstName, item.LastName);
                }
            }
        }


        static void TestOneToMany()
        {
            Console.WriteLine("One to Many test");
            using (ModelOneToManyContainer context = new ModelOneToManyContainer())
            {
                Customer customer = new Customer();
                customer.Name = "Customer 1";
                customer.City = "Buzau";

                Order order1 = new Order();
                order1.TotalValue = 200;
                order1.Date = DateTime.Now;
                order1.Customer = customer;

                Order order2 = new Order();
                order2.TotalValue = 400;
                order2.Date = DateTime.Now;
                order2.Customer = customer;

                context.Customers.Add(customer);
                context.Orders.Add(order1);
                context.Orders.Add(order2);
                context.SaveChanges();

                var items = context.Customers;
                foreach (var item in items)
                {
                    Console.WriteLine("Customer: {0}-{1}-{2}", item.CustomerId, item.Name, item.City);
                    foreach (var order in item.Orders)
                    {
                        Console.WriteLine("Orders: {0}-{1}-{2}", order.OrderId, order.Date, order.TotalValue);
                    }
                }
            }
        }
    }
}
