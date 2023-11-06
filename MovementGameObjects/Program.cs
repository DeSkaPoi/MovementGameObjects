using MovementGameObjects.Command;
using MovementGameObjects.Models;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {

        StarShip starShip = new StarShip(new Point(12, 5), new Point(-7, 3), new object(), 100, 10, new Point(1, 1));

        ICommand command = new StepRotateCommand(starShip);
        ICommand command2 = new ChangeVelocityCommand(starShip);

        Queue<ICommand> commands = new Queue<ICommand>();
        commands.Enqueue(command);
        commands.Enqueue(command2);

        try
        {
            ICommand macroCommand = new MacroCommand(commands);
            macroCommand.Execute();
        }
        catch
        {
            return;
        }

        var point = starShip.GetVelocity;
    }
}