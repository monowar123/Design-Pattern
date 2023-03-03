using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational_Design_Pattern.Abstract_Factory_02
{
    public interface IFurnitureFactory
    {
        IChair GetChair();
        ISofa GetSofa();
        ITable GetTable();
    }

    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair GetChair()
        {
            return new VictorianChair();
        }

        public ISofa GetSofa()
        {
            return new VictorianSofa();
        }

        public ITable GetTable()
        {
            return new VictorianTable();
        }
    }

    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair GetChair()
        {
            return new ModernChair();
        }

        public ISofa GetSofa()
        {
            return new ModernSofa();
        }

        public ITable GetTable()
        {
            return new ModernTable();
        }
    }
}
