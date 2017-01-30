using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBankAccountProj
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Simon's National Bank \nPlease your 4 number PIN");
            int pin = int.Parse(Console.ReadLine());
            Console.WriteLine("_____________________________________________________");

            Account client1 = new Account("Samson Duncan ", 4444000000001234, 1 / 2 / 2010);
            client1.ClientsInfo();

            {
                while (true)
                {
                    Console.WriteLine("\nEnter A to check your Checking Account \nEnter B to check your Savings Account \nEnter C to check your Reserve Account  \nE to Exit");
                    string answer1 = Console.ReadLine();
                    if (answer1.ToLower() == "a")

                    {

                        CheckingAccount checkingA = new CheckingAccount(1000, 1 / 2 / 2020, 4400000000002345);

                        checkingA.DisplayChecking();
                        checkingA.CheckWriter();

                    }

                    else if (answer1.ToLower() == "b")

                    {
                        SavingsAccount savingsA = new SavingsAccount(6500, 4400000012343210, 1 / 1 / 2000);

                        savingsA.DisplaySavings();
                        savingsA.SavingsWriter();
                    }

                    else if (answer1.ToLower() == "c")

                    {

                        ReserveAccount reserveA = new ReserveAccount(4300000012249876, 1310, 1 / 1 / 2009);

                        reserveA.DisplayReserve();
                        reserveA.ReserveWriter();
                    }
                    else

                    {
                        client1.ClientsInfo();

                        Console.WriteLine("Thank you for your business");

                        {
                            break;
                        }

                    }

                }

            }
        }
       
    }
}



