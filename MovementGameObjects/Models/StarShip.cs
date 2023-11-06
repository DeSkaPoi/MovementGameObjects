using MovementGameObjects.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Models
{
    public class StarShip : IMovableStarship, IRotatableStarship, IConsumptionFuel, IConsumptionVelocity
    {
        private Point _position;
        private Point _velocity;
        private Point _velocityAfterRotate;
        private object _direction;
        private int _fuelInLiters;
        private readonly int _consumptionFuelPerVelocity;
        public StarShip(Point position, Point velocity, object direction, int fuelInLiters, int consumptionFuelPerVelocity, Point velocityAfterRotate)
        {
            _position = position;
            _velocity = velocity;
            _direction = direction;
            _fuelInLiters = fuelInLiters;
            _consumptionFuelPerVelocity = consumptionFuelPerVelocity;
            _velocityAfterRotate = velocityAfterRotate;
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

        public bool TryGetFuel => _fuelInLiters <= 0 ? false : true;

        public int ConsumptionFuelPerVelocity => _consumptionFuelPerVelocity;

        public int Fuel { get => _fuelInLiters; set => _fuelInLiters = value; }
        public Point Velocity { get => _velocity; set => _velocity = value; }

        public Point VelocityAfterRotate => _velocityAfterRotate;
    }
}
