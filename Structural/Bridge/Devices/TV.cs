using Bridge.Interfaces;

namespace Bridge.Devices
{
    internal class TV : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("Turning off TV.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on TV.");
        }
    }
}
