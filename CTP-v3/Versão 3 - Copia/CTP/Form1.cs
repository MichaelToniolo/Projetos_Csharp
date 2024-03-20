using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Deployment.Application;
using LEVINNI;

namespace CTP
{
    public partial class frmPrincipal : Form
    {
        public string nome;

        public frmPrincipal()
        {
            InitializeComponent();

            this.Text = "Levinni - 1.0.0.0";
        }

        //TO DO
        //Váriavel global para armazenar usuário logado
        

        #region Botão Cadastro de Clientes e Produtos
        public void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro a = new frmCadastro();
            a.ShowDialog();
            
        }
        #endregion

        #region Botão Relatórios
        private void button3_Click(object sender, EventArgs e)
        {
            frmRelatorio r = new frmRelatorio();
            r.ShowDialog();
        }
        #endregion

        #region Botão Entrada de Mercadorias
        private void button4_Click(object sender, EventArgs e)
        {
            frmEntrada w = new frmEntrada();
            w.ShowDialog();
        }
        #endregion

        #region Botão Sair
        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("DESEJA SAIR ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
            {
                Application.Exit();
            }
        }
        #endregion

        #region Botão Cadastrar Operador
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario();
            usuario.ShowDialog();
        }
        #endregion

        #region Botão Caixa
        private void button5_Click(object sender, EventArgs e)
        {
            frmOrcamento frmorcamento = new frmOrcamento();
            frmorcamento.vendedor = nome;
            frmorcamento.ShowDialog();
        }
        #endregion

        #region Botão Contas a Receber
        private void button2_Click(object sender, EventArgs e)
        {
            frmContasaReceber frmContasaReceber = new frmContasaReceber();
            frmContasaReceber.ShowDialog();
        }
        #endregion

        private void frmPrincipal_Load(object sender, EventArgs e)
        {          
            lblLogin.Text = "Usuário" + ": " + nome;

            if (nome != "admin")
            {
                btnCadastro.Visible = false;
            }
         
        }

        private void btnRelatorioContasReceber_Click(object sender, EventArgs e)
        {
            frmRelatorioContasReceber r = new frmRelatorioContasReceber();
            r.ShowDialog();
        }        
    }
}
