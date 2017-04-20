using Assignment_OkuhleNgada.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OkuhleNgada.Observers
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}
