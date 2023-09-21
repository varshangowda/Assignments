using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_CODE_BASE_TEST_2
{

    public abstract class Student
    {
        public string name;
        public int StudentId;
        public double Grade;
        public abstract bool IsPassed(double grade);
    }
    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }
    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Undergraduate undergradStudent = new Undergraduate
            {
                name = "VARSHA",
                StudentId = 103,
                Grade = 60.0

            };
            Graduate gradstudent = new Graduate
            {
                name = "KEERTHANA",
                StudentId = 121,
                Grade = 85.5
            };
            Console.WriteLine($"{undergradStudent.name} passed:{undergradStudent.IsPassed(undergradStudent.Grade)}");
            Console.WriteLine($"{gradstudent.name} passed:{gradstudent.IsPassed(gradstudent.Grade)}");
            Console.ReadLine();
        }
    }
}
        