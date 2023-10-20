using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqassignment1

{
    class Employee
    {
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class program1
    {
        static void Main(string[] args)
        {
            // Create a List<Employee> 
            List<Employee> empList = new List<Employee>
        {
            new Employee { EmpID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 8, 6), City = "Mumbai" },
            new Employee { EmpID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmpID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 12, 4), City = "Pune" },
            new Employee { EmpID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 3, 6), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee { EmpID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 8, 3), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmpID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 7, 11), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmpID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 2, 12), DOJ = new DateTime(2015, 1, 6), City = "Mumbai" },
            new Employee { EmpID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 6, 11), City = "Chennai" },
            new Employee { EmpID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 12, 8), DOJ = new DateTime(2014, 3, 12), City = "Chennai" },
            new Employee { EmpID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 12, 4), DOJ = new DateTime(2016, 2, 1), City = "Pune" }
        };

            //    foreach (var employee in empList)
            //    {
            //        Console.WriteLine($"Employee ID: {employee.EmployeeID}, Name: {employee.FirstName} {employee.LastName}, Title: {employee.Title}, DOB: {employee.DOB.ToShortDateString()}, DOJ: {employee.DOJ.ToShortDateString()}, City: {employee.City}");
            //    }

            //    Console.ReadLine();
            //  }

            //1. Display a list of all the employee who have joined before 1/1/2015
            var emp= empList.Where(employee => employee.DOJ < new DateTime(2015, 1, 1)).ToList();
            Console.WriteLine("1. Employees who joined before 1/1/2015:");
            DisplayEmployees(emp);


            //2. Display a list of all the employee whose date of birth is after 1/1/1990
            var empl = empList.Where(employee => employee.DOB > new DateTime(1990, 1, 1)).ToList();
            Console.WriteLine("2. Employees with DOB after 1/1/1990:");
            DisplayEmployees(empl);

            //  3.Employees "Consultant" or "Associate"
            var conOrAss = empList.Where(employee => employee.Title == "Consultant" || employee.Title == "Associate").ToList();
            Console.WriteLine("3. Employees with designation 'Consultant' or 'Associate':");
            DisplayEmployees(conOrAss);

            // 4. Total number of employees
            Console.WriteLine($"4. Total number of employees: {empList.Count}");

            // 5. Total number of employees in "Chennai"
            var employeesInChennai = empList.Count(employee => employee.City == "Chennai");
            Console.WriteLine($"5. Total number of employees in Chennai: {employeesInChennai}");

            // 6. Highest employee ID
            int highestEmployeeID = empList.Max(employee => employee.EmpID);
            Console.WriteLine($"6. Highest employee ID: {highestEmployeeID}");

            // 7. Employees who joined after 1/1/2015
            var employeesJoinedAfter2015 = empList.Count(employee => employee.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"7. Total number of employees who joined after 1/1/2015: {employeesJoinedAfter2015}");

            // 8. Total number of employees with a designation other than "Associate"
            var employeesNotAssociate = empList.Count(employee => employee.Title != "Associate");
            Console.WriteLine($"8. Total number of employees with a designation other than 'Associate': {employeesNotAssociate}");

            // 9. Total number of employees based on City
            var employeesByCity = empList.GroupBy(employee => employee.City)
                .Select(group => new { City = group.Key, Count = group.Count() });
            Console.WriteLine("9. Total number of employees based on City:");
            foreach (var cityGroup in employeesByCity)
            {
                Console.WriteLine($"{cityGroup.City}: {cityGroup.Count}");
            }

            // 10. Total number of employees based on City and Title
            var employeesByCityAndTitle = empList.GroupBy(employee => new { employee.City, employee.Title })
                .Select(group => new { City = group.Key.City, Title = group.Key.Title, Count = group.Count() });
            Console.WriteLine("10. Total number of employees based on City and Title:");
            foreach (var cityTitleGroup in employeesByCityAndTitle)
            {
                Console.WriteLine($"{cityTitleGroup.City}, {cityTitleGroup.Title}: {cityTitleGroup.Count}");
            }

            // 11. Youngest employee in the list
            var youngestEmployee = empList.OrderBy(employee => employee.DOB).FirstOrDefault();
            Console.WriteLine("11. Youngest employee:");
            DisplayEmployee(youngestEmployee);

            Console.ReadLine();
        }

        // Helper method to display a list of employees
        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                DisplayEmployee(employee);
            }
        }

        // Helper method to display a single employee
        static void DisplayEmployee(Employee employee)
        {
            Console.WriteLine($"Employee ID: {employee.EmpID}, Name: {employee.FirstName} {employee.LastName}, Title: {employee.Title}, DOB: {employee.DOB.ToShortDateString()}, DOJ: {employee.DOJ.ToShortDateString()}, City: {employee.City}");
        }
    }
}

   