namespace gestao_de_financas
{
    partial class EntradaForm
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
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelValorTotalEntrada = new System.Windows.Forms.Label();
            this.valorTotalEntrada = new System.Windows.Forms.Label();
            this.labelValorTotalSaida = new System.Windows.Forms.Label();
            this.valorTotalSaida = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(64, 164);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(256, 20);
            this.dtData.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(256, 20);
            this.txtNome.TabIndex = 2;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(61, 30);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(38, 13);
            this.nome.TabIndex = 3;
            this.nome.Text = "Nome:";
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(61, 86);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(34, 13);
            this.valor.TabIndex = 4;
            this.valor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(64, 102);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(256, 20);
            this.txtValor.TabIndex = 5;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(61, 148);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(33, 13);
            this.data.TabIndex = 6;
            this.data.Text = "Data:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 70);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelValorTotalEntrada
            // 
            this.labelValorTotalEntrada.AutoSize = true;
            this.labelValorTotalEntrada.Location = new System.Drawing.Point(450, 63);
            this.labelValorTotalEntrada.Name = "labelValorTotalEntrada";
            this.labelValorTotalEntrada.Size = new System.Drawing.Size(111, 13);
            this.labelValorTotalEntrada.TabIndex = 9;
            this.labelValorTotalEntrada.Text = "Valor TOTAL entrada:";
            // 
            // valorTotalEntrada
            // 
            this.valorTotalEntrada.AutoSize = true;
            this.valorTotalEntrada.Location = new System.Drawing.Point(485, 86);
            this.valorTotalEntrada.Name = "valorTotalEntrada";
            this.valorTotalEntrada.Size = new System.Drawing.Size(13, 13);
            this.valorTotalEntrada.TabIndex = 10;
            this.valorTotalEntrada.Text = "0";
            // 
            // labelValorTotalSaida
            // 
            this.labelValorTotalSaida.AutoSize = true;
            this.labelValorTotalSaida.Location = new System.Drawing.Point(450, 133);
            this.labelValorTotalSaida.Name = "labelValorTotalSaida";
            this.labelValorTotalSaida.Size = new System.Drawing.Size(102, 13);
            this.labelValorTotalSaida.TabIndex = 11;
            this.labelValorTotalSaida.Text = "Valor TOTAL saída:";
            // 
            // valorTotalSaida
            // 
            this.valorTotalSaida.AutoSize = true;
            this.valorTotalSaida.Location = new System.Drawing.Point(485, 163);
            this.valorTotalSaida.Name = "valorTotalSaida";
            this.valorTotalSaida.Size = new System.Drawing.Size(13, 13);
            this.valorTotalSaida.TabIndex = 12;
            this.valorTotalSaida.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EntradaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.valorTotalSaida);
            this.Controls.Add(this.labelValorTotalSaida);
            this.Controls.Add(this.valorTotalEntrada);
            this.Controls.Add(this.labelValorTotalEntrada);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtData);
            this.Name = "EntradaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EntradaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComponentNovaEntrada()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();

            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(256, 20);
            this.txtNome.TabIndex = 2;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(61, 30);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(38, 13);
            this.nome.TabIndex = 3;
            this.nome.Text = "Nome:";
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(61, 86);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(34, 13);
            this.valor.TabIndex = 4;
            this.valor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(64, 102);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(256, 20);
            this.txtValor.TabIndex = 5;
        }



        #endregion

        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelValorTotalEntrada;
        private System.Windows.Forms.Label valorTotalEntrada;
        private System.Windows.Forms.Label labelValorTotalSaida;
        private System.Windows.Forms.Label valorTotalSaida;
        private System.Windows.Forms.Button button2;
    }
}

