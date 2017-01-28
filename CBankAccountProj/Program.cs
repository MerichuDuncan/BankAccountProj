using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBankAccountProj
{
    class  Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("_____________________________________");
            Account client1 = new Account("Gregory Duncan ", 4444000000001234);
            client1.ClientsInfo();
            Console.WriteLine("_____________________________________");
            AccountOptions();
            CheckingAccount client2 = new CheckingAccount(0, 1/2/17, 4400000000002345);
            client2.ClientsInfo();
            
        }

        public static void AccountOptions()
        {
            Console.WriteLine("Would you like to continue? Type Y for YES or N for NO");
            string answer = Console.ReadLine();
            if (answer.ToLower()=="y")
            {
                Console.WriteLine("Enter A to check your Checking Account \nEnter B to check your Savings Account \nEnter C to check your Reserve Account");
                string answer1 = Console.ReadLine();
                    
            }
 
        }
    }
}
