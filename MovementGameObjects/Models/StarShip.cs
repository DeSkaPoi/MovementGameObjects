using MovementGameObjects.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Models
{
    public class StarShip : IMovableStarship, IRotatableStarship
    {
        private Point _position;
        private Point _velocity;
        private object _direction;
        public StarShip(Point position, Point velocity, object direction)
        {
            _position = position;
            _velocity = velocity;
            _direction = direction;
        }

        public Point GetPosition 
        {
            get { return _position != Point.Empty ? _position : throw new Exception("невозможно прочитать положение в пространстве"); }
        }

        public Point GetVelocity
        {
            get { return _velocity != Point.Empty ? _velocity : throw new Exception("невозможно прочитать значение мгновенной скорости"); }
        }

        public Point SetPosition { 
            set 
            {
                if (value != Point.Empty)
                    _position = value;
                else
                    throw new Exception("Неверный формат ввода данных");
            }
        }

        public object GetDirection
        {
            get { return _direction != null ? _direction : throw new Exception("невозможно прочитать значение мгновенной скорости"); }
        }

        public object SetDirection 
        {
            set
            {
                if (value != null)
                    _direction = value;
                else
                    throw new Exception("Неверный формат ввода данных");
            }
        }
    }
}
