using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_de_financas.Model
{
    public class EntradaModel
    {
        public string Id { get; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        public EntradaModel(string id, string nome, double valor, DateTime data)
        {
            this.Id = id;
            this.Nome = nome;
            this.Valor = valor;
            this.Data = data;
        }
    }
}
