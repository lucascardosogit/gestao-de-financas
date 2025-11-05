using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_de_financas
{
    interface ISubject
    {
        void RegistrarObservador(IObserver observer);
        void RemoverObservador(IObserver observer);
        void NotificarObservador();
    }
}
