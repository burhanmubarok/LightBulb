using System;

namespace LightBulb
{
    class Program
    {
        static void Main(string[] args)
        {
            var status = Switch.TurnOn();
            Console.WriteLine(status);
            Console.ReadKey();
        }
    }

    public class Switch
    {
        public static string TurnOn()
        {
            return "Light is turned on";
        }

        public static string TurnOff()
        {
            return "Light is turned off";
        }
    }
}
