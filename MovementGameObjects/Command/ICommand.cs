using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Command
{
    public interface ICommand
    {
        void Execute();
        void CancelExecute();
    }
}
