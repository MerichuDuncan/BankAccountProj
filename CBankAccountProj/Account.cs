using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBankAccountProj

{
    class Account
    {
        //fields
        protected string clientName;

        protected decimal accountNumber;

        private double accountBalance;

      //  private float withdraw;
   

        private string exit;


        //properties
        public string Client
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }
        public decimal AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public double Balance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public string Exit
        {
            get { return this.exit; }
            set { this.exit = value; }
        }



        //constructor(2 arguments)
        public Account()
        {

        }

        public Account(string clientName, decimal accountNumber)
        {
            this.clientName = clientName;
            this.accountNumber = accountNumber;
            
        }
        public Account( double accountBalance)
        {
            this.accountBalance = accountBalance;
        }
     
        public virtual void ClientsInfo()
        {
            Console.WriteLine("Account number: " + accountNumber);
            Console.WriteLine("Your account balance is: " + accountBalance);
            
           
        }

    }
}
