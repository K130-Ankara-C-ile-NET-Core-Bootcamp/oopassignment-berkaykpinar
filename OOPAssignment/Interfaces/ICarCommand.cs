using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Structs;

namespace OOPAssignment.Interfaces
{
    public interface ICarCommand
    {
        void TurnLeft();
        void TurnRight();
        void Move(MovementFactor movementFactor);
    }
}
