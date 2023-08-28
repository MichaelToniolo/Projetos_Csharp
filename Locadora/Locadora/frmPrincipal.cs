using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Locadora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region Botão Sair
        private void tsbSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da Bagaça?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
        
        #region Botão Usuário
        private void tsbUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario();
            usuario.ShowDialog();
        }
        #endregion

        #region Botão Filme
        private void tsbFilme_Click(object sender, EventArgs e)
        {

            FrmFilme filme = new FrmFilme();
            filme.ShowDialog();
        }
        #endregion
    }
}
