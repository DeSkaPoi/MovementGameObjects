using MovementGameObjects.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Models
{
    public class StepMove : Move
    {
        public StepMove(IMovable movable) : base(movable)
        {
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
