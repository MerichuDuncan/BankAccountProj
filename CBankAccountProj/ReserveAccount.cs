using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBankAccountProj
{
    class ReserveAccount : Account
    {
        //fields
        private decimal ReserveNumber;
        private double ReserveBalance;
        private double reserveOut;
        private double reserveIn;
        private int dateTime3;


        //properties
        public decimal Reserve
        {
            get { return this.ReserveNumber; }
            set { this.ReserveNumber = value; }
        }
        public double RBalance
        {
            get { return this.ReserveBalance; }
            set { this.ReserveBalance = value; }
        }
        public double ResOut
        {
            get { return this.reserveOut; }
            set { this.reserveOut = value; }
        }
        public double ResIn
        {
            get { return this.reserveIn; }
            set { this.reserveIn = value; }
        }
        public int Datereserve
        {
            get { return this.dateTime3; }
            set { this.dateTime3 = value; }
        }

        //constructor
        public ReserveAccount(decimal ReserveNumber, double ReserveBalance, int dateTime3)
        {
            this.ReserveNumber = ReserveNumber;
            this.ReserveBalance = ReserveBalance;
            this.dateTime3 = dateTime3;

        }
        public void DisplayReserve()
        {
            Console.WriteLine("____________________________________________\n");
            Console.WriteLine("Reserve account Number: " + ReserveNumber + "\nYour checking account balance: $" + ReserveBalance);
            Console.WriteLine("Enter A to deposit money or B to withdraw");
            string reservemoney = Console.ReadLine();
            if (reservemoney.ToLower() == "a")
            {
                Console.WriteLine("Enter an amount");
                double resDepamount = int.Parse(Console.ReadLine());
                Console.WriteLine("Your reserve account balance: $" + (ReserveBalance += resDepamount));
                Console.WriteLine(DateTime.Now);
                DisplayReserve();
            }
            else if (reservemoney.ToLower() == "b")

            {
                Console.WriteLine("Enter an amount");
                double resWidamount = int.Parse(Console.ReadLine());
                Console.WriteLine("Your reserve account balance: $" + (ReserveBalance -= resWidamount));
                Console.WriteLine(DateTime.Now);
            }
            else
            {
                Console.WriteLine("______________________________________________");
                return;
            }

        }
    }
}
