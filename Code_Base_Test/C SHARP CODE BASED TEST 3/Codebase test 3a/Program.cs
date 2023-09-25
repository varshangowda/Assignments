using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase_test_3a
{
    class Cricket
    {
        public void PointsCalculation(int no_of_matches)
        {
            int sum = 0;
            double average;
            Console.WriteLine("ENTER THE SCORES FOR EACH MATCH");
            for (int i = 1; i < no_of_matches; i++)
            {
                Console.WriteLine("SCORE of a match" + i + ":");
                int score = int.Parse(Console.ReadLine());
                sum += score;
            }
            average = (double)sum / no_of_matches;
            Console.WriteLine("SUM OF SCORES:" + sum);
            Console.WriteLine("AVERAGE SCORE:" + average);
        }
    }

    class Ipl
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE N OF MATCHES");
            int no_of_matches = int.Parse(Console.ReadLine());
            Cricket cricket = new Cricket();
            cricket.PointsCalculation(no_of_matches);
            Console.ReadLine();
        }
    }
}
