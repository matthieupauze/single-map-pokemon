using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Commun
{
    public interface IObservateur<T>
    {
        void MettreAJour();
        void MettreAJour(T Action, Object sender);
    }
}
