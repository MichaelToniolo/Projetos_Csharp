using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CTP
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        #region Botão Inserir
        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Length > 0 && txtSenha.Text.Length > 0)
            {
                usuarioInformation usu = new usuarioInformation();
                usu.usu_Nome = txtUsuario.Text;
                usu.usu_Senha = txtSenha.Text;

                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    //COMMAND
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into cadusuario (nome, senha) values (@usu_nome, @usu_senha)";

                    //PARAMETROS
                    cmd.Parameters.AddWithValue("@usu_nome", usu.usu_Nome);
                    cmd.Parameters.AddWithValue("@usu_senha", usu.usu_Senha);

                    //Abrir conexão
                    con.Open();

                    //Executar Query
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
            else
            {
                MessageBox.Show("Digite o Nome de usuário e senha", "Atenão", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region AtualizaGrid
        public DataTable AtualizaGrid(string filtro)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //DataAdapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (filtro.Length == 0)
                {
                    da.SelectCommand.CommandText = "select codigo, nome from cadusuario";
                }
                else
                {
                    da.SelectCommand.CommandText = "select codigo, nome from cadusuario where nome like '%' + @usu_nome + '%'";

                    //Parametros
                    da.SelectCommand.Parameters.AddWithValue("@usu_nome", filtro);
                }

                //Executar Query
                da.Fill(dt);

                //retorno do método
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

        #region Load
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            dgvUsuario.DataSource = AtualizaGrid(txtFiltro.Text);

            //Configuração Cabeçalho DataGrid
            dgvUsuario.Columns[0].HeaderText = "Código do Usuário";
            dgvUsuario.Columns[1].HeaderText = "Nome do Usuário";

            //Configuração Largura DataGrid
            dgvUsuario.Columns[0].Width = 125;
            dgvUsuario.Columns[1].Width = 155;

            
            //Permissões na DataGrid
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.AllowUserToResizeColumns = true;
            dgvUsuario.ReadOnly = true;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

           
            
            
;
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
            if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("Selecione um usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtSenha.Text.Length == 0)
            {
                MessageBox.Show("Digite uma senha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                usuarioInformation usu = new usuarioInformation();
                usu.usu_Cod = Convert.ToInt32(txtCodigo.Text);
                usu.usu_Nome = txtUsuario.Text;
                usu.usu_Senha = txtSenha.Text;

                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    //command
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update cadusuario set senha = @usu_senha where codigo = @usu_codigo";

                    //Parametros
                    cmd.Parameters.AddWithValue("@usu_codigo", usu.usu_Cod);
                    cmd.Parameters.AddWithValue("@usu_senha", usu.usu_Senha);

                    //Abrir conexão
                    con.Open();

                    //Executar Query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Atualizado com sucesso", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
           
        }
        #endregion

        #region Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Selecione um Usuário para Excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                usuarioInformation usu = new usuarioInformation();
                usu.usu_Cod = Convert.ToInt32(txtCodigo.Text);

                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    //command
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from cadusuario where codigo = @usu_codigo";

                    //parametros
                    cmd.Parameters.AddWithValue("@usu_codigo", usu.usu_Cod);

                    //abrir conexão
                    con.Open();

                    if (MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Executar Query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Excluído com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaTela();
                    }
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
        }
        #endregion

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = AtualizaGrid(txtFiltro.Text);
        }

       
    }
}
