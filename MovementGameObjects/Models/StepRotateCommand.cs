using MovementGameObjects.Abstractions;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MovementGameObjects.Models
{
    public class StepRotateCommand : Rotate
    {
        public StepRotateCommand(IRotatable rotatable) : base(rotatable)
        {
            
        }

        public override void CancelExecute()
        {
        }

        public override void Execute()
        {
            var direction = _rotatable.GetDirection;

            //поворот фигуры в сторону направления движения

            _rotatable.SetDirection = new object();
        }
    }
}
