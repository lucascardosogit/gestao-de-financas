using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_de_financas.Observadores
{
    class Observador : IObserver
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Observador(string nome, ISubject subject)
        {
            this.Nome = nome;
            subject.RegistrarObservador(this);
        }

        public void Atualizar(double valor)
        {
            this.Valor = valor;
        }
    }
}
