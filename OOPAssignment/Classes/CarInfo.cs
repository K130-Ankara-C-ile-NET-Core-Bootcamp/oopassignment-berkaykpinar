using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Structs;
namespace OOPAssignment.Classes
{
    public class CarInfo
    {

        public Guid carId;
        public Coordinates coordinates;

        public CarInfo(Guid carId, Coordinates coordinates)
        {
            this.carId = carId;
            this.coordinates = coordinates;
        }

        public Guid GetGuid()
        {
            return carId;
        }

        public Coordinates GetCoordinates()
        {
            return coordinates;
        }

       public void SetCoordinates(long x,long y)
        {
            coordinates.X = x;
            coordinates.Y = y;
        }
    }
}
