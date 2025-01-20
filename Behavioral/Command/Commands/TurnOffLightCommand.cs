using Command.Interfaces;
using Command.Models;

namespace Command.Commands
{
    public class TurnOffLightCommand(Light light)
        : ICommand
    {
        private readonly Light _light = light;
        private bool _executed;

        public void Execute()
        {
            _light.TurnOff();
            _executed = true;
        }

        public void Undo()
        {
            if (_executed)
            {
                _light.TurnOn();
                _executed = false;
            }
        }
    }
}

