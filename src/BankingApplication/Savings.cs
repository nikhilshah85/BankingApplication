using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Savings :Accounts
    {
        public Savings()
        {
            this.AccountType = "Savings";
        }
        //PolyMorphism
        #region Polymorphic Behaviour of Widraw Method after implementing Inheritance, Savings account cannot widraw more than 50,000 in a Singlt transaction
        public override double Widraw(int widraw_amount)
        {
            if (widraw_amount > 50000)
            {
                throw new Exception("You Cannot Widraw more than 50000  From Your Account");
            }
            return base.Widraw(widraw_amount);
        }
        #endregion
    }
}
