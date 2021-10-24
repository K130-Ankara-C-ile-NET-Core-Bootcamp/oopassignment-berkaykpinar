using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Interfaces;
using OOPAssignment.Structs;
using OOPAssignment.Enums;
using OOPAssignment.Classes;

namespace OOPAssignment.Classes
{
    public class Car : ICarCommand, Interfaces.IObservable<CarInfo>
    {
        public Guid Id;
        public Coordinates Coordinates;
        public Direction Direction;
        public ISurface Surface;
        private Interfaces.IObserver<CarInfo> Observer;


        public Car(Coordinates coordinates, Direction direction, ISurface surface)
        {
            if(coordinates.Equals(null) || direction.Equals(null)|| surface== null)
            {
                throw new Exception("Some paramaters are null");
            } 

            Coordinates = coordinates;
            Direction = direction;
            Surface = surface;
            Id = new Guid();
        }

        public void Attach(Interfaces.IObserver<CarInfo> observer)
        {
            Observer = observer;
            Notify();
        }

        public void Move(MovementFactor movementFactor)
        {
            movementFactor.XFactor = Coordinates.X;
            movementFactor.YFactor = Coordinates.Y;

            if (Direction == Direction.N)
            {
                movementFactor.YFactor++;

            }
            if (Direction == Direction.E)
            {
                movementFactor.XFactor++;
            }
            if (Direction == Direction.S)
            {
                movementFactor.YFactor--;
            }
            if (Direction == Direction.W)
            {
                movementFactor.XFactor--;
            }

            Coordinates = new Coordinates(movementFactor.XFactor, movementFactor.YFactor);

            Notify();
        }

        public void Notify()
        {
            Observer.Update(new CarInfo(Id, Coordinates));

        }

        public void TurnLeft()
        {
            if (Direction == Direction.N)
            {
                Direction = Direction.W;
            }
            else if (Direction == Direction.E)
            {
                Direction = Direction.N;
            }
            else if (Direction == Direction.S)
            {
                Direction = Direction.E;
            }
            else if (Direction == Direction.W)
            {
                Direction = Direction.S;
            }

            //Notify();
        }

        public void TurnRight()
        {
            if (Direction == Direction.N)
            {
                Direction = Direction.E;
                
            }
            else if (Direction == Direction.E)
            {
                Direction = Direction.S;
            }
            else if (Direction == Direction.S)
            {
                Direction = Direction.W;
            }
            else if (Direction == Direction.W)
            {
                Direction = Direction.N;
            }
            //  Notify();
        }
    }
}
