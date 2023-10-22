using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Abstractions
{
    public interface IMovable
    {
        public Point GetPosition { get; }
        public Point GetVelocity { get; }
        public Point SetPosition { set; }
    }
}
