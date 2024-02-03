using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Design_Pattern
{
    internal class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeCreditCard()
        {
            return new Platinum();
        }
    }
}
