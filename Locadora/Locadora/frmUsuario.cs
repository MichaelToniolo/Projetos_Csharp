using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Traz os dados do BD
using System.Data.SqlClient;

namespace Locadora
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        #region Metodo Load
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            dgvUsuario.DataSource = AtualizaGrid(txtFiltro.Text);
            
            //Configuração Cabeçalho DataGrid
            dgvUsuario.Columns[0].HeaderText = "Código do Usuário";
            dgvUsuario.Columns[1].HeaderText = "Nome do Usuário";

            //Configuração Largura DataGrid
            dgvUsuario.Columns[0].Width = 125;
            dgvUsuario.Columns[1].Width = 135;

            //Permissões na DataGrid
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.AllowUserToResizeColumns = false;
            dgvUsuario.ReadOnly = true;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        #endregion

        #region AtualizaGrid
        public DataTable AtualizaGrid(string filtro)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                //conexão
                con.ConnectionString = Dados.StringDeConexao;

                //data adapter (quando for trabalhar com a datagrid
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (filtro.Length == 0)
                {
                    da.SelectCommand.CommandText = "select usu_codigo, usu_nome from usuario";
                }
                else
                {
                    da.SelectCommand.CommandText = "select usu_codigo, usu_nome from where usu_nome like '%' + @usu_nome + '%'";


                    //parametros
                    da.SelectCommand.Parameters.AddWithValue("@usu_nome", filtro);
                }

                //executar query
                da.Fill(dt);

                //retorno do metodo
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        
        #endregion

        #region Botão Inserir
        private void btnInserir_Click(object sender, EventArgs e)
        {
            UsuarioInformation usuario = new UsuarioInformation();
            usuario.usu_nome = txtUsuario.Text;
            usuario.usu_senha = txtSenha.Text;

            SqlConnection con = new SqlConnection();
            try
            {
                //conexão
                con.ConnectionString = Dados.StringDeConexao;

                //Command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into usuario (usu_nome, usu_senha) values (@usu_nome, @usu_senha)";

                //Parametros
                cmd.Parameters.AddWithValue("@usu_nome", usuario.usu_nome);
                cmd.Parameters.AddWithValue("@usu_senha", usuario.usu_senha);

                //Abrir Conexão
                con.Open();

               
                if (usuario.usu_nome.Trim().Length == 0)
                {
                    MessageBox.Show("Necessário inserir Nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw new Exception();
                }
                

                //Executar query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso.", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaTela();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                con.Close();

                dgvUsuario.DataSource = AtualizaGrid(txtFiltro.Text);
            }

        }
        #endregion

        #region LimpaTela
        public void LimpaTela()
        {
            btnInserir.Enabled = true;
            txtUsuario.Enabled = true;
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        #endregion

        #region BotãoTela
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
        #endregion

        #region Click DataGrid
        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Enabled = false;
            btnInserir.Enabled = false;

            txtCodigo.Text = dgvUsuario[0, dgvUsuario.CurrentRow.Index].Value.ToString();
            txtUsuario.Text = dgvUsuario[1, dgvUsuario.CurrentRow.Index].Value.ToString();
        }
        #endregion

        #region Botão Alterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            UsuarioInformation usuario = new UsuarioInformation();
            usuario.usu_codigo = Convert.ToInt16(txtCodigo.Text);
            usuario.usu_nome = txtUsuario.Text;
            usuario.usu_senha = txtSenha.Text;


            //Instancia conexão
            SqlConnection con = new SqlConnection();


            try
            {
                //Conexão
                con.ConnectionString = Dados.StringDeConexao;

                //Command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Usuario set usu_senha = @usu_senha where usu_codigo = @usu_codigo";


                //Parameters 
                cmd.Parameters.AddWithValue("@usu_codigo", usuario.usu_codigo);
                cmd.Parameters.AddWithValue("@usu_senha", usuario.usu_senha);

                //Abrir Conexão

                con.Open();

                //Executar query
                cmd.ExecuteNonQuery();

                MessageBox.Show("Senha alterada com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                dgvUsuario.DataSource = AtualizaGrid(txtFiltro.Text);
            }
        }
        #endregion

        #region Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            UsuarioInformation usuario = new UsuarioInformation();
            usuario.usu_codigo = Convert.ToInt16(txtCodigo.Text);

            SqlConnection con = new SqlConnection();

            try
            {
                //Conexão
                con.ConnectionString = Dados.StringDeConexao;

                //Commando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Usuario where usu_codigo = @usu_codigo";

                //Parameters
                cmd.Parameters.AddWithValue("@usu_codigo", usuario.usu_codigo);

                //Abrir conexao
                con.Open();

                if (MessageBox.Show("Deseja Realmente excluir usuário?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Executar Query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário excluído com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaTela();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                //Fecha conexão
                con.Close();
                dgvUsuario.DataSource = AtualizaGrid(txtFiltro.Text);
            }
        }
        #endregion

        #region txtChanged
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = AtualizaGrid(txtFiltro.Text);
        }
        #endregion
    }
}
