using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestao_de_financas.Observadores
{
    class Observador : IObserver
    {
        public double Valor { get; set; }
        public Label Label { get; set; }

        public Observador(Label label, ISubject subject)
        {
            this.Label = label;
            subject.RegistrarObservador(this);
        }

        public void Atualizar(double valor)
        {
            this.Valor = valor;
            Label.Text = Valor.ToString("C2");
        }
    }
}
