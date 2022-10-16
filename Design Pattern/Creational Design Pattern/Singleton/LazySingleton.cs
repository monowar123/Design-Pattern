using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.SingletonPattern
{
    public class LazySingleton
    {
        private static int counter = 0;

        private static readonly Lazy<LazySingleton> InstanceLock = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {
            counter++;
            Console.WriteLine("Counter Value: " + counter.ToString());
        }

        public static LazySingleton GetInstance
        {
            get
            {
                return InstanceLock.Value;
            }
        }

        public void PrintDetails(string msg)
        {
            Console.WriteLine(msg + ", Counter Value: " + counter);
        }
    }
}
