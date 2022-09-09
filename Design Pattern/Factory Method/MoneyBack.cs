using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Factory_Method
{
    public class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "Money Back";
        }

        int ICreditCard.GetCreditLimit()
        {
            return 15000;
        }

        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
