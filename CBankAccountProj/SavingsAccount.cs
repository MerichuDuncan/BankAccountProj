using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBankAccountProj
{
    class SavingsAccount : Account
    {
        //fields
        private double deposit;
        private double withdraw;
        private string statement;




        //properties
        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }
        private string Statement
        {
            get { return this.statement; }
            set { this.statement = value; }
        }
        private double Withdraw
        {
            get { return this.withdraw; }
            set { this.withdraw = value; }
        }
        public override void ClientsInfo()
        {
            base.ClientsInfo();
        }
    }
}
