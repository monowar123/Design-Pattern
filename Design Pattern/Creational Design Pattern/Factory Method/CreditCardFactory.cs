using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Factory_Method
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(CreditCardType cardType)
        {
            ICreditCard creditCard = null;

            switch (cardType)
            {
                case CreditCardType.MONEYBACK:
                    creditCard = new MoneyBack();
                    break;

                case CreditCardType.PLATINUM:
                    creditCard = new Platinum();
                    break;

                case CreditCardType.TITANIUM:
                    creditCard = new Titanium();
                    break;

                default:
                    break;
            }

            return creditCard;
        }
    }
}
