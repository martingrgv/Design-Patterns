using Bridge.Interfaces;

namespace Bridge.Abstractions
{
    internal abstract class RemoteControl
    {
        protected IDevice device; // Bridge: Composition instead of inheritance

        protected RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public virtual void TurnOff()
        {
            device.TurnOff();
        }

        public virtual void TurnOn()
        {
            device.TurnOn();
        }
    }
}
