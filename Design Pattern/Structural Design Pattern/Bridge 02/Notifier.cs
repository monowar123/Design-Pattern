using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Bridge_02
{
    public abstract class Notifier
    {
        protected IMessageSender messageSender;
        public abstract void Notify(string message);
    }

    public class ShortMessageNotifier : Notifier
    {
        public ShortMessageNotifier(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }
        public override void Notify(string message)
        {
            if(message.Length <=10)
            {
                messageSender.SendMessage(message);
            }
            else
            {
                Console.WriteLine("Unable to send message more than 10 char.");
            }
        }
    }

    public class LongMessageNotifier : Notifier
    {
        public LongMessageNotifier(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }
        public override void Notify(string message)
        {
            messageSender.SendMessage(message);
        }
    }
}
