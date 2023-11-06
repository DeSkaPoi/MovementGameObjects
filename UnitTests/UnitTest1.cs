using MovementGameObjects.Models;
using System.Drawing;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            StarShip starShip = new StarShip(new Point(12, 5), new Point(-7, 3), new object(), 100, 10, new Point(-1, -1));
            StepMoveCommand stepMove = new StepMoveCommand(starShip);
            stepMove.Execute();

            var point = starShip.GetPosition;

            Assert.Equal(new Point(5, 8), point);
        }

        [Fact]
        public void Test2()
        {
            StarShip starShip = new StarShip(new Point(12, 5), Point.Empty, new object(), 100, 10, new Point(-1, -1));
            StepMoveCommand stepMove = new StepMoveCommand(starShip);

            try
            {
                stepMove.Execute();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}