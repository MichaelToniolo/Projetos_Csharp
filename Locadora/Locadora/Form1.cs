using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Importar dados do banco
using System.Data.SqlClient;

namespace Locadora
{
    public partial class frmConexao : Form
    {
        public frmConexao()
        {
            InitializeComponent();
        }

        #region BotaoLimpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtSenha.Clear();
            txtLogin.Focus();
        }
        #endregion

        #region Conectar
        private void btnConectar_Click(object sender, EventArgs e)
        {
            UsuarioInformation usu_info = new UsuarioInformation();

            usu_info.usu_nome = txtLogin.Text;
            usu_info.usu_senha = txtSenha.Text;

            //Instanciar o sqlConnection

            SqlConnection con = new SqlConnection();

            try
            {
                //Conexão
                con.ConnectionString = Dados.StringDeConexao;

                //Command

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(usu_nome) from Usuario where usu_nome = @usu_nome and usu_senha = @usu_senha";
                
                //Parametros
                cmd.Parameters.AddWithValue("@usu_nome", usu_info.usu_nome);
                cmd.Parameters.AddWithValue("@usu_senha", usu_info.usu_senha);

                //Abrir Conexão

                con.Open();

                int resultado;

                //resultado apenas uma coluna do SELECT aplicado
                resultado = Convert.ToInt16(cmd.ExecuteScalar());

                if (resultado == 1)
                {
                    this.Visible = false;
                    //MessageBox.Show("Logado com Sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();

                }
                else
                {
                    throw new Exception("Usuário/Senha inválido");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Fechando a Conexão
                con.Close();
            }

        }
        #endregion
    }
}
