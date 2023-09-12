using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4b
{

    class student
    {
        public string Rollno;
        public string Name;
        public string Class;
        public int Semester;
        public string Branch;
        public int[] marks = new int[5];

        public student(string rollno, string name, string Class, int sem, string branch)
        {
            this.Rollno = rollno;
            this.Name = name;
            this.Class = Class;
            this.Semester = sem;
            this.Branch = branch;

        }
        public void displayinfo()
        {
            Console.WriteLine($"Rollno : {Rollno}, Name :{Name}, Class : {Class}, sem : {Semester}, Branch : {Branch}");

        }

        public void GetMarks()
        {
            Console.WriteLine("Enter  marks of 5 subjects");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

        }
        public void DisplayResult()
        {

            double totalMarks = 0;
            foreach (int mark in marks)
            {
                totalMarks += mark;
            }
            double averageMarks = totalMarks / marks.Length;


            if (marks.Any(mark => mark < 35))
            {
                Console.WriteLine("Result: Failed ");
            }
            else if (averageMarks < 50)
            {
                Console.WriteLine("Result: Failed )");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        public static void Main()
        {

            student info = new student("21", "VARSHA", "BE", 2, "CSE");

            info.displayinfo();
            info.GetMarks();
            info.DisplayResult();
            Console.ReadLine();


        }

    }
}



