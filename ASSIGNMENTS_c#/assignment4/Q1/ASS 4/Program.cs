using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_4a
{
    internal class Accounts
    {
        public int Accno;
        public string CustName;
        public string AccType;
        public string TransType;
        public double amount;
        public double balance = 1000;


        public void Show()
        { Console.WriteLine("enter the Account no");
            this.Accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Customer name");
            this.CustName = Console.ReadLine();
            Console.WriteLine("enter the Account type");
            this.AccType = Console.ReadLine();
            Console.WriteLine("enter the Transaction type");
            this.TransType = Console.ReadLine();
            Console.WriteLine("enter the amount");
            this.amount = Convert.ToDouble(Console.ReadLine());

            if (TransType == "d")
            {
                TransType = "deposit";
                balance = balance + amount;
            }
            else
            {
                if (TransType == "w" && amount < balance)
                {
                    TransType = "Withdrawl";
                    balance = balance - amount;
                }
                else if (TransType == "w" && amount > balance)
                {
                    TransType = "transaction is not possible";
                }
                Console.WriteLine($"Accountnumber:{Accno}Customer name:{CustName}Account type:{AccType}Transaction type:{TransType}Amount:{amount}Remaining balance:{balance}");
            }
            
        }
        static void Main()
        {
            Accounts obj = new Accounts();
            obj.Show();
            Console.ReadKey();
        }
    }
}
  
