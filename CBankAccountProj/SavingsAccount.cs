using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CBankAccountProj
{
    class SavingsAccount : Account
    {
        //fields
        private double deposit;
        private double withdraw;
        private decimal SavingsNumber;
        private double SBalance;
        private int dateTime2;

        //properties
        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }
        public decimal Savings
        {
            get { return this.SavingsNumber; }
            set { this.SavingsNumber = value; }
        }
        public double Withdraw
        {
            get { return this.withdraw; }
            set { this.withdraw = value; }
        }
        public double SaveBalance
        {
            get { return this.SBalance; }
            set { this.SBalance = value; }
        }
        public int Date2
        {
            get { return this.dateTime2; }
            set { this.dateTime2 = value; }
        }
        //constructor
        public SavingsAccount(double deposit, decimal SavingsNumber, double withdraw, double SBalance)
        {
            this.deposit = deposit;
            this.SavingsNumber = SavingsNumber;
            this.withdraw = withdraw;
            this.SBalance = SBalance;

        }
        public SavingsAccount(double SBalance, decimal SavingsNumber, int dateTime2)
        {
            this.SBalance = SBalance;
            this.SavingsNumber = SavingsNumber;
            this.dateTime2 = dateTime2;
        }
        public void DisplaySavings()
        {

            Console.WriteLine("____________________________________________\n");
            Console.WriteLine("Savings account Number: " + SavingsNumber + "\nYour savings account balance: $" + SBalance);
            Console.WriteLine("Enter A to deposit money or B to withdraw");
            string savingsmoney = Console.ReadLine();
            if (savingsmoney.ToLower() == "a")
            {
                Console.WriteLine("Enter an amount");
                double depositAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("Your savings account balance: $" + (SBalance += depositAmount));
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("______________________________________________");
                DisplaySavings();
            }
            else if (savingsmoney.ToLower() == "b")

            {
                Console.WriteLine("Enter an amount");
                double WithdrawAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("Your savings account balance: $" + (SBalance -= WithdrawAmount));
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("______________________________________________");


            }
            else
            {
                Console.WriteLine("That is an invalid Key");
                return;
            }
        }
          
        }
       
    }


