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
    public class Car : ICarCommand,Interfaces.IObservable<CarInfo>
    {
        public Guid Id;
        public Coordinates Coordinates;
        public Direction Direction;
        public ISurface Surface;
        private Interfaces.IObserver<CarInfo> Observer;

        
        public Car(Coordinates coordinates, Direction direction, ISurface surface)
        {
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

        public void Move()
        {
            if (Direction == Direction.N)
            {
                Coordinates.Y = Coordinates.Y++;
                
            }
            if (Direction == Direction.E)
            {
                Coordinates.X = Coordinates.X++;
            }
            if (Direction == Direction.S)
            {
                Coordinates.Y = Coordinates.Y--;
            }
            if (Direction == Direction.W)
            {
                Coordinates.X = Coordinates.X--;
            }

            Notify();
        }

        public void Notify()
        {
            Observer.Update(new CarInfo(Id,Coordinates));
            
        }

        public void TurnLeft()
        {
           if( Direction == Direction.N)
            {
                Direction = Direction.W;
            }
            if (Direction == Direction.E)
            {
                Direction = Direction.N;
            }
            if (Direction == Direction.S)
            {
                Direction = Direction.E;
            }
            if (Direction == Direction.W)
            {
                Direction = Direction.S;
            }

        }

        public void TurnRight()
        {
            if (Direction == Direction.N)
            {
                Direction = Direction.E;
            }
            if (Direction == Direction.E)
            {
                Direction = Direction.S;
            }
            if (Direction == Direction.S)
            {
                Direction = Direction.W;
            }
            if (Direction == Direction.W)
            {
                Direction = Direction.N;
            }
        }
    }
}
