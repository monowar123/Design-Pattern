using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Factory_Method
{
    public enum CreditCardType
    {
        MONEYBACK,
        TITANIUM,
        PLATINUM
    }

    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
