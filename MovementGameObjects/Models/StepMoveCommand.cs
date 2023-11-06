using MovementGameObjects.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Models
{
    public class StepMoveCommand : Move
    {
        public StepMoveCommand(IMovable movable) : base(movable)
        {
        }

        public override void CancelExecute()
        {
            throw new NotImplementedException();
        }

        public override void Execute()
        {
            var position = _movable.GetPosition;
            var velocity = _movable.GetVelocity;

            var step = SumPoint(position, velocity);

            _movable.SetPosition = step;
        }

        private Point SumPoint(Point position, Point velocity)
        {
            var x = position.X + velocity.X;
            var y = position.Y + velocity.Y;
            return new Point(x, y);
        }
    }
}
