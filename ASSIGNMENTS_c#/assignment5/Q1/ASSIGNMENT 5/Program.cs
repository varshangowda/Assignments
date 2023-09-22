

using System;

            using System.Collections.Generic;

            using System.Linq;

            using System.Text;

            using System.Threading.Tasks;




namespace Assignment_5a

    {

        class STRING_OPERATION

        {


            static void Display(string firstname, string lastname)

            {

                Console.WriteLine("YOUR NAME IN UPPER CASE");

                Console.WriteLine($"FIRST NAME : {firstname.ToUpper()}");

                Console.WriteLine($"LAST NAME  :{lastname.ToUpper()}");

            }

            void CHAR_COUNT()

            {

                Console.WriteLine("ENTER THE MESSAGE ");

                string msg = Console.ReadLine();

                Console.WriteLine("ENTER THE LETTER THAT MUST BE COUNTED");

                Char C = Char.Parse(Console.ReadLine());

                int COUNT = 0;

                foreach (char c in msg)

                {

                    if (c == C)

                    { COUNT++; }


                }



                Console.WriteLine($" The number of {C} character in message {msg} is {COUNT}");

            }


            static void Main(string[] args)

            {

                String First_Name, Last_Name;

                Console.WriteLine(" ENTER YOUR 1ST NAME");

                First_Name = Console.ReadLine();

                Console.WriteLine("ENTER YOUR LAST NAME");

                Last_Name = Console.ReadLine();

                Display(First_Name, Last_Name);

                STRING_OPERATION STR = new STRING_OPERATION();

                STR.CHAR_COUNT();

                Console.Read();

            }

        }

    }


