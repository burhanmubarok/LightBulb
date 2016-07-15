namespace LightBulb
{
    class ProgramWithInterface
    {

    }

    public interface ISwitch
    {
        string TurnOn { get; }
        string TurnOff { get; }
    }

    public class Fan : ISwitch
    {
        public string TurnOn
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public string TurnOff
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }

    public class LightBulb : ISwitch
    {
        public string TurnOn
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public string TurnOff
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
