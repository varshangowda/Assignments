using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_5_C
{


    class SaleDetails
    {
        private int SalesNum;
        private int ProductNum;
        private double Price;
        private DateTime DOfSale;
        private int Qty;
        private double TotalAmount;


        public SaleDetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
        {
            this.SalesNum = salesNo;
            this.ProductNum = productNo;
            this.Price = price;
            this.DOfSale = dateOfSale;
            this.Qty = qty;
            this.TotalAmount = 0;
        }


        public void Sales()
        {
            this.TotalAmount = this.Qty * this.Price;
        }


        public void ShowData()
        {
            Console.WriteLine($"Sales No: {this.SalesNum}");
            Console.WriteLine($"Product No: {this.ProductNum}");
            Console.WriteLine($"Price: {this.Price:C}");
            Console.WriteLine($"Date of Sale: {this.DOfSale.ToShortDateString()}");
            Console.WriteLine($"Qty: {this.Qty}");
            Console.WriteLine($"Total Amount: {this.TotalAmount:C}");
        }
    }

}
    
