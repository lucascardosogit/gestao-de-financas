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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nome = this.nome.Text;
            double valor = double.Parse(txtValor.Text);
            DateTime data = DateTime.Parse(dtData.Text);
            string categoria = comboCategoria.Text;

            totalValue.Text = valor.ToString();
        }
    }
}
