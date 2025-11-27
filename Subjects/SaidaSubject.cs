using gestao_de_financas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_de_financas.Subjects
{
    public class SaidaSubject : ISubject
    {
        private List<RegistroModel> saidas = new List<RegistroModel>();
        private List<IObserver> observadores = new List<IObserver>();

        public double valorSaidas { get; set; } = 0;


        public SaidaSubject() {}

        public double getValorSaidas()
        {
            return valorSaidas;
        }

        public void setValorSaidas(RegistroModel saida, string operacao)
        {
            if (operacao.ToLower().Equals("adicionar"))
            {
                valorSaidas += saida.Valor;
                saidas.Add(saida);
            }
            if (operacao.ToLower().Equals("remover"))
            {
                valorSaidas -= saida.Valor;
                saidas.Remove(saida);
            }

            NotificarObservadores();
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
        public void NotificarObservadores()
        {
            //Adicionar arquivo de log para quando um notificador for notificado
            foreach (IObserver observer in observadores)
            {
                observer.Atualizar(valorSaidas);
            }
        }
    }

}
