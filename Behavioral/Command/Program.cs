using Command;
using Command.Commands;
using Command.Models;

var light = new Light();

var turnOnCommand = new TurnOnLightCommand(light);
var turnOffCommand = new TurnOffLightCommand(light);

var commandController = new CommandController();

commandController.ExecuteCommand(turnOnCommand);
commandController.ExecuteCommand(turnOffCommand);
commandController.ExecuteCommand(turnOnCommand);
commandController.UndoCommand();
