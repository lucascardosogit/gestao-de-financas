namespace gestao_de_financas
{
    partial class Form1
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
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.comboCategoria.Location = new System.Drawing.Point(64, 228);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(256, 21);
            this.comboCategoria.TabIndex = 0;
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
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Location = new System.Drawing.Point(61, 212);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(55, 13);
            this.categoria.TabIndex = 7;
            this.categoria.Text = "Categoria:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor TOTAL:";
            // 
            // totalValue
            // 
            this.totalValue.AutoSize = true;
            this.totalValue.Location = new System.Drawing.Point(438, 183);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(13, 13);
            this.totalValue.TabIndex = 10;
            this.totalValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.comboCategoria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalValue;
    }
}

