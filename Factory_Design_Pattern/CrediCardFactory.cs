using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    internal class CrediCardFactory
    {
        public static CreditCard GetCreditCard(string cardName)
        {
            CreditCard card = null;

            if (cardName.Equals("MoneyBack"))
            {
                card = new MoneyBack();
            }
            else if (cardName.Equals("Platinum"))
            {
                card = new Platinum();
            }
            else
            {
                card = new Titanium();
            }
            return card;
        }
    }
}
