using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Abstract_Factory
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(AnimalType animalType);
        public static AnimalFactory CreateAnimalFactory(FactoryType factoryType)
        {
            if (factoryType.Equals(FactoryType.SEA))
                return new SeaAnimalFactory();
            else
                return new LandAnimalFactory();
        }
    }

    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(AnimalType animalType)
        {
            IAnimal animal = null;

            switch (animalType)
            {
                case AnimalType.DOG:
                    animal = new Dog();
                    break;
                case AnimalType.CAT:
                    animal = new Cat();
                    break;
                case AnimalType.LION:
                    animal = new Lion();
                    break;
                default:
                    break;
            }

            return animal;
        }
    }

    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(AnimalType animalType)
        {
            IAnimal animal = null;

            switch (animalType)
            {
                case AnimalType.SHARK:
                    animal = new Shark();
                    break;
                case AnimalType.OCTOPUS:
                    animal = new Octopus();
                    break;
                default:
                    break;
            }

            return animal;
        }
    }
}
