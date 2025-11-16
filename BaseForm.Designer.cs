namespace gestao_de_financas
{
    partial class BaseForm
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
        private void InitializeBaseComponent()
        {
            this.nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cadastrarEntrada = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.tabelaDeEntradas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDeEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(38, 37);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(38, 13);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(41, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(266, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cadastrarEntrada
            // 
            this.cadastrarEntrada.Location = new System.Drawing.Point(41, 311);
            this.cadastrarEntrada.Name = "cadastrarEntrada";
            this.cadastrarEntrada.Size = new System.Drawing.Size(266, 86);
            this.cadastrarEntrada.TabIndex = 2;
            this.cadastrarEntrada.Text = "Cadastrar";
            this.cadastrarEntrada.UseVisualStyleBackColor = true;
            this.cadastrarEntrada.Click += new System.EventHandler(this.cadastrarEntrada_Click);
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(38, 96);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(34, 13);
            this.valor.TabIndex = 3;
            this.valor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(41, 112);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(266, 20);
            this.txtValor.TabIndex = 4;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(38, 154);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(33, 13);
            this.data.TabIndex = 5;
            this.data.Text = "Data:";
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(41, 171);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(266, 20);
            this.dtData.TabIndex = 6;
            // 
            // tabelaDeEntradas
            // 
            this.tabelaDeEntradas.AllowUserToOrderColumns = true;
            this.tabelaDeEntradas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.tabelaDeEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaDeEntradas.Location = new System.Drawing.Point(353, 37);
            this.tabelaDeEntradas.Name = "tabelaDeEntradas";
            this.tabelaDeEntradas.Size = new System.Drawing.Size(661, 451);
            this.tabelaDeEntradas.TabIndex = 7;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 533);
            this.Controls.Add(this.tabelaDeEntradas);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.cadastrarEntrada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nome);
            this.Name = "BaseForm";
            this.Text = "Base";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDeEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComponentNovaEntrada()
        {
            this.nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cadastrarEntrada = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(38, 37);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(38, 13);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(41, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(266, 20);
            this.txtNome.TabIndex = 1;
            // 
            // button1
            // 
            this.cadastrarEntrada.Location = new System.Drawing.Point(41, 311);
            this.cadastrarEntrada.Name = "button1";
            this.cadastrarEntrada.Size = new System.Drawing.Size(266, 86);
            this.cadastrarEntrada.TabIndex = 2;
            this.cadastrarEntrada.Text = "button1";
            this.cadastrarEntrada.UseVisualStyleBackColor = true;
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(38, 121);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(34, 13);
            this.valor.TabIndex = 3;
            this.valor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(41, 137);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(266, 20);
            this.txtValor.TabIndex = 4;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(38, 213);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(33, 13);
            this.data.TabIndex = 5;
            this.data.Text = "Data:";
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(41, 230);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(266, 20);
            this.dtData.TabIndex = 6;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.cadastrarEntrada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nome);
            this.Name = "Base";
            this.Text = "Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button telaNovaEntrada;
        private System.Windows.Forms.Button telaNovaSaida;

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button cadastrarEntrada;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tabelaDeEntradas;
    }
}
