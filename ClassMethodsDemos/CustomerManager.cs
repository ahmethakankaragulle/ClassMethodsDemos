using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemos
{
    class CustomerManager
    {
        /*Customer ekleme  metodu (simülasyon)*/
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added : " + customer.Name);
        }

        /*Customer silme metodu (simülasyon)*/
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted : " + customer.Name);
        }

        /*Customerları listeleme  metodu*/
        public void List(params Customer[] customers)
        {
            Console.WriteLine("\nCustomers are listed");
            foreach (Customer customer in customers)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Customer name : " + customer.Name);
                Console.WriteLine("Customer age : " + customer.Age);
                Console.WriteLine("Customer gender : " + customer.Gender);
                Console.WriteLine("Customer TcNo : " + customer.TcNo);
            }
        }
    }
}
