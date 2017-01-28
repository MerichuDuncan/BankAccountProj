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
        public double Balance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }
        //constructor
        public CheckingAccount(double accountBalance, int dateTime, decimal checkingNumber)
        {
            this.accountBalance = accountBalance;
            this.dateTime = dateTime;
            this.checkingNumber = 4400000000002345;
        }
        
       
       
      
        
        public void DisplayChecking()
        {
            Console.WriteLine("Your account balance is: " + Balance);
            Console.WriteLine();
            Console.WriteLine("Please add money to your Checking Account: ");
            double deposit = int.Parse(Console.ReadLine());
            Console.WriteLine("_______________________________________");
            double results = deposit + Balance;
            Console.WriteLine("Total Balance is : $" + results + " " + DateTime.Now + "\nType A to Withdraw or B to Exit");
            string result1 = Console.ReadLine();
            if (result1.ToLower() == "a")
            {
                Console.WriteLine("Enter an amount");
                double withdraw = int.Parse(Console.ReadLine());
                Console.WriteLine("Your account balance: $" + (results - withdraw) + " " + DateTime.Now);
            }
            
        }
        public override void ClientsInfo()
        {
            base.ClientsInfo();
        }
    }
}

