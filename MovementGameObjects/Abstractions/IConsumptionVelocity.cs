using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Abstractions
{
    public interface IConsumptionVelocity
    {
        public Point Velocity { get; set; }
        public Point VelocityAfterRotate { get; }
    }
}
