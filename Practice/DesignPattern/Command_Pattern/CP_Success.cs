namespace CP_Success
{
    public interface ICP
    {
        public void Run();
    }
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
    public class HeaterOnCommand : ICP
    {
        private Heater _heater;
        public HeaterOnCommand(Heater heater)
        {
            _heater = heater;
        }

        public void Run()
        {
            _heater.PowerOn();
        }
    }

    public class LampOnCommand : ICP
    {
        private Lamp _lamp;
        public LampOnCommand(Lamp lamp)
        {
            _lamp = lamp;
        }
        public void Run()
        {
            _lamp.PowerOn();
        }
    }

    public class OKGoogle
    {
        private ICP _icp;
        public void SetIcp(ICP icp)
        {
            _icp = icp;
        }
        public void Talk()
        {
            _icp.Run();
        }
    }

    public class CP_Success
    {
        public static void Main()
        {
            Heater heater = new Heater();
            Lamp lamp = new Lamp();

            ICP h_icp = new HeaterOnCommand(heater);
            ICP l_icp = new LampOnCommand(lamp);
            OKGoogle oKGoogle = new OKGoogle();

            oKGoogle.SetIcp(h_icp);
            oKGoogle.Talk();

            oKGoogle.SetIcp(l_icp);
            oKGoogle.Talk();
        }
    }
}

