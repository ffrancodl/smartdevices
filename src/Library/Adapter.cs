
using System;

namespace AdapterExample;
{
    public class Adapter: ISmartDevice
    {
        public Adapter(Plug plug)
        {
            this.plug = plug;
        }

        public Plug plug {get; set;}
        public void ToggleStatus()
        {
            if (this.plug.GetStatus().Equals("off"))
            {
            this.plug.ToggleStatus();
            Console.WriteLine("The Plug is on");
            }
            else
            {
            this.plug.ToggleStatus();
            Console.WriteLine("The Plug is off");
            }
        }
        public string GetStatus()
        {
            return this.plug.GetStatus();
        }
    }
}