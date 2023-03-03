using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational_Design_Pattern.Factory_Method_2
{
    public interface ITransport
    {
        string DeliverProduct();
        double CalculateCost();
    }

    public class Truck : ITransport
    {
        public string DeliverProduct()
        {
            return "Deliver by land in a box";
        }

        public double CalculateCost()
        {
            return 500;
        }
    }


    public class Ship : ITransport
    {
        public string DeliverProduct()
        {
            return "Deliver by sea in a container";
        }

        public double CalculateCost()
        {
            return 350;
        }
    }
}
