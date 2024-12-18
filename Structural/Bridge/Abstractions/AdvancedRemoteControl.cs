using Bridge.Interfaces;

namespace Bridge.Abstractions
{
    internal class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume set to {volume} on device {device.GetType()}.");
        }

        public void Mute()
        {
            Console.WriteLine($"Muting device {device.GetType()}.");
        }
    }
}
