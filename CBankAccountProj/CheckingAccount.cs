using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBankAccountProj
{
    class CheckingAccount : Account

    {
        //fields
        private decimal checkingNumber;
        private double withdraw;
        private int dateTime;
        private double accountBalance;

        //properties
        public double Withdraw
        {
            get { return this.withdraw; }
            set { this.withdraw = value; }
        }
        public int Time
        {
            get { return this.dateTime; }
            set { this.dateTime = value; }
        }
        public decimal Check
        {
            get { return this.checkingNumber; }
            set { this.checkingNumber = value; }
        }
        public double CBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }
        //constructor
        public CheckingAccount(double accountBalance, int dateTime, decimal checkingNumber)
        {
            this.accountBalance = accountBalance;
            this.dateTime = dateTime;
            this.checkingNumber = checkingNumber;
        }





        public void DisplayChecking()
        {
            Console.WriteLine("____________________________________________\n");
            Console.WriteLine("Checking account Number: " + checkingNumber + "\nYour checking account balance: $" + CBalance);
            Console.WriteLine("Enter A to deposit money or B to withdraw");
            string checkmoney = Console.ReadLine();
            if (checkmoney.ToLower() == "a")
            {
                Console.WriteLine("Enter an amount");
                double damount = int.Parse(Console.ReadLine());
                Console.WriteLine("Your checking account balance: $" + (CBalance += damount));
                Console.WriteLine(DateTime.Now);
                DisplayChecking();
            }
            else
            //if (checkmoney.ToLower() == "b")

            {
                Console.WriteLine("Enter an amount");
                double wamount = int.Parse(Console.ReadLine());
                Console.WriteLine("Your checking account balance: $" + (CBalance -= wamount));
                Console.WriteLine(DateTime.Now);
            }
            Console.WriteLine("______________________________________________");
            return;
        }
    }
}


