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
        private double moneySaveUp;
        private string statement;




        //properties
        public double Saveup
        {
            get { return this.moneySaveUp; }
            set { this.moneySaveUp = value; }
        }
        public string Statement
        {
            get { return this.statement; }
            set { this.statement = value; }
        }

        //constructor
        public ReserveAccount(double moneySaveUp, string statement)
        {
            this.moneySaveUp = moneySaveUp;
            this.statement = statement;
        }

        public void DisplayReserve()
        {
            Console.WriteLine("Reserve Account balance is: ");
        }
    }
}