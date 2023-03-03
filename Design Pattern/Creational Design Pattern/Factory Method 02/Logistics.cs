using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational_Design_Pattern.Factory_Method_2
{
    public abstract class Logistics
    {
        protected abstract ITransport CreateTransport();
        public ITransport GetTransport()
        {
            return this.CreateTransport();
        }
    }

    public class RoadLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new Truck();
        }
    }

    public class SeaLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
