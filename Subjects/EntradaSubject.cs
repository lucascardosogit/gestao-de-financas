using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace gestao_de_financas.Model
{
    public class EntradaSubject : ISubject
    {
        public List<RegistroModel> entradas = new List<RegistroModel>();
        private List<IObserver> observadores = new List<IObserver>();
        private int proximoId = 0;

        public double valorEntradas { get; set; } = 0;

        public EntradaSubject() {}

        public int ObterProximoId()
        {
            proximoId++;
            return proximoId;
        }

        public double getValorEntradas()
        {
            return valorEntradas;
        }

        public void setValorEntradas(RegistroModel entrada, string operacao)
        {
            if(operacao.ToLower().Equals("adicionar"))
            {
                valorEntradas += entrada.Valor;
                entradas.Add(entrada);
            }
            if (operacao.ToLower().Equals("remover"))
            {
                valorEntradas -= entrada.Valor;
                entradas.Remove(entrada);
            }
                
            NotificarObservadores();
        }

        public void RegistrarObservador(IObserver observer)
        {
            observadores.Add(observer);
        }

        public void RemoverObservador(IObserver observer)
        {
            observadores.Remove(observer);
        }
        public void NotificarObservadores()
        {
            foreach (IObserver observer in observadores)
            {
                observer.Atualizar(valorEntradas);
            }
        }
    }
}
