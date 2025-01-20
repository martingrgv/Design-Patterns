using Command.Interfaces;

namespace Command
{
    public class CommandController
    {
        private Stack<ICommand> _commandsHistory = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandsHistory.Push(command);
        }

        public void UndoCommand()
        {
            if (_commandsHistory.Count == 0)
            {
                return;
            }

            var lastCommand = _commandsHistory.Pop();

            Console.WriteLine($"Undo last command: {lastCommand.GetType().Name}");
            lastCommand.Undo();
        }
    }
}
