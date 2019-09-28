using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class PF : Accounts
    {

        public PF()
        {
            this.AccountType = "PF";
        }
        //PolyMorphism
        #region Polymorphic Behaviour of Widraw Method after implementing Inheritance
        public override double Widraw(int widraw_amount)
        {
            if (widraw_amount > AccountBalance * 0.3)
            {
                throw new Exception("You Cannot Widraw more than " + (this.AccountBalance * 0.3) + " From Your Account ");
            }
            return base.Widraw(widraw_amount);
        }
        #endregion

    }
}
