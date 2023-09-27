using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class ConcessionCalculator
    {
        public const int TotalFare = 500;

        public string Name { get; set; }
        public int Age { get; set; }

        public void CalculateConcession()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
            if (Age <= 5)
            {

                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (Age > 60)
            {
                double discountedFare = TotalFare * 0.7;

                Console.WriteLine($"Senior Citizen - Fare: {discountedFare:C}");
            }
            else
            {

                Console.WriteLine($"Ticket Booked - Fare: {TotalFare:C}");
            }
        }
    }
}