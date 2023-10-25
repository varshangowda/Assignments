
using System;
using System.Data;
using System.Data.SqlClient;
using casestudy1;

namespace caseStudy2
{
    public class AppEngine
    {
        private string connectionString = "<your_connection_string>";

        public void IntroduceCourse(Course course)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Course (CourseId, CourseName) VALUES (@CourseId, @CourseName)", con))
                {
                    cmd.Parameters.AddWithValue("@CourseId", course.CourseId);
                    cmd.Parameters.AddWithValue("@CourseName", course.CourseName);

                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine($"Course '{course.CourseName}' (ID: {course.CourseId}) introduced successfully.");
        }

        public void RegisterStudent(Student student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Student (Id, Name, DateOfBirth) VALUES (@Id, @Name, @DateOfBirth)", con))
                {
                    cmd.Parameters.AddWithValue("@Id", student.Id);
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);

                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine($"Student '{student.Name}' (ID: {student.Id}) registered successfully.");
        }

        // Other methods remain the same

        // Note: Be sure to replace "<your_connection_string>" with your actual database connection string.
    }
}
