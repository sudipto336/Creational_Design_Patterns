using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_Payment_Gateway
{
    internal class BillDeskGateway : PaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} through Bill Desk");
        }
    }
}
