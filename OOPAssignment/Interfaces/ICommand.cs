using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Interfaces
{
    public interface ICommand<T>
    {
        T _class { get; }
        void ExecuteCommand(T commandObject);
    }
}
