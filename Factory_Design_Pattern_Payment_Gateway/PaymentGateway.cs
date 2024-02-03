using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_Payment_Gateway
{
    internal interface PaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
