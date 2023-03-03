using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational_Design_Pattern.Abstract_Factory_02
{
    public interface ISofa
    {
        string GetName();
        double GetPrice();
    }

    public class VictorianSofa : ISofa
    {
        public string GetName()
        {
            return "Victorian Sofa";
        }

        public double GetPrice()
        {
            return 5000;
        }
    }


    public class ModernSofa : ISofa
    {
        public string GetName()
        {
            return "Modern Sofa";
        }

        public double GetPrice()
        {
            return 6500;
        }
    }
}
