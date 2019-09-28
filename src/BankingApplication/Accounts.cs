using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public abstract class Accounts
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public double AccountBalance { get; set; }

        public virtual double Widraw(int widraw_amount)
        {
            if (widraw_amount < 0)
            {
                throw new Exception("Please Enter a Positive Number Greater than 0");
            }
            this.AccountBalance = this.AccountBalance - widraw_amount;
            return this.AccountBalance;              
       }
        public double Deposit(int deposit_amount)
        {
            if (deposit_amount > 25000)
            {
                throw new Exception("Please Enter a Positive Number Less than 25000");
            }
            this.AccountBalance = this.AccountBalance - deposit_amount;
            return this.AccountBalance;
        }

        public double GetAccountBalance()
        {
            return this.AccountBalance;
        }
    }
}
