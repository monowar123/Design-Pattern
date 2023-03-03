using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Abstract_Factory
{
    public enum AnimalType
    {
        DOG,
        CAT,
        LION,
        SHARK,
        OCTOPUS
    }

    public enum SeaAnimaltype
    {
        SHARK,
        OCTOPUS
    }

    public enum FactoryType
    {
        SEA,
        LAND
    }

    public interface IAnimal
    {
        string Speak();
    }
}
