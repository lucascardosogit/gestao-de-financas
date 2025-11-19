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
        private int proximoId = 1;

        public double valorEntradas { get; set; } = 0;

        public EntradaSubject() {}

        public int ObterProximoId()
        {
            return proximoId++;
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
                
            NotificarObservador();
        }

        public void RegistrarObservador(IObserver observer)
        {
            //Adicionar arquivo de log para quando um notificador for adicionado
            observadores.Add(observer);
        }

        public void RemoverObservador(IObserver observer)
        {
            //Adicionar arquivo de log para quando um notificador for removido
            observadores.Remove(observer);
        }
        public void NotificarObservador()
        {
            //Adicionar arquivo de log para quando um notificador for notificado
            Console.WriteLine("\n\nNotificando todos os Observadores registrados");
            foreach (IObserver observer in observadores)
            {
                observer.Atualizar(valorEntradas);
            }
        }
    }
}
