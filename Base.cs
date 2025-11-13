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
    public partial class Base: Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Base
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Base";
            this.Load += new System.EventHandler(this.Base_Load);
            this.ResumeLayout(false);

        }

        private void Base_Load(object sender, EventArgs e)
        {

        }
    }
}
