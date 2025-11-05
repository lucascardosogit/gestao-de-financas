using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_de_financas
{
    public interface IObserver
    {
        void Atualizar(double valor);
    }
}
