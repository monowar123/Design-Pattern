using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Decorator
{
    public interface ICakeDecorator
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
        public void Decorate(string message)
        {
            cake.AddLayer($"Message for the cake: {message}");
        }
    }
}
