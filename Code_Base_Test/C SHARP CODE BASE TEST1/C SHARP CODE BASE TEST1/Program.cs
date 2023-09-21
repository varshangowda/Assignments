using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CODE_BASE_TEST1
{
    class Program
    {
        static string RemoveCharacterAtPosition(string input, int position)
        {
            if(position<0|| position>=input.Length)
            {
                return input;
            }
            return input.Substring(0, position) + input.Substring(position + 1);
        }
        static void Main(string[] args)
        {
            string input1 = "Coding";
            int position1 = 1;
            string result1 = RemoveCharacterAtPosition(input1, position1);
            Console.WriteLine(result1);
            string input2 = "Program";
            int position2 = 4;
            string result2 = RemoveCharacterAtPosition(input2, position2);
            Console.WriteLine(result2);
            Console.ReadLine();

        }
    }
}
