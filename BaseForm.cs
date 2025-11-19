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
        Observador totalEntradaObservador;


        // Funções da página home
        public BaseForm()
		{
            totalEntradaObservador = new Observador("totalEntradaObservador", entradaSubject);
            InitializeBaseComponent();

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            //if(entradaSubject.entradas.Count > 0 && tabelaDeEntradas != null)
            //{
            //    tabelaDeEntradas.DataSource = entradaSubject.entradas;
            //} else
            //{
            //    AtualizarTabelaEntradas();
            //}
        }

        private void TelaNovaEntrada_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponentNovaEntrada();
            RenderizarTabela(entradaSubject.entradas);

        }

        // Funções da tela de cadastros de Entradas
        private void CadastrarEntrada_Click(object sender, EventArgs e)
        {
            string nome = this.txtDescricao.Text;
            double valor = double.Parse(txtValor.Text);
            DateTime data = dtData.Value.Date;

            entradaSubject.setValorEntradas(new RegistroModel(entradaSubject.ObterProximoId(), nome, valor, data), "adicionar");

            //AtualizarTabelaEntradas();
            RenderizarTabela(entradaSubject.entradas);
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

                foreach (RegistroModel registro in itensParaRemover)
                {
                    entradaSubject.setValorEntradas(registro, "remover");
                }

                RenderizarTabela(entradaSubject.entradas);
            }
        }

        private void VoltarHome_Click(object sender, EventArgs e)
        {
            tabelaDeEntradas.DataSource = null;
            this.Controls.Clear();
            InitializeBaseComponent();
        }

        private void InicializarColunasTabela()
        {
            //DataTable tabela = new DataTable();
            //if (tabelaDeEntradas.Columns.Count > 0)
            //{
            //    tabela.Columns.Add("[X]", typeof(DataGridViewCheckBoxColumn));

            //    DataGridViewCheckBoxColumn colunaSelecionarItem = new DataGridViewCheckBoxColumn();
            //    colunaSelecionarItem.HeaderText = "[X]";
            //    colunaSelecionarItem.Name = "Selecionar";
            //    colunaSelecionarItem.Width = 40;
            //    colunaSelecionarItem.ReadOnly = false;
            //    tabelaDeEntradas.Columns.Insert(0, colunaSelecionarItem);

            //    tabelaDeEntradas.Columns["Id"].HeaderText = "ID";
            //    tabelaDeEntradas.Columns["Id"].Width = 50;

            //    tabelaDeEntradas.Columns["Descricao"].HeaderText = "Descrição";
            //    tabelaDeEntradas.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            //    tabelaDeEntradas.Columns["Valor"].HeaderText = "Valor";
            //    tabelaDeEntradas.Columns["Data"].HeaderText = "Data";

            //    tabelaDeEntradas.Columns["Valor"].DefaultCellStyle.Format = "C2";
            //    tabelaDeEntradas.Columns["Valor"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("pt-BR");

            //    tabelaDeEntradas.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //}
        }

        private void RenderizarTabela(List<RegistroModel> lista)
        {
            tabelaDeEntradas.DataSource = null;
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
            colunaSelecionarItem.ReadOnly = false;
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

            //InicializarColunasTabela();
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtValor.Clear();
            dtData.Value = DateTime.Now;
            txtDescricao.Focus();
        }

        private void InitializeComponent()
        {
            this.excluirEntradas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // excluirEntradas
            // 
            this.excluirEntradas.Location = new System.Drawing.Point(161, 100);
            this.excluirEntradas.Name = "excluirEntradas";
            this.excluirEntradas.Size = new System.Drawing.Size(75, 23);
            this.excluirEntradas.TabIndex = 0;
            this.excluirEntradas.Text = "Excluir Entradas";
            this.excluirEntradas.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.excluirEntradas);
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }
    }
}
