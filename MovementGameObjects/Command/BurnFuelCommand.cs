using MovementGameObjects.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MovementGameObjects.Command
{
    public class BurnFuelCommand : ICommand
    {
        private readonly IConsumptionFuel _starShip;

        public BurnFuelCommand(IConsumptionFuel starShip)
        {
            _starShip = starShip;
        }

        public void CancelExecute()
        {
        }

        public void Execute()
        {
            _starShip.Fuel = _starShip.Fuel - _starShip.ConsumptionFuelPerVelocity;
        }
    }
}
