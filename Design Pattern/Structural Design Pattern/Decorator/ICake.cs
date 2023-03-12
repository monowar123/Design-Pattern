using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Decorator
{
    public interface ICake
    {
        void AddLayer(string layer);
        void PrintLayers();
    }

    public class VanilaCake : ICake
    {
        private IList<string> layers = new List<string>();
        public void AddLayer(string layer)
        {
            layers.Add(layer);
        }

        public void PrintLayers()
        {
            Console.WriteLine("-------Vanila Cakes------");
            foreach(var layer in layers)
            {
                Console.WriteLine($"Layer: {layer}");
            }
        }
    }


    public class ChokolateCake : ICake
    {
        private IList<string> layers = new List<string>();
        public void AddLayer(string layer)
        {
            layers.Add(layer);
        }

        public void PrintLayers()
        {
            Console.WriteLine("-------Chokolate Cakes------");
            foreach (var layer in layers)
            {
                Console.WriteLine($"Layer: {layer}");
            }
        }
    }
}
