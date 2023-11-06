using MovementGameObjects.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Abstractions
{
    public abstract class Rotate : ICommand
    {
        protected readonly IRotatable _rotatable;
        protected Rotate(IRotatable rotatable) => _rotatable = rotatable;

        public abstract void CancelExecute();

        public abstract void Execute();
    }
}
