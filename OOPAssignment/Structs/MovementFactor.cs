using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Structs
{
    public readonly struct MovementFactor
    {
        private readonly int XFactor;
        private readonly int YFactor;

        public MovementFactor(int xFactor, int yFactor)
        {
            XFactor = xFactor;
            YFactor = yFactor;
        }

        public int getXFactor()
        {
            return XFactor;
        }
        public int getYFactor()
        {
            return YFactor;
        }
    }
}
