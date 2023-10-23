using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedArchitecture_1
{
    class Program
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataReader datard;
        static void Main(string[] args)
        {
            SelectData();
            UpdateData();

            SelectData();
            Console.Read();
        }

        static void SelectData()
        {
            //get the connection object
            conn = GetConnection();
            //issue the command
            //  cmd = new SqlCommand("select * from tblemployee", con); or
            cmd = new SqlCommand("select * from code_employeee");
            cmd.Connection = conn;
            datard = cmd.ExecuteReader();
            while (datard.Read())
            {
                // Console.WriteLine(dr[0] + " "+dr[1] +" "+dr[2]+" "+dr[3]+" "+dr[4]);
                Console.WriteLine("empno :" + " " + datard[0]);
                Console.WriteLine("empame :" + " " + datard[1]);
                Console.WriteLine("empsal :" + " " + datard[3]);
                Console.WriteLine("emptype:" + " " + datard[2]);
                //Console.WriteLine("emploc :" + " " + datard[2]);

                Console.WriteLine("---------------------------");
            }

        }
        static SqlConnection GetConnection()
        {
            //when windows authenticated
            conn = new SqlConnection(@"Data Source=ICS-LT-HVM1DN3\MSSQLSERVER02;Initial Catalog=abc;Integrated Security=True");
            conn.Open();
            return conn;
            //when sql authenticated
            // con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;Initial Catalog=InfiniteDB;"+
            //"user id=sa;password=pwd);
        }
        static void UpdateData()
        {

            conn = GetConnection();



            try
            {
                Console.Write("Enter Employee Number: ");
                int empNo = int.Parse(Console.ReadLine());



                Console.Write("Enter employee salary: ");
                decimal newSalary = decimal.Parse(Console.ReadLine());


                using (SqlCommand cmd = new SqlCommand("InsertEmployee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@empname", "Jane Smith"));
                    cmd.Parameters.Add(new SqlParameter("@empsal", 28000.00));
                    cmd.Parameters.Add(new SqlParameter("@emptype", "F"));

                    cmd.ExecuteNonQuery();
                }



                int rowsAffected = cmd.ExecuteNonQuery();



                if (rowsAffected > 0)
                {
                    Console.WriteLine("Update successful. Rows affected: " + rowsAffected);
                }
                else
                {
                    Console.WriteLine("No records updated.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating data: " + ex.Message);
            }

        }
    }
}