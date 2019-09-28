using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Current : Accounts
    {
        public Current()
        {
            this.AccountType = "Current";
        }
        //PolyMorphism
        #region Polymorphic Behaviour of Widraw Method after implementing Inheritance, Current Account has an Overdraft facility of 25000
        public override double Widraw(int widraw_amount)
        {
            if (widraw_amount > AccountBalance + 25000)
            {
                throw new Exception("You Cannot Widraw more than " + (this.AccountBalance + 25000) + " From Your Account ");
            }
            return base.Widraw(widraw_amount);
        }
        #endregion
    }
}
