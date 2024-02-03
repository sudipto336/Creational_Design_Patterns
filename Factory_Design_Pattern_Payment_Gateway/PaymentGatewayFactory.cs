using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_Payment_Gateway
{
    internal class PaymentGatewayFactory
    {
        public static PaymentGateway CreatePaymentGateway(string gatewayName)
        {
            switch (gatewayName) {
                case "paytm":
                    return new PaytmGateway();
                    break;
                case "billdesk":
                    return new BillDeskGateway();
                    break;
                case "razorpay":
                    return new RazorpayGateway();
                    break;
                default:
                    throw new ArgumentException("Imvalid payment gateway selected");
            }
        }
    }
}
