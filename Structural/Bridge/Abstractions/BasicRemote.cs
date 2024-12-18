using Bridge.Interfaces;

namespace Bridge.Abstractions
{
    internal class BasicRemote : RemoteControl
    {
        public BasicRemote(IDevice device) : base(device)
        {
        }
    }
}
