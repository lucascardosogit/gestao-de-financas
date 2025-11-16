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
            InitializeBaseComponent();

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            tabelaDeEntradas.DataSource = entradaSubject.entradas;
        }

        private void TelaNovaEntrada_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponentNovaEntrada();


            Observador totalEntradaObservador = new Observador("totalEntradaObservador", entradaSubject);
        }

        private void CadastrarEntrada_Click(object sender, EventArgs e)
        {
            string nome = this.nome.Text;
            double valor = double.Parse(txtValor.Text);
            DateTime data = dtData.Value;

            entradaSubject.setValorEntradas(new EntradaModel(DeclaradorId(), nome, valor, data), "adicionar");

            AtualizarTabelaEntradas();
        }

        private string DeclaradorId()
        {
            if(entradaSubject.entradas.Count == 0)
            {
                return "e1";
            } else
            {
                return $"e{entradaSubject.entradas.Count}";
            }
        }

        private void FormatarColunasTabela()
        {
            if (tabelaDeEntradas.Columns.Count > 0)
            {
                tabelaDeEntradas.Columns["Id"].HeaderText = "ID";
                tabelaDeEntradas.Columns["Nome"].HeaderText = "Descrição";
                tabelaDeEntradas.Columns["Valor"].HeaderText = "Valor";
                tabelaDeEntradas.Columns["Data"].HeaderText = "Data";
                tabelaDeEntradas.Columns["Valor"].DefaultCellStyle.Format = "C2";
                tabelaDeEntradas.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void AtualizarTabelaEntradas()
        {
            tabelaDeEntradas.DataSource = null;
            tabelaDeEntradas.DataSource = entradaSubject.entradas;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtValor.Clear();
            dtData.Value = DateTime.Now;
            txtNome.Focus();
        }
    }
}
