using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Bridge
{
    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            if (device.IsEnabled())
                device.Disable();
            else
                device.Enable();
            
        }
        public void VolumeUp()
        {
            device.SetVolume(device.GetVolume() + 10);
        }
        public void VolumeDown()
        {
            device.SetVolume(device.GetVolume() - 10);
        }

        public void ChannelUp()
        {
            device.SetChannel(device.GetChannel() + 1);
        }
        public void ChannelDown()
        {
            device.SetChannel(device.GetChannel() - 1);
        }
    }


    public class AdvanceRemoteControl : RemoteControl
    {
        private int tempVolume = 0;
        public AdvanceRemoteControl(IDevice device) : base(device)
        {

        }

        public void ToggleMute()
        {
            if(tempVolume > 0)
            {
                this.tempVolume = device.GetVolume();
                device.SetVolume(0);
            }
            else
            {
                device.SetVolume(this.tempVolume);
                this.tempVolume = 0;
            }
        }
    }
}
