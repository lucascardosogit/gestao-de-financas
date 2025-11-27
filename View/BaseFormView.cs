using gestao_de_financas.Controladores;
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
	public partial class BaseFormView : Form
	{
        private EntradaSubject entradaSubject;
        private Controller controller;
        readonly Observador totalEntradaObservador;

        // Funções da página home
        public BaseFormView()
		{
            InitializeComponent();
            entradaSubject = new EntradaSubject();
            controller = new Controller(entradaSubject);
            totalEntradaObservador = new Observador(valorTotalEntradas, entradaSubject);

            valorTotalEntradas.Text = "R$ 0,00";
        }

        private void TelaNovaEntrada_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponentNovaEntrada();
            RenderizarTabela(controller.getListaEntradas());
        }

        // Funções da tela de cadastros de Entradas
        private void CadastrarEntrada_Click(object sender, EventArgs e)
        {
            string descricao = this.txtDescricao.Text;
            double valor = double.Parse(txtValor.Text);
            DateTime data = dtData.Value.Date;

            controller.AdicionarEntrada(descricao, valor, data);
            RenderizarTabela(controller.getListaEntradas());
            LimparCampos();
        }

        private void ExcluirEntradas_Click(object sender, EventArgs e)
        {
            List<RegistroModel> itensParaRemover = new List<RegistroModel>();

            foreach (DataGridViewRow linha in tabelaDeEntradas.Rows)
            {
                if (Convert.ToBoolean(linha.Cells["Selecionar"].Value))
                {
                    itensParaRemover.Add(linha.DataBoundItem as RegistroModel);
                }
            }

            if(itensParaRemover.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos 1 registro para exclusão!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {

                controller.RemoverEntradas(itensParaRemover);
                RenderizarTabela(controller.getListaEntradas());
            }
        }

        private void VoltarHome_Click(object sender, EventArgs e)
        {
            tabelaDeEntradas.DataSource = new List<RegistroModel>();
            this.Controls.Clear();
            InitializeComponent();
            valorTotalEntradas.Text = controller.getValorTotal().ToString("C2");
        }

        private void RenderizarTabela(List<RegistroModel> lista)
        {
            tabelaDeEntradas.DataSource = new List<RegistroModel>();
            tabelaDeEntradas.Columns.Clear();

            DataGridViewCheckBoxColumn colunaSelecionarItem = new DataGridViewCheckBoxColumn(false);
            colunaSelecionarItem.HeaderText = "[X]";
            colunaSelecionarItem.Name = "Selecionar";
            colunaSelecionarItem.Width = 40;
            colunaSelecionarItem.ReadOnly = false;
            tabelaDeEntradas.Columns.Add(colunaSelecionarItem);

            DataGridViewTextBoxColumn colunaID = new DataGridViewTextBoxColumn();
            colunaID.DataPropertyName = "Id";
            colunaID.Name = "Id";
            colunaID.HeaderText = "ID";
            colunaID.Width = 50;
            colunaID.ReadOnly = false;
            tabelaDeEntradas.Columns.Add(colunaID);

            DataGridViewTextBoxColumn colunaDescricao = new DataGridViewTextBoxColumn();
            colunaDescricao.DataPropertyName = "Descricao";
            colunaDescricao.HeaderText = "Descrição";
            colunaDescricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tabelaDeEntradas.Columns.Add(colunaDescricao);

            DataGridViewTextBoxColumn colunaValor = new DataGridViewTextBoxColumn();
            colunaValor.DataPropertyName = "Valor";
            colunaValor.HeaderText = "Valor";
            colunaValor.DefaultCellStyle.Format = "C2";
            colunaValor.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("pt-BR");
            tabelaDeEntradas.Columns.Add(colunaValor);

            DataGridViewTextBoxColumn colunaData = new DataGridViewTextBoxColumn();
            colunaData.DataPropertyName = "Data";
            colunaData.HeaderText = "Data";
            colunaData.DefaultCellStyle.Format = "dd/MM/yyyy";
            tabelaDeEntradas.Columns.Add(colunaData);

            tabelaDeEntradas.DataSource = lista;
            tabelaDeEntradas.ClearSelection();
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtValor.Clear();
            dtData.Value = DateTime.Now;
            txtDescricao.Focus();
        }
    }
}
