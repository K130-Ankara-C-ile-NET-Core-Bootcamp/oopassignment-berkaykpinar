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

        private Guid carId;
        private Coordinates coordinates;

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
    }
}
