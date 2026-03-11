using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Commun
{
    public interface IObservable<T>
    {
        void AddObserver(IObservateur<T> Observer);
        void RemoveObserver(IObservateur<T> Observer);
        void Notify();
        void Notify(T Action, Object sender);
    }
}
