using Command.Interfaces;
using Command.Models;

namespace Command.Commands
{
    public class TurnOnLightCommand(Light light)
        : ICommand
    {
        private readonly Light _light = light;
        private bool _executed;

        public void Execute()
        {
            _light.TurnOn();
            _executed = true;
        }

        public void Undo()
        {
            if (_executed)
            {
                _light.TurnOff();
                _executed = false;
            }
        }
    }
}
