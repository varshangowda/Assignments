using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3.b
{
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A WORD");
            string str = Console.ReadLine();
            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            Console.WriteLine($"Actual string {str}\n");
            Console.WriteLine($"Reversed string {reversedStr} ");
            Console.ReadLine();
        }
    }
}
