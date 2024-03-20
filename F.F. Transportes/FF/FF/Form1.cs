using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FF
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmcadastro a = new frmcadastro();
            a.ShowDialog();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            entrada q = new entrada();
            q.ShowDialog();
        }

        private void btnBaixa_Click(object sender, EventArgs e)
        {
            baixa b = new baixa();
            b.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio r = new frmRelatorio();
            r.ShowDialog();
        }
       
    }
}
