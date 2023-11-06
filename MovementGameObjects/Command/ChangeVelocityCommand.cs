using MovementGameObjects.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Command
{
    public class ChangeVelocityCommand : ICommand
    {
        private readonly IConsumptionVelocity _starShip;

        public ChangeVelocityCommand(IConsumptionVelocity starShip)
        {
            _starShip = starShip;
        }
        public void CancelExecute()
        {
        }

        public void Execute()
        {
            _starShip.Velocity = SumPoint(_starShip.Velocity, _starShip.VelocityAfterRotate);
        }

        private Point SumPoint(Point position, Point velocity)
        {
            
            var x = Math.Abs(position.X) - velocity.X;
            var y = Math.Abs(position.Y) - velocity.Y;

            if (position.X < 0)
                x *= -1;
            if (position.Y < 0)
                y *= -1;

            return new Point(x, y);
        }
    }
}
