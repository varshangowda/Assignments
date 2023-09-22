using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_6
{
    namespace ConcessionApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your age:");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    var calculator = new Concession.ConcessionCalculator
                    {
                        Name = name,
                        Age = age
                    };

                    calculator.CalculateConcession();
                }
                else
                {
                    Console.WriteLine("Invalid age input. Please enter a valid age.");
                }

                Console.ReadLine();
            }
        }
    }
}