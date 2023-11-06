using MovementGameObjects.Command;
using MovementGameObjects.Models;
using System.Drawing;

namespace UnitTests
{
    public class TestCommand
    {
        [Fact]
        public void Test1()
        {
            StarShip starShip = new StarShip(new Point(12, 5), new Point(12, 5), new object(), 10, 1, new Point(-1, 1));
            ICommand command = new CheckFuelComamnd(starShip);

            try
            {
                command.Execute();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Fact]
        public void Test2()
        {
            StarShip starShip = new StarShip(new Point(12, 5), new Point(12, 5), new object(), 10, 1, new Point(-1, 1));
            ICommand command = new BurnFuelCommand(starShip);

            var fuelBeforeSpend = starShip.TryGetFuel;

            command.Execute();

            var fuelAfterSpend = starShip.TryGetFuel;

            Assert.Equal(fuelBeforeSpend, fuelAfterSpend);
        }

        [Fact]
        public void Test3()
        {
            StarShip starShip = new StarShip(new Point(12, 5), new Point(-7, 3), new object(), 100, 10, new Point(-1, 1));
            ICommand command = new CheckFuelComamnd(starShip);
            ICommand command2 = new StepMoveCommand(starShip);
            ICommand command3 = new BurnFuelCommand(starShip);

            Queue<ICommand> commands = new Queue<ICommand>();
            commands.Enqueue(command);
            commands.Enqueue(command2);
            commands.Enqueue(command3);

            try
            {
                ICommand macroCommand = new MacroCommand(commands);
                macroCommand.Execute();
            }
            catch
            {
                Assert.Fail("");
                return;
            }

            var point = starShip.GetPosition;

            Assert.Equal(new Point(5, 8), point);
        }

        [Fact]
        public void Test4()
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
                Assert.Fail("");
                return;
            }

            var point = starShip.GetVelocity;

            Assert.Equal(new Point(-6, 2), point);
        }
    }
}