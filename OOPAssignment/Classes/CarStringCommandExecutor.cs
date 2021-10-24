using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Interfaces;
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
            foreach(char c in commandObject)
            {
                if(c == 'L')
                {
                    carCommand.TurnLeft();
                }
                if(c == 'R')
                {
                    carCommand.TurnRight();
                }
                if(c== 'M')
                {
                    carCommand.Move();
                }
            }
           
        }
    }
}
