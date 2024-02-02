using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    internal class MoneyBack : CreditCard
    {
        int CreditCard.GetAnnualCharge()
        {
            return 1000;
        }

        int CreditCard.GetCreditLimit()
        {
            return 10000;
        }
    }
}
