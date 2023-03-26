using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Composite
{
    public interface IComponent
    {
        void DisplayPrice();
        int GetTotalPrice();
    }

    public class Leaf : IComponent
    {
        int price;
        string name;
        public Leaf(string name, int price)
        {
            this.price = price;
            this.name = name;
        }
        public void DisplayPrice()
        {
            Console.WriteLine($"{name} price is {price}");
        }

        public int GetTotalPrice()
        {
            return this.price;
        }
    }

    public class Composite : IComponent
    {
        string name;
        int price;
        List<IComponent> components = new List<IComponent>();

        public Composite(string name, int price=0)
        {
            this.name = name;
            this.price = price;
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            components.Remove(component);
        }

        List<IComponent> GetChildren()
        {
            return this.components;
        }
        public void DisplayPrice()
        {
            Console.WriteLine($"{name} price is {price}");
            foreach (var item in components)
            {
                item.DisplayPrice();
            }
        }

        public int GetTotalPrice()
        {
            int totalPrice = 0;
            foreach(var item in components)
            {
                totalPrice += item.GetTotalPrice();
            }

            return totalPrice;
        }
    }
}
