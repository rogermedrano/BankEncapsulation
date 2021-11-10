using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            //Deposit();

            myAccount.Deposit(0);
            var balance = myAccount.GetBalance();

            Console.WriteLine($"Your new balance is:  ${balance}");
            Console.WriteLine();
            Console.WriteLine();
            {
                Console.WriteLine("Would you like to make another deposit?");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    myAccount.Deposit(0);
                }
                if (answer == "no")
                {
                    Console.WriteLine("Have a good day.");
                }
                else
                {
                    Console.WriteLine("It's a YES or NO question... Log back in and try again.");
                }
            }
        }

        

    }
}
