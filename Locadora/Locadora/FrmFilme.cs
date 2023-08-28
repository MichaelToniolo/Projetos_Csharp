using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Locadora
{
    public partial class FrmFilme : Form
    {
        public FrmFilme()
        {
            InitializeComponent();
        }

        #region Load DataGrid
        private void FrmFilme_Load(object sender, EventArgs e)
        {
            dgvFilme.DataSource = AtualizaGrid(txtFiltro.Text);
            //Definir Cabeçãlho DataGrid
            dgvFilme.Columns[0].HeaderText = "Código";
            dgvFilme.Columns[1].HeaderText = "Nome";
            dgvFilme.Columns[2].HeaderText = "Duracao";
            dgvFilme.Columns[3].HeaderText = "Valor R$";
            dgvFilme.Columns[4].HeaderText = "Estoque";
            dgvFilme.Columns[5].HeaderText = "Sinopse";

            //Largura das colunas

            dgvFilme.Columns[0].Width = 45;
            dgvFilme.Columns[1].Width = 200;
            dgvFilme.Columns[2].Width = 50;
            dgvFilme.Columns[3].Width = 80;
            dgvFilme.Columns[4].Width = 50;
            dgvFilme.Columns[5].Width = 200;

            //Permissoes da DataGrid
            dgvFilme.ReadOnly = true;
            dgvFilme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFilme.AllowUserToAddRows = false;
            dgvFilme.AllowUserToDeleteRows = false;
            dgvFilme.AllowUserToResizeColumns = false;
            dgvFilme.AllowUserToResizeRows = false;
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

                //DataAdapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                //Verificar para a criação do CommandTEXT

                if (filtro.Length == 0)
                {
                    da.SelectCommand.CommandText = "select fil_codigo, fil_nome, fil_duracao, fil_vllocacao, fil_estoque, " +
                        "fil_sinopse from filmes";
                }
                else
                {
                    da.SelectCommand.CommandText = "select fil_codigo, fil_nome, fil_duracao, fil_vllocacao,_fil_estoque, " +
                        "fil_sinopse from filmes where fil_nome like '%' + @fil_nome + '%'";

                    //Parametros
                    da.SelectCommand.Parameters.AddWithValue("@fil_nome", filtro);                    
                }

                //executar a query
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        
        }
        #endregion


        #region Evento key Press
        private void txtDuracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir apenas a digitação de numeros e utilização de Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
       

        private void txtVllocacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir numeros, backspace e vírgula
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
        

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permiti apenas a digitação de numeros e utilização de Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Botão limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
        #endregion

        #region LimpaTela
        public void LimpaTela()
        {
            btnInserir.Enabled = true;
            txtCodigo.Clear();
            txtDuracao.Clear();
            txtNome.Clear();
            txtVllocacao.Clear();
            txtEstoque.Clear();
            txtSinopse.Clear();
            txtNome.Focus();

        }
        #endregion 

        #region Botão Inserir
        private void btnInserir_Click(object sender, EventArgs e)
        {
            FilmeInformation fil = new FilmeInformation();
            fil.fil_nome = txtNome.Text;
            fil.fil_duracao = Convert.ToInt16(txtDuracao.Text);
            fil.fil_vllocacao = Convert.ToDecimal(txtDuracao.Text);
            fil.fil_sinopse = txtSinopse.Text;
            fil.fil_estoque = Convert.ToInt16(txtEstoque.Text);

            SqlConnection con = new SqlConnection();

            try
            {
                //Conexao
                con.ConnectionString = Dados.StringDeConexao;

                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into filmes (fil_nome, fil_duracao, fil_sinopse, fil_vllocacao," +
                    "fil_estoque) values (@fil_nome, @fil_duracao, @fil_sinopse, @fil_vllocacao, @fil_estoque)";

                //parametros
                cmd.Parameters.AddWithValue("@fil_nome", fil.fil_nome);
                cmd.Parameters.AddWithValue("@fil_duracao", fil.fil_duracao);
                cmd.Parameters.AddWithValue("@fil_sinopse", fil.fil_sinopse);
                cmd.Parameters.AddWithValue("@fil_vllocacao", fil.fil_vllocacao);
                cmd.Parameters.AddWithValue("@fil_estoque", fil.fil_estoque);

                //abrir conexao
                con.Open();

                //executar query
                cmd.ExecuteNonQuery();

                MessageBox.Show("Filme cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaTela();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            finally
            {
                con.Close();
                dgvFilme.DataSource = AtualizaGrid(txtFiltro.Text);
            }
        
        }
        #endregion

        #region Click_DataGrid

        private void dgvFilme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnInserir.Enabled = false;

            txtCodigo.Text = dgvFilme[0, dgvFilme.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvFilme[1, dgvFilme.CurrentRow.Index].Value.ToString();
            txtDuracao.Text = dgvFilme[2, dgvFilme.CurrentRow.Index].Value.ToString();
            txtVllocacao.Text = dgvFilme[3, dgvFilme.CurrentRow.Index].Value.ToString();
            txtEstoque.Text = dgvFilme[4, dgvFilme.CurrentRow.Index].Value.ToString();
            txtSinopse.Text = dgvFilme[5, dgvFilme.CurrentRow.Index].Value.ToString();
        }
        #endregion

        #region Botão Alterar

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FilmeInformation filme = new FilmeInformation();
            filme.fil_codigo = Convert.ToInt16(txtCodigo.Text);
            filme.fil_nome = txtNome.Text;
            filme.fil_duracao = Convert.ToInt16(txtDuracao.Text);
            filme.fil_sinopse = txtSinopse.Text;
            filme.fil_vllocacao = Convert.ToDecimal(txtVllocacao.Text);
            filme.fil_estoque = Convert.ToInt16(txtEstoque.Text);

            SqlConnection con = new SqlConnection();

            try
            {
                //conexao
                con.ConnectionString = Dados.StringDeConexao;

                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update filmes set fil_nome = @fil_nome, fil_duracao = @fil_duracao, " +
                    "fil_sinopse = @fil_sinopse, fil_vllocacao = @fil_vllocacao, fil_estoque = @fil_estoque " +
                    "where fil_codigo = @fil_codigo";

                //Parametros
                cmd.Parameters.AddWithValue("@fil_codigo", filme.fil_codigo);
                cmd.Parameters.AddWithValue("@fil_nome", filme.fil_nome);
                cmd.Parameters.AddWithValue("@fil_duracao", filme.fil_duracao);
                cmd.Parameters.AddWithValue("@fil_sinopse", filme.fil_sinopse);
                cmd.Parameters.AddWithValue("@fil_vllocacao", filme.fil_vllocacao);
                cmd.Parameters.AddWithValue("@fil_estoque", filme.fil_estoque);


                //abrir conexao

                con.Open();

                //executar query
                cmd.ExecuteNonQuery();

                MessageBox.Show("Filme alterado com sucesso", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                //fecha conexao
                con.Close();
                dgvFilme.DataSource = AtualizaGrid(txtFiltro.Text);

            }
        }
        #endregion

        #region Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FilmeInformation filme = new FilmeInformation();
            filme.fil_codigo = Convert.ToInt16(txtCodigo.Text);

            SqlConnection con = new SqlConnection();

            try
            {
                //conexao
                con.ConnectionString = Dados.StringDeConexao;

                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from filmes where usu_codigo = @usu_codigo";

                //Parametros
                cmd.Parameters.AddWithValue("usu_codigo", filme.fil_codigo);

                //Abrir

            }
            catch (Exception)
            {
                
                throw;
            }


        }
        #endregion
    }
}
