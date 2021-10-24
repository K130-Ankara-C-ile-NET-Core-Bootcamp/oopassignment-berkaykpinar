using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Interfaces;

namespace OOPAssignment.Classes
{
    public class CarCommandExecutorBase
    {
        protected readonly ICarCommand carCommand;

        public CarCommandExecutorBase(ICarCommand carCommand)
        {
            this.carCommand = carCommand;
        }
    }
}
