using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    internal class Platinum : CreditCard
    {
        int CreditCard.GetAnnualCharge()
        {
            return 2000;
        }

        int CreditCard.GetCreditLimit()
        {
            return 20000;
        }
    }
}
