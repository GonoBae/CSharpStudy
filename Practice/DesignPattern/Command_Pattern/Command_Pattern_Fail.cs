using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DesignPattern.Command_Pattern_Fail
{
    public class Heater
    {
        public void PowerOn()
        {
            Console.WriteLine("Heater On");
        }
    }

    public class Lamp
    {
        public void PowerOn()
        {
            Console.WriteLine("Lamp On");
        }
    }

    public class OKGoogle
    {
        private Heater heater;
        private Lamp lamp;
        private int mode;

        public OKGoogle(Heater heater, Lamp lamp)
        {
            this.heater = heater;
            this.lamp = lamp;
        }

        public void SetMode(int idx)
        {
            mode = idx;
        }

        public void Talk()
        {
            switch(mode)
            {
                case 0:
                    heater.PowerOn();
                    break;
                case 1:
                    lamp.PowerOn();
                    break;
                case 2:
                    heater.PowerOn();
                    lamp.PowerOn();
                    break;
            }
        }
    }

    class Command_Pattern_Fail
    {
        public static void Main1()
        {
            Heater heater = new Heater();
            Lamp lamp = new Lamp();
            OKGoogle oKGoogle = new OKGoogle(heater, lamp);

            Console.WriteLine("Heater Mode");
            oKGoogle.SetMode(0);
            oKGoogle.Talk();
            Console.WriteLine("Lamp Mode");
            oKGoogle.SetMode(1);
            oKGoogle.Talk();
            Console.WriteLine("All Mode");
            oKGoogle.SetMode(2);
            oKGoogle.Talk();
        }
    }
}
