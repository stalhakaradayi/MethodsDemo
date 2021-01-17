using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added.");
        }

        public void Delete (Customer customer)
        {
            Console.WriteLine("Customer deleted.");
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Customer listed.");
        }
    }
}
