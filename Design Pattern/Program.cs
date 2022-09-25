using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Pattern.Factory_Method;
using Design_Pattern.Abstract_Factory;

namespace Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------Call Factory Design pattern-----------
            //ICreditCard creditCard = CreditCardFactory.GetCreditCard(CreditCardType.TITANIUM);

            //------------Call the Factory Method Design pattern-----------
            //ICreditCard creditCard = new TitaniumFactory().CreateProduct();

            //if (creditCard != null)
            //{
            //    Console.WriteLine("Card Type : {0}", creditCard.GetCardType());
            //    Console.WriteLine("Credit Limit : {0}", creditCard.GetCreditLimit());
            //    Console.WriteLine("Annual Charge : {0}", creditCard.GetAnnualCharge());
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Card Type");
            //}


            //--------------Call the Abstract Factory Design pattern----------------
            AnimalFactory animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            IAnimal animal = animalFactory.GetAnimal(AnimalType.CAT);

            Console.WriteLine(animal.Speak());
            



            Console.ReadKey();
        }
    }
}
