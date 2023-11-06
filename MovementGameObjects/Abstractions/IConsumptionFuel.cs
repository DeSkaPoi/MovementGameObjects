using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Abstractions
{
    public interface IConsumptionFuel
    {
        public int Fuel { get; set; }
        public bool TryGetFuel { get; }
        public int ConsumptionFuelPerVelocity { get; }
    }
}
