using MovementGameObjects.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Command
{
    public class CheckFuelComamnd : ICommand
    {
        private readonly IConsumptionFuel _starShip;

        public CheckFuelComamnd(IConsumptionFuel starShip)
        {
            _starShip = starShip;
        }
        
        public void CancelExecute()
        {
            
        }

        public void Execute()
        {
            if (!_starShip.TryGetFuel)
                throw new Exception("Топлива нет");
            if (_starShip.Fuel < _starShip.ConsumptionFuelPerVelocity)
                throw new Exception("Топлива не хватает для перелета");
        }
    }
}
