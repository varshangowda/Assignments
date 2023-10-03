using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_BASED_TEST_4_C
{
    class Employee
    {
        public int EID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>
          {
              new Employee
            {
                EID = 1001,
                FName = "Malcolm",
                LName = "Daruwalla",
                Title = "Manager",
                DOB = DateTime.Parse("16/11/1984"),
                DOJ = DateTime.Parse("8/6/2011"),
                City = "Mumbai"
            },
             new Employee
            {
                EID = 1002,
                FName = "Asdin",
                LName = "Dhalla",
                Title = "AsstManager",
                DOB = DateTime.Parse("20/08/1984"),
                DOJ = DateTime.Parse("7/7/2012"),
                City = "Mumbai"
            },
            new Employee
            {
                EID = 1003,
                FName = "Madhavi",
                LName = "Oza",
                Title = "Consultant",
                DOB = DateTime.Parse("14/11/1987"),
                DOJ = DateTime.Parse("12/4/2015"),
                City = "Pune"
            },
            new Employee
            {
                EID = 1004,
                FName = "Saba",
                LName = "Shaikh",
                Title = "SE",
                DOB = DateTime.Parse("3/6/1990"),
                DOJ = DateTime.Parse("2/2/2016"),
                City = "Pune"
            },
            new Employee
            {
                EID = 1005,
                FName = "Nazia",
                LName = "Shaikh",
                Title = "SE",
                DOB = DateTime.Parse("8/3/1991"),
                DOJ = DateTime.Parse("2/2/2016"),
                City = "Mumbai"
            },
            new Employee
            {
                EID = 1006,
                FName = "Amit",
                LName = "Pathak",
                Title = "Consultant",
                DOB = DateTime.Parse("7/11/1989"),
                DOJ = DateTime.Parse("8/8/2014"),
                City = "Chennai"
            },
            new Employee
            {
                EID = 1007,
                FName = "Vijay",
                LName = "Natrajan",
                Title = "Consultant",
                DOB = DateTime.Parse("2/12/1989"),
                DOJ = DateTime.Parse("1/6/2015"),
                City = "Mumbai"
            },
            new Employee
            {
                EID = 1008,
                FName = "Rahul",
                LName = "Dubey",
                Title = "Associate",
                DOB = DateTime.Parse("11/11/1993"),
                DOJ = DateTime.Parse("6/11/2014"),
                City = "Chennai"
            },
            new Employee
            {
                EID = 1009,
                FName = "Suresh",
                LName = "Mistry",
                Title = "Associate",
                DOB = DateTime.Parse("12/8/1992"),
                DOJ = DateTime.Parse("3/12/2014"),
                City = "Chennai"
            },
            new Employee
            {
                EID = 1010,
                FName = "Sumit",
                LName = "Shah",
                Title = "Manager",
                DOB = DateTime.Parse("12/4/1991"),
                DOJ = DateTime.Parse("2/1/2016"),
                City = "Pune"
            }

        };

            Console.WriteLine("detail of all the employees:");
            foreach (var employee in empList)
            {
                Console.WriteLine($"Employee ID: {employee.EID}");
                Console.WriteLine($"First Name: {employee.FName}");
                Console.WriteLine($"Last Name: {employee.LName}");
                Console.WriteLine($"Title: {employee.Title}");
                Console.WriteLine($"DOB: {employee.DOB.ToShortDateString()}");
                Console.WriteLine($"DOJ: {employee.DOJ.ToShortDateString()}");
                Console.WriteLine($"City: {employee.City}");
                Console.WriteLine();
            }
            Console.WriteLine("  details of all the employees whose location is not Mumbai:");
            var employeesNotInMumbai = empList.Where(employee => employee.City != "Mumbai");
            foreach (var employee in employeesNotInMumbai)
            {
                Console.WriteLine($"Employee ID: {employee.EID}");
                Console.WriteLine($"First Name: {employee.FName}");
                Console.WriteLine($"Last Name: {employee.LName}");
                Console.WriteLine($"Title: {employee.Title}");
                Console.WriteLine($"DOB: {employee.DOB.ToShortDateString()}");
                Console.WriteLine($"DOJ: {employee.DOJ.ToShortDateString()}");
                Console.WriteLine($"City: {employee.City}");
                Console.WriteLine();
            }
            Console.WriteLine(" all the employees whose title is AsstManager:");
            var asstManagers = empList.Where(employee => employee.Title == "AsstManager");
            foreach (var employee in asstManagers)
            {
                Console.WriteLine($"Employee ID: {employee.EID}");
                Console.WriteLine($"First Name: {employee.FName}");
                Console.WriteLine($"Last Name: {employee.LName}");
                Console.WriteLine($"Title: {employee.Title}");
                Console.WriteLine($"DOB: {employee.DOB.ToShortDateString()}");
                Console.WriteLine($"DOJ: {employee.DOJ.ToShortDateString()}");
                Console.WriteLine($"City: {employee.City}");
                Console.WriteLine();
            }
            Console.WriteLine(" employees details whose Last Name starts with 'S':");
            var employeesWithLastNameStartingWithS = empList.Where(employee => employee.LName.StartsWith("S"));
            foreach (var employee in employeesWithLastNameStartingWithS)
            {
                Console.WriteLine($"Employee ID: {employee.EID}");
                Console.WriteLine($"First Name: {employee.FName}");
                Console.WriteLine($"Last Name: {employee.LName}");
            }
            Console.ReadLine();
        }
    }
}













