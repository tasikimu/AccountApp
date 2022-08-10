using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BankingApp
{
    public abstract class IBanking
    {
        public abstract void Withdraw(double amount);
        public abstract void Deposit(double amount);
    }
}