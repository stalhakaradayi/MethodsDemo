using System;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Şükrü Talha";
            customer1.CustomerSurname = "Karadayı";
            customer1.IdentityNo = 123458910;
            customer1.PhoneNo = 053011111;

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Mahmut";
            customer2.CustomerSurname = "Karadayı";
            customer2.IdentityNo = 123456910;
            customer2.PhoneNo = 053011111;

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Gülistan";
            customer3.CustomerSurname = "Karadayı";
            customer3.IdentityNo = 123458910;
            customer3.PhoneNo = 053011111;

            Customer customer4 = new Customer();
            customer4.CustomerId = 4;
            customer4.CustomerName = "Tuğçe";
            customer4.CustomerSurname = "Karadayı";
            customer4.IdentityNo = 123456910;
            customer4.PhoneNo = 053011111;

            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4};
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerId+" "+customer.CustomerName+" "+customer.CustomerSurname+"\n"+customer.IdentityNo+"\n"+customer.PhoneNo);
                Console.WriteLine("---------------");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer1);
            customerManager.List(customer1);

            Console.ReadLine();

        }
    }
}
