using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public void Deposit(double amountToDeposit)
        {
            //Define a method named Deposit that will accept a double and store that value in the balance field
            
            Console.Write("Enter the amount you wish to deposit:  $");
            double currentDeposit = Convert.ToInt32(Console.ReadLine());
            
            balance = balance += currentDeposit;
        }

        public double GetBalance()
        {
            return balance;
        }

        //public void Withdrawal(double amountOfWithdrawal)
        //{
        //    //Define a method named Deposit that will accept a double and store that value in the balance field
        //    balance -= amountOfWithdrawal;
        //}

        //public double GetBalance1()
        //{
        //    return balance;
        //}


    }
}
