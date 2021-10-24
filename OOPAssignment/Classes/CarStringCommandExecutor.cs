using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Interfaces;
using OOPAssignment.Structs;

namespace OOPAssignment.Classes
{
    public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
    {
        public CarStringCommandExecutor(ICarCommand carCommand) : base(carCommand)
        {
           
        }



        public string _class => throw new NotImplementedException();

        public void ExecuteCommand(string commandObject)
        {
            if (commandObject.Equals(null)){
                throw new Exception();
            }
            if (commandObject.Equals(string.Empty))
            {
                throw new Exception();
            }




            foreach (char c in commandObject)
            {
                if(c == 'L')
                {
                    carCommand.TurnLeft();
                }
                else if(c == 'R')
                {
                    carCommand.TurnRight();
                }
                else if(c== 'M')
                {
                    MovementFactor movement= new MovementFactor();
                    carCommand.Move(movement);
                }
                else
                {
                    throw new Exception("Wrong character!");
                }
                
            }
           
        }
    }
}
