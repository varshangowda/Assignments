using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("\n\n");

            Console.WriteLine("check wheather the numbers are equal or not:");
            Console.WriteLine("------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("input the 1st number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the 2nd number:");
            b = Convert.ToInt32(Console.ReadLine());
             if (a == b)
            {
                Console.WriteLine("{0} and {1}the numbers are equal", a, b);
            }
            else
            {
                Console.WriteLine("{0} and {1}the numbers are not equal", a, b);
            }
            Console.Read();
        }
    }
}
