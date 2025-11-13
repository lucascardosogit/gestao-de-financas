using gestao_de_financas.Model;
using gestao_de_financas.Observadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gestao_de_financas
{
	public partial class BaseForm : Form
	{
        EntradaSubject entradaSubject = new EntradaSubject();

		public BaseForm()
		{
			InitializeComponent();
		}

        private void telaNovaEntrada_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponentNovaEntrada();


            Observador totalEntradaObservador = new Observador("totalEntradaObservador", entradaSubject);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nome = this.nome.Text;
            double valor = double.Parse(txtValor.Text);
            DateTime data = DateTime.Parse(dtData.Text);

            //leonardo e lucas

            entradaSubject.setValorEntradas(new EntradaModel("e1", nome, valor, data), "adicionar");

            //valorTotalEntrada.Text = entradaSubject.getValorEntradas().ToString();
        }
    }
}
