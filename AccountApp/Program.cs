using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using AccountApp;

namespace Q212610
{
    enum Option { DEPOSIT = 1, WITHDRAW = 2, CURRENT_BALANCE = 3, EXIT = 4 }
    class Programs
    {

        static void Main(string[] args)
        {


            Option option = Option.CURRENT_BALANCE;
            double amount;
            BankAccount userAccount = new BankAccount(0);
            while (option != Option.EXIT)
            {
                //Main menu
                Console.WriteLine("1. Deposit an amount into the account.");
                Console.WriteLine("2. Withdraw an amount from the account.");
                Console.WriteLine("3. View the current balance of the account.");
                Console.WriteLine("4. Exit.");
                Console.Write("Your choice: ");
                option = (Option)int.Parse(Console.ReadLine());
                //Deposit an amount into the account
                if (option == Option.DEPOSIT)
                {
                    Console.Write("Enter the amount to deposit: ");
                    double.TryParse(Console.ReadLine(), out amount);
                    userAccount.Deposit(amount);
                }
                else if (option == Option.WITHDRAW)//Withdraw an amount from the account.
                {
                    Console.Write("Enter the amount to withdraw: ");
                    double.TryParse(Console.ReadLine(), out amount);
                    userAccount.Withdraw(amount);
                }
                else if (option == Option.CURRENT_BALANCE)//View the current balance of the account
                {
                    userAccount.DisplayCurrentBalance();
                }
                else if (option == Option.EXIT)
                {
                    //Exit
                }
                else
                {
                    Console.WriteLine("Wrong menu item.");
                }
            }
        }


    }
}
