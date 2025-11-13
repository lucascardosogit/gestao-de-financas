using gestao_de_financas.Model;
using gestao_de_financas.Observadores;
using gestao_de_financas.Subjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestao_de_financas
{
    public partial class EntradaForm : Form
    {
        EntradaSubject entradaSubject = new EntradaSubject();

        public EntradaForm()
        {
            InitializeComponent();

            Observador totalEntradaObservador = new Observador("totalEntradaObservador", entradaSubject);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nome = this.nome.Text;
            double valor = double.Parse(txtValor.Text);
            DateTime data = DateTime.Parse(dtData.Text);

            entradaSubject.setValorEntradas(new EntradaModel("e1", nome, valor, data), "adicionar");

            valorTotalEntrada.Text = entradaSubject.getValorEntradas().ToString();
        }

        private void EntradaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
