using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_5_C
{
    class class3
    {
        public static void Main()
        {
            SaleDetails sale = new SaleDetails(2, 342, 14.99, 3, DateTime.Now);
            sale.Sales(); // Calculate the TotalAmount

            Console.WriteLine("Sales Details:");
            sale.ShowData();
            Console.ReadLine();
        }
    }
}

