using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational_Design_Pattern.Abstract_Factory_02
{
    public interface ITable
    {
        string GetName();
        double GetPrice();
    }


    public class VictorianTable : ITable
    {
        public string GetName()
        {
            return "Victorian Table";
        }

        public double GetPrice()
        {
            return 2000;
        }
    }


    public class ModernTable : ITable
    {
        public string GetName()
        {
            return "Modern Table";
        }

        public double GetPrice()
        {
            return 2500;
        }
    }
}
