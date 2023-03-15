using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Decorator
{
    public interface ICakeDecorator : ICake
    {
        void Decorate(string message);
    }

    public class CakeMessageDecorator : ICakeDecorator
    {
        private readonly ICake cake;
        public CakeMessageDecorator(ICake cake)
        {
            this.cake = cake;
        }

        public void AddLayer(string layer)
        {
            cake.AddLayer(layer);
        }

        public void Decorate(string message)
        {
            cake.AddLayer($"Message for the cake: {message}");
        }

        public void PrintLayers()
        {
            cake.PrintLayers();
        }
    }
}
