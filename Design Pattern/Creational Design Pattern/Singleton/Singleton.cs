using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.SingletonPattern
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object InstanceLock = new object();
        private static Singleton instance = null;

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value: " + counter.ToString());
        }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (InstanceLock)
                    {
                        if (instance == null)
                            instance = new Singleton();
                        return instance;
                    }
                }

                return instance;
            }
        }

        public void PrintDetails(string msg)
        {
            Console.WriteLine(msg + ", Counter Value: " + counter);
        }
    }
}
