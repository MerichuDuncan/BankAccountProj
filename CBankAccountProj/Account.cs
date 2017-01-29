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

        private int dateTime;


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

        public int Date
        {
            get { return this.dateTime; }
            set { this.dateTime = value; }
        }



        //constructor
        public Account()
        {

        }
        public Account(string clientName, decimal accountNumber, int dateTime)
        {
            this.clientName = clientName;
            this.accountNumber = accountNumber;
            this.dateTime = dateTime;
            
        }
      
        public void ClientsInfo()
         
         {
            
            
            Console.WriteLine("Account Name: " + clientName);
            Console.WriteLine("Account number: " + AccountNumber);
            Console.WriteLine(DateTime.Now);
            return;
           
        }
     

    }
}
