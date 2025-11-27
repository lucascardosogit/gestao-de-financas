using gestao_de_financas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_de_financas.Controladores
{
    public class Controller
    {
        private EntradaSubject _entradaSubject;

        public Controller(EntradaSubject entradaSubject)
        {
            this._entradaSubject = entradaSubject;
        }

        public void AdicionarEntrada(string descricao, double valor, DateTime data)
        {
            int novoId = _entradaSubject.ObterProximoId();
            RegistroModel novoRegistro = new RegistroModel(novoId, descricao,valor, data);
            _entradaSubject.setValorEntradas(novoRegistro, "adicionar");
        }

        public void RemoverEntradas(List<RegistroModel> entradas)
        {
            foreach (RegistroModel entrada in entradas)
            {
                _entradaSubject.setValorEntradas(entrada, "remover");
            }
        }

        public List<RegistroModel> getListaEntradas()
        {
            return _entradaSubject.entradas;
        }

        public double getValorTotal()
        {
            return _entradaSubject.getValorEntradas();
        }

        public void RegistrarObservador(IObserver observer)
        {
            _entradaSubject.RegistrarObservador(observer);
        }

        public void RemoverObservador(IObserver observer)
        {
            _entradaSubject.RemoverObservador(observer);
        }
    }
}
