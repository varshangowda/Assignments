using System;
using System.Collections.Generic;
using System.Linq;
using casestudy1;

namespace caseStudy2
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public Course(int cId, string cName)
        {
            CourseId = cId;
            CourseName = cName;
        }
    }
    public class Enroll
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Enroll(Student student, Course course, DateTime enrollDate)
        {
            Student = student;
            Course = course;
            EnrollmentDate = enrollDate;
        }
    }

    public class AppEngine
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enroll> enrollments = new List<Enroll>();

        public void IntroduceCourse(Course course)
        {
            courses.Add(course);
            Console.WriteLine($"Course '{course.CourseName}' (ID: {course.CourseId}) introduced successfully.");
        }

        public void RegisterStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine($"Student '{student.Name}' (ID: {student.Id}) registered successfully.");
        }

        public Student[] ListStudents()
        {
            return students.ToArray();
        }

        public Course[] ListCourses()
        {
            return courses.ToArray();
        }

        public void EnrollStudent(int studentId, int courseId)
        {
            Student studentToEnroll = students.FirstOrDefault(s => s.Id == studentId);
            Course courseToEnroll = courses.FirstOrDefault(c => c.CourseId == courseId);

            if (studentToEnroll != null && courseToEnroll != null)
            {
                enrollments.Add(new Enroll(studentToEnroll, courseToEnroll, DateTime.Now));
                Console.WriteLine($"Enrollment successful: '{studentToEnroll.Name}' in '{courseToEnroll.CourseName}'");
            }
            else
            {
                Console.WriteLine("Student or course not found.");
            }
        }

        public Enroll[] ListEnrollments()
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
                Console.WriteLine($"Course ID: {enrollment.Course.CourseId}");
                Console.WriteLine($"Course Name: {enrollment.Course.CourseName}");
                Console.WriteLine($"Enrollment Date: {enrollment.EnrollmentDate.ToShortDateString()}");
                Console.WriteLine("------------");
            }
        }
    }
}