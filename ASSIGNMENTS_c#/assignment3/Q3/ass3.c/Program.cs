using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3.c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first word ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter a second word ");
            string name2 = Console.ReadLine();

            if(name1==name2)
            {
                Console.WriteLine("both words are same");
            }
            else
            {
                Console.WriteLine("both words are different");
            }
            Console.ReadLine();
        }
    }
}
