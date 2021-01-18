using System;

namespace ClassMethodsDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yeni Customer nesneleri oluşturulup propertys girilir
            Customer customer1 = new Customer();
            customer1.Name = "David";
            customer1.TcNo = "4003005555";
            customer1.Age = 20;
            customer1.Gender = "Male";
            Customer customer2 = new Customer();
            customer2.Name = "Josie";
            customer2.TcNo = "5006005588";
            customer2.Age = 35;
            customer2.Gender = "Female";
            Customer customer3 = new Customer();
            customer3.Name = "Ivan";
            customer3.TcNo = "7896321555";
            customer3.Age = 41;
            customer3.Gender = "Male";

            //customer lar için bir dizi oluşturdum
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            //CustomerManager nesnesi oluşturuldu
            CustomerManager customerManager = new CustomerManager();

            //Add metotları çağırıldı
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            //Listele metotu çağırıldı
            customerManager.List(customers);

        }
    }
}
