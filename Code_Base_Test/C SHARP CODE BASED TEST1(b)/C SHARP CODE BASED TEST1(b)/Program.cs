using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CODE_BASED_TEST1_b_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                for (int k = 0; k<= 10; k++)
                {
                    int result = num * k;
                    Console.WriteLine($"{num}*{k}={result}");
                }
            }

            else
            {
                Console.WriteLine("invalid input.please enter a valid number.");

            }
            Console.ReadLine();
        }
    }
}
    
