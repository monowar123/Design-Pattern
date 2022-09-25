using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Abstract_Factory
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Can't speak";
        }
    }
}
