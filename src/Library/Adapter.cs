
using System;

namespace AdapterExample

{
    public class Adapter: ISmartDevice
    {
        public Adapter(Plug plug)
        {
            this.plug = plug;
        }

        public Plug plug {get; set;}
        public void On()
        {
            if (this.plug.GetStatus().Equals("on"))
            {
                this.plug.ToggleStatus();
                Console.WriteLine("plug is on");
            }
            else
            {
                Console.WriteLine("plug is off");
            }
        }

        public void Off()
        {
            if (this.plug.GetStatus().Equals("off"))
            {
                this.plug.ToggleStatus();
                Console.WriteLine("plug is off");
            }
            else
            {
                Console.WriteLine("plug is on");
            }
        }
        public string GetStatus()
        {
            return this.plug.GetStatus();
        }
    }
}
