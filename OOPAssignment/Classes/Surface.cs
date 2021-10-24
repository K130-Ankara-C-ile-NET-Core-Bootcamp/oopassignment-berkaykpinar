using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Interfaces;
using OOPAssignment.Structs;

namespace OOPAssignment.Classes
{
    public class Surface : ISurface, ICollidableSurface, Interfaces.IObserver<CarInfo>
    {

        public long Width { get; set; }

        public long Height { get; set; }
        private List<CarInfo> ObservableCars = new List<CarInfo>();


        public Surface(long width, long height)
        {
            this.Width = width;
            this.Height = height;
        }


        public List<CarInfo> GetObservables()
        {
            return ObservableCars;
        }

        public bool IsCoordinatesInBounds(Coordinates coordinates)
        {
            if (coordinates.X >= 0 && coordinates.X <= Width && coordinates.Y >= 0 && coordinates.Y <= Height)
            {
                return true;

            }
            else
                return false;

        }

        public bool IsCoordinatesEmpty(Coordinates coordinates)
        {
            var car = ObservableCars.Find(value => (value.GetCoordinates().X == coordinates.X
            && value.GetCoordinates().Y == coordinates.Y));

            foreach(var  carItem in ObservableCars)
            {
                Console.WriteLine("X : "+carItem.GetCoordinates().X+" Y "+ carItem.GetCoordinates().Y);
               
            }

            if (car == null)
            {
                return true;
            }
            else
                return false;
        }

        public void Update(CarInfo provider)
        {
            var car = ObservableCars.Find(value => value.GetGuid() == provider.GetGuid());

            if (car == null)
            {
                ObservableCars.Add(provider);
            }
            else
            {
               
                if (IsCoordinatesEmpty(provider.GetCoordinates())==false)
                {
                    throw new Exception("The coordinates are not Empty!");
                }
                if (IsCoordinatesInBounds(provider.GetCoordinates())==false)
                {
                    throw new Exception("The coordinates are not in Bounds!");
                }
            }


        }


    }
}
