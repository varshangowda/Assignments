using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorypattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the shape :");
            string shapeType = Console.ReadLine();

            Ishape sh = shapefactory.createshape(shapeType);


            if (sh != null)
            {
                Console.WriteLine(" area : {0}", sh.area());
                Console.WriteLine(" perimeter : {0}", sh.perimeter());

            }
            else
            {
                Console.WriteLine("invalid shape");
            }
            Console.Read();
        }
    }
}