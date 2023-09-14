using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS5B
{


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string String = Console.ReadLine();

            Console.WriteLine("Enter a letter to count: ");
            char Count = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int count = Occurrences(String, Count);

            Console.WriteLine($"The letter '{Count}' appears {count} times in the string.");
            Console.ReadLine();
        }

        static int Occurrences(string str, char tem)
        {
            int count = 0;

            foreach (char letter in str)
            {
                if (letter == tem)
                {
                    count++;
                }
            }

            return count;
        }
    }

}
    
