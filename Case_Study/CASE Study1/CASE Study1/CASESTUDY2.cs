using System;
using System.Collections.Generic;
using System.Linq;
using CASEStudy1;
using System.Text;
using System.Threading.Tasks;

namespace CASE_Study1
{
    class CASESTUDY2
    {
        public class Course
        {
            public int CId { get; set; }
            public string CName { get; set; }
            public Course(int cId, string cName)
            {
                CId = cId;
                CName = cName;
            }
        }
        public class Enroll
        {
            public Student Student { get; set; }
            public Course Course { get; set; }
            public DateTime EnrollDate { get; set; }
            public Enroll(Student student, Course course, DateTime enrollDate)
            {
                Student = student;
                Course = course;
                EnrollDate = enrollDate;
            }
        }
        public class AppEngine
        {
            private List<Student> students = new List<Student>();
            private List<Course> courses = new List<Course>();
            private List<Enroll> enrollments = new List<Enroll>();
            public void Introduce(Course course)
            {
                courses.Add(course);
                Console.WriteLine($"Course '{course.CName}' with ID {course.CId} introduced.");
            }
            public void Register(Student student)
            {
                students.Add(student);
                Console.WriteLine($"Student '{student.Name}' with ID {student.Id} registered.");
            }
            public Student[] ListOfStudents()
            {
                return students.ToArray();
            }
            public Course[] ListOfCourses()
            {
                return courses.ToArray();
            }
            public void Enroll(int studId, int coId)
            {
                Student sToEnroll = students.FirstOrDefault(s => s.Id == studId);
                Course courseToEnroll = courses.FirstOrDefault(c => c.CId == coId);
                if (sToEnroll != null && courseToEnroll != null)
                {
                    enrollments.Add(new Enroll(sToEnroll, courseToEnroll, DateTime.Now));
                    Console.WriteLine($"Enrollment of '{sToEnroll.Name}' in '{courseToEnroll.CName}'  is successful!");
                }
                else
                {
                    Console.WriteLine("Students or course not found.");
                }
            }
            public Enroll[] ListOfEnrollments()
            {
                return enrollments.ToArray();
            }
        }
        public class Info
        {
            public void DisplayEnrollments(Enroll[] enrollments)
            {
                Console.WriteLine("\nEnrollment Details:");
                Console.WriteLine("-----------");
                foreach (Enroll enrollment in enrollments)
                {
                    Console.WriteLine($"Student ID: {enrollment.Student.Id}");
                    Console.WriteLine($"Student Name: {enrollment.Student.Name}");
                    Console.WriteLine($"Course ID: {enrollment.Course.CId}");
                    Console.WriteLine($"Course Name: {enrollment.Course.CName}");
                    Console.WriteLine($"Enrollment Date: {enrollment.EnrollDate.ToShortDateString()}");
                    Console.WriteLine("---------------");
                }
            }
        }
        public class App
        {
            public static void Main(string[] args)
            {
                AppEngine engine = new AppEngine();
                Info info = new Info();
                while (true)
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Introduce Course");
                    Console.WriteLine("2. Register Student");
                    Console.WriteLine("3. Enroll Student in Course");
                    Console.WriteLine("4. Display Enrollments");
                    Console.WriteLine("5. Exit");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Course ID: ");
                            int courseId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Course Name: ");
                            string courseName = Console.ReadLine();
                            engine.Introduce(new Course(courseId, courseName));
                            break;
                        case 2:
                            Console.Write("Enter Student ID: ");
                            int studentId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Student Name: ");
                            string studentName = Console.ReadLine();
                            engine.Register(new Student(studentId, studentName, DateTime.Now));
                            break;
                        case 3:
                            Console.Write("Enter Student ID to enroll: ");
                            int enrollStudentId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Course ID to enroll in: ");
                            int enrollCourseId = int.Parse(Console.ReadLine());
                            engine.Enroll(enrollStudentId, enrollCourseId);
                            break;
                        case 4:
                            Enroll[] enrollments = engine.ListOfEnrollments();
                            info.DisplayEnrollments(enrollments);
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }
    }
}
