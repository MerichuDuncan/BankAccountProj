using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
                Console.WriteLine("______________________________________________");
                DisplayChecking();
            }
            else if (checkmoney.ToLower() == "b")

            {
                Console.WriteLine("Enter an amount");
                double withdraw = int.Parse(Console.ReadLine());
                Console.WriteLine("Your checking account balance: $" + (CBalance -= withdraw));
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("______________________________________________");


            }
            else
            {
                Console.WriteLine("That is an invalid Key");
                return;
            }

            StreamWriter check = new StreamWriter("Checking.txt");
            double currentBal = 1000;
            check.WriteLine("Client Name: " + clientName);
            check.WriteLine("Account number: " + checkingNumber);
            check.WriteLine("Your checking account balance: " + currentBal);
            check.WriteLine("Account new balance: " + CBalance);
            check.WriteLine("Moneyout: " + (currentBal -= CBalance));
            check.WriteLine(DateTime.Now);
            check.Close();
        }


    }

}




