﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    internal interface CreditCard
    {
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
