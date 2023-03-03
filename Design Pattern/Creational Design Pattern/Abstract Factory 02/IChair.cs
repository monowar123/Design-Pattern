using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational_Design_Pattern.Abstract_Factory_02
{
    public interface IChair
    {
        string GetName();
        double GetPrice();
    }

    public class VictorianChair : IChair
    {
        public string GetName()
        {
            return "Victorian Chair";
        }

        public double GetPrice()
        {
            return 1050;
        }
    }


    public class ModernChair : IChair
    {
        public string GetName()
        {
            return "Modern Chair";
        }

        public double GetPrice()
        {
            return 1200;
        }
    }
}
