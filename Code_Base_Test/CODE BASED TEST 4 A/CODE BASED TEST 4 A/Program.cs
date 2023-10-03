using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CODE 
{
    class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\varshan\Desktop\Assignments\Code_Base_Test\CODE BASED TEST 4 A\sample test.txt";



            string textToAppend = "Hello World! Welcome to my text file :-)";



            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(textToAppend);
            }
            Console.WriteLine("Hey File Successfully Appended!");
            Console.ReadLine();
        }
    }
}