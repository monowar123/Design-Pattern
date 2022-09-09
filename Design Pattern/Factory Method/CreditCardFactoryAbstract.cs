using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Factory_Method
{
    public abstract class CreditCardFactoryAbstract
    {
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }

    public class MoneyBackFactory : CreditCardFactoryAbstract
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new MoneyBack();
            return creditCard;
        }
    }

    public class PlatinumFactory : CreditCardFactoryAbstract
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new Platinum();
            return creditCard;
        }
    }

    public class TitaniumFactory : CreditCardFactoryAbstract
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new Titanium();
            return creditCard;
        }
    }
}
