namespace gestao_de_financas
{
    partial class BaseFormView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.telaNovaEntrada = new System.Windows.Forms.Button();
            this.telaNovaSaida = new System.Windows.Forms.Button();
            this.valorTotalEntradas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // telaNovaEntrada
            // 
            this.telaNovaEntrada.Location = new System.Drawing.Point(72, 75);
            this.telaNovaEntrada.Name = "telaNovaEntrada";
            this.telaNovaEntrada.Size = new System.Drawing.Size(234, 74);
            this.telaNovaEntrada.TabIndex = 0;
            this.telaNovaEntrada.Text = "Registrar Nova Entrada";
            this.telaNovaEntrada.UseVisualStyleBackColor = true;
            this.telaNovaEntrada.Click += new System.EventHandler(this.TelaNovaEntrada_Click);
            // 
            // telaNovaSaida
            // 
            this.telaNovaSaida.Location = new System.Drawing.Point(72, 175);
            this.telaNovaSaida.Name = "telaNovaSaida";
            this.telaNovaSaida.Size = new System.Drawing.Size(234, 74);
            this.telaNovaSaida.TabIndex = 1;
            this.telaNovaSaida.Text = "Registrar Nova Saída";
            this.telaNovaSaida.UseVisualStyleBackColor = true;
            // 
            // valorTotalEntradas
            // 
            this.valorTotalEntradas.AutoSize = true;
            this.valorTotalEntradas.Location = new System.Drawing.Point(633, 95);
            this.valorTotalEntradas.Name = "valorTotalEntradas";
            this.valorTotalEntradas.Size = new System.Drawing.Size(13, 13);
            this.valorTotalEntradas.TabIndex = 2;
            this.valorTotalEntradas.Text = "0";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.valorTotalEntradas);
            this.Controls.Add(this.telaNovaSaida);
            this.Controls.Add(this.telaNovaEntrada);
            this.Name = "BaseForm";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComponentNovaEntrada()
        {
            this.descricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.entradas = new System.Windows.Forms.Label();
            this.cadastrarEntrada = new System.Windows.Forms.Button();
            this.excluirEntradas = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.tabelaDeEntradas = new System.Windows.Forms.DataGridView();
            this.voltarHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDeEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(38, 70);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(58, 13);
            this.descricao.TabIndex = 8;
            this.descricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(41, 86);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(266, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // entradas
            // 
            this.entradas.Location = new System.Drawing.Point(650, 50);
            this.entradas.Name = "entradas";
            this.entradas.Size = new System.Drawing.Size(50, 20);
            this.entradas.TabIndex = 9;
            this.entradas.Text = "Entradas";
            // 
            // cadastrarEntrada
            // 
            this.cadastrarEntrada.Location = new System.Drawing.Point(41, 240);
            this.cadastrarEntrada.Name = "cadastrarEntrada";
            this.cadastrarEntrada.Size = new System.Drawing.Size(266, 60);
            this.cadastrarEntrada.TabIndex = 4;
            this.cadastrarEntrada.Text = "Cadastrar";
            this.cadastrarEntrada.Click += new System.EventHandler(this.CadastrarEntrada_Click);
            // 
            // excluirEntradas
            // 
            this.excluirEntradas.Location = new System.Drawing.Point(41, 360);
            this.excluirEntradas.Name = "excluirEntradas";
            this.excluirEntradas.Size = new System.Drawing.Size(266, 60);
            this.excluirEntradas.TabIndex = 5;
            this.excluirEntradas.Text = "Excluir Entradas";
            this.excluirEntradas.Click += new System.EventHandler(this.ExcluirEntradas_Click);
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(38, 125);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(34, 13);
            this.valor.TabIndex = 7;
            this.valor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(41, 141);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(266, 20);
            this.txtValor.TabIndex = 2;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(38, 180);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(33, 13);
            this.data.TabIndex = 6;
            this.data.Text = "Data:";
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(41, 196);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(266, 20);
            this.dtData.TabIndex = 3;
            // 
            // tabelaDeEntradas
            // 
            this.tabelaDeEntradas.AllowUserToAddRows = false;
            this.tabelaDeEntradas.AllowUserToDeleteRows = false;
            this.tabelaDeEntradas.AllowUserToOrderColumns = true;
            this.tabelaDeEntradas.AllowUserToResizeRows = false;
            this.tabelaDeEntradas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.tabelaDeEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaDeEntradas.Location = new System.Drawing.Point(350, 70);
            this.tabelaDeEntradas.MultiSelect = false;
            this.tabelaDeEntradas.Name = "tabelaDeEntradas";
            this.tabelaDeEntradas.Size = new System.Drawing.Size(650, 350);
            this.tabelaDeEntradas.TabIndex = 0;
            // 
            // voltarHome
            // 
            this.voltarHome.Location = new System.Drawing.Point(20, 20);
            this.voltarHome.Name = "voltarHome";
            this.voltarHome.Size = new System.Drawing.Size(80, 30);
            this.voltarHome.TabIndex = 0;
            this.voltarHome.Text = "Voltar";
            this.voltarHome.UseVisualStyleBackColor = true;
            this.voltarHome.Click += new System.EventHandler(this.VoltarHome_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.tabelaDeEntradas);
            this.Controls.Add(this.cadastrarEntrada);
            this.Controls.Add(this.excluirEntradas);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.entradas);
            this.Controls.Add(this.voltarHome);
            this.Name = "BaseForm";
            this.Text = "Nova Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDeEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button telaNovaEntrada;
        private System.Windows.Forms.Button telaNovaSaida;

        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label entradas;
        private System.Windows.Forms.Button cadastrarEntrada;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button voltarHome;
        private System.Windows.Forms.DataGridView tabelaDeEntradas;
        private System.Windows.Forms.Button excluirEntradas;
        private System.Windows.Forms.Label valorTotalEntradas;
    }
}
