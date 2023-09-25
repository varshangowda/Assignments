using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CODE_BASED_TEST_3_B
{
    class Box
    {
        public double length;
        public double breadth;
        public Box(double Length, double Breadth)
        {
            length = Length;
            breadth = Breadth;
        }

        public static Box AddBoxes(Box box1, Box box2)
        {
            double sumLength = box1.length + box2.length;
            double sumbreadth = box1.breadth + box2.breadth;
            return new Box(sumLength, sumbreadth);
        }

        public void displaydetails()
        {
            Console.WriteLine(" BOX OBJECT DETAILS");
            Console.WriteLine("LENGTH IS:" + length);
            Console.WriteLine("BREADTH IS:" + breadth);
        }
    }
        class Test
        { static void Main(string[] args)
            {
            Console.Write("Enter the length of Box1: ");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the breadth of Box1: ");
            double breadth1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of Box2: ");
            double length2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the breadth of Box2: ");
            double breadth2 = Convert.ToDouble(Console.ReadLine());
            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);

            Box box3 = Box.AddBoxes(box1, box2);
            Console.WriteLine("Details of Box1:");
            box1.displaydetails();
            Console.WriteLine("Details of Box2:");
            box2.displaydetails();
            Console.WriteLine("Details of Box 3 (Sum of Box1 and Box2  is New Box ):");
            box3.displaydetails();
            Console.ReadLine();
        }
    }
}   

