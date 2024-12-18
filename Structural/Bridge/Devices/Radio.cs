using Bridge.Interfaces;

namespace Bridge.Devices
{
    internal class Radio : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("Turning off radio.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on radio.");
        }
    }
}
