using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Bridge
{
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int volume);
        int GetChannel();
        void SetChannel(int channel);
    }

    public class TV : IDevice
    {
        private int channel;
        private int volume;
        private bool enabled = false;
        public void Disable()
        {
            Console.WriteLine("Disable TV");
        }

        public void Enable()
        {
            Console.WriteLine("Enable TV");
        }

        public int GetChannel()
        {
            return channel;
        }

        public int GetVolume()
        {
            return volume;
        }

        public bool IsEnabled()
        {
            return enabled;
        }

        public void SetChannel(int channel)
        {
            this.channel = channel;
            Console.WriteLine("TV Channnel is set to {0}", this.channel);
        }

        public void SetVolume(int volume)
        {
            if (volume > 0)
                this.volume = this.volume + volume;
            else
                this.volume = 0;

            Console.WriteLine("TV Volume is set to {0}", this.volume);
        }
    }

    public class Radio : IDevice
    {
        private int channel;
        private int volume;
        private bool enabled = false;
        public void Disable()
        {
            Console.WriteLine("Disable Radio");
        }

        public void Enable()
        {
            Console.WriteLine("Enable Radio");
        }

        public int GetChannel()
        {
            return channel;
        }

        public int GetVolume()
        {
            return volume;
        }

        public bool IsEnabled()
        {
            return enabled;
        }

        public void SetChannel(int channel)
        {
            this.channel = channel;
            Console.WriteLine("Radio Channnel is set to {0}", this.channel);
        }

        public void SetVolume(int volume)
        {
            if (volume > 0)
                this.volume = this.volume + volume;
            else
                this.volume = 0;

            Console.WriteLine("Radio Volume is set to {0}", this.volume);
        }
    }
}
