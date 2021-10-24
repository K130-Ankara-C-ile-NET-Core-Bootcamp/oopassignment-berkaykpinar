using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Structs
{
    public struct MovementFactor
    {
        public long XFactor {  get; set; }
        public long YFactor { get; set; }
        public MovementFactor(int xFactor, int yFactor)
        {
            XFactor = xFactor;
            YFactor = yFactor;
        }

    }
}
