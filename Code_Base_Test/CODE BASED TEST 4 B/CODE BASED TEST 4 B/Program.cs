using System;
namespace CODE_BASED_TEST_4_B
{
    delegate int CalculatorDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorDelegate addDelegate = Add;
            CalculatorDelegate subDelegate = Sub;
            CalculatorDelegate multiplyDelegate = Multiply;

            Console.WriteLine("Calculator Functionalities");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("Enter your choice (1/2/3):");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Enter the first number:");
                if (int.TryParse(Console.ReadLine(), out int n1))
                {
                    Console.WriteLine("Enter the second number:");
                    if (int.TryParse(Console.ReadLine(), out int n2))
                    {
                        int res = 0;
                        switch (choice)
                        {
                            case 1:
                                res = addDelegate(n1, n2);
                                Console.WriteLine($" addition: {res}");
                                break;
                            case 2:
                                res = subDelegate(n1, n2);
                                Console.WriteLine($" subtraction: {res}");
                                break;
                            case 3:
                                res = multiplyDelegate(n1, n2);
                                Console.WriteLine($" multiplication: {res}");
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for the second number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the first number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
            }
            Console.ReadLine();
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;

        }

    }

}
