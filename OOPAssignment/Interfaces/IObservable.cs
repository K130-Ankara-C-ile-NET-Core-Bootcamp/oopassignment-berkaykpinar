using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Interfaces
{
    public interface IObservable<T>
    {
        //T Class { get; }
        void Attach(IObserver<T> observer);
        void Notify();
    }
}
