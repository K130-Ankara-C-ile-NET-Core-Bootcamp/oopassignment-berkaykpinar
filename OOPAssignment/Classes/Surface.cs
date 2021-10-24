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
            List<CarInfo> newObservable = new List<CarInfo>();

            foreach (CarInfo car in ObservableCars)
            {
                newObservable.Add(car);
            }

            return newObservable;
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
            var car = ObservableCars.FirstOrDefault(value => (value.GetCoordinates().X == coordinates.X
            && value.GetCoordinates().Y == coordinates.Y));

            if (car == null)
            {
                return true;
            }
            else
                return false;
        }

        public void Update(CarInfo provider)
        {
            var car = ObservableCars.FirstOrDefault(value =>
            value.GetGuid() == provider.GetGuid());

       


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
