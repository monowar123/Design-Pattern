using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Bridge_02
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    public class SMSSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"{message} :(Message send through SMS gateway)");
        }
    }

    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"{message} :(Message send through Email gateway)");
        }
    }
}
