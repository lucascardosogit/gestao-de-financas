using gestao_de_financas.Observadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_de_financas
{
    public class RegistroModel
    {
        public int Id { get; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        public RegistroModel(int id, string descricao, double valor, DateTime data)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Valor = valor;
            this.Data = data;
        }
    }
}
