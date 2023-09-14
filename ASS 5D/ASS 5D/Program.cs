using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_5D
{

    class Customer
    {


        public int CustId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }


        public Customer()
        {
            CustId = 0;
            Name = "";
            Age = 0;
            Phone = "";
            City = "";
        }


        public Customer(int custId, string name, int age, string phone, string city)
        {
            CustId = custId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }

        public static void Main(string[] args)
        {
            Console.ReadLine();
        }

        ~Customer()
        {
            Console.WriteLine($"Customer with ID {CustId} is  destroyed.");
        }
    }

}


