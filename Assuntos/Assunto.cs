using gestao_de_financas.Observadores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_de_financas.Assuntos
{
    public class Assunto : ISubject
    {
        private List<IObserver> observadores = new List<IObserver>();

        private Financa financaObj;

        public Assunto(int id, string nome, double valor, DateTime data)
        {
            financaObj = new Financa(id, nome, valor, data);
        }

        public double getValor()
        {
            return financaObj.Valor;
        }

        public void setValor(double valor)
        {
            financaObj.Valor = valor;
            Console.WriteLine($"Valor atualizado para: ${financaObj.Valor}");
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
                observer.Atualizar(financaObj.Valor);
            }
        }
    }
}
