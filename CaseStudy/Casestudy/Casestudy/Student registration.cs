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
         public static void Main(string[] args)
        {
            SelectData();
           Registration();

            SelectData();
            Console.Read();
        }

        static void SelectData()
        {
            //get the connection object
            conn = GetConnection();
            //issue the command
            //  cmd = new SqlCommand("select * from tblemployee", con); or
            cmd = new SqlCommand("select * from Registration");
            cmd.Connection = conn;
            datard = cmd.ExecuteReader();
            while (datard.Read())
            {
                // Console.WriteLine(dr[0] + " "+dr[1] +" "+dr[2]+" "+dr[3]+" "+dr[4]);
                Console.WriteLine("id :" + " " + datard[0]);
                Console.WriteLine("name :" + " " + datard[1]);
                //Console.WriteLine("job :" + " " + datard[2]);
                //Console.WriteLine("salary:" + " " + datard[5]);
                //Console.WriteLine("emploc :" + " " + datard[2]);

                Console.WriteLine("---------------------------");
            }

        }
        static SqlConnection GetConnection()
        {
            //when windows authenticated
            conn = new SqlConnection(@"Data Source=ICS-LT-HVM1DN3\MSSQLSERVER02;Initial Catalog=casestudy;Integrated Security=True");
            conn.Open();
            return conn;
            //when sql authenticated
            // con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;Initial Catalog=InfiniteDB;"+
            //"user id=sa;password=pwd);
        }
        static void Registration()
        {

            conn = GetConnection();



            try
            {
                Console.Write("student registration id: ");
                int id = int.Parse(Console.ReadLine());



                Console.Write("Enter New name: ");
                string name = Console.ReadLine();

                DateTime date_time = DateTime.Now;




                cmd = new SqlCommand("insert into Registration values(@id ,@name,@date_time)",conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date_time", date_time);



                int rowsAffected = cmd.ExecuteNonQuery();



                if (rowsAffected > 0)
                {
                    Console.WriteLine("Registration successful. Rows affected: " + rowsAffected);
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
