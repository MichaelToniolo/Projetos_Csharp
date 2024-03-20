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
    public partial class PesquisaCliente : Form
    {
        

        public PesquisaCliente()
        {
            InitializeComponent();
        }

        public string codigo, nome, cpf, cidade;

        #region Click da DataGridView
        private void dtgPesquisaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dtgPesquisaCliente[0, dtgPesquisaCliente.CurrentRow.Index].Value.ToString();
            nome = dtgPesquisaCliente[1, dtgPesquisaCliente.CurrentRow.Index].Value.ToString();
            cpf = dtgPesquisaCliente[2, dtgPesquisaCliente.CurrentRow.Index].Value.ToString();
            cidade = dtgPesquisaCliente[3, dtgPesquisaCliente.CurrentRow.Index].Value.ToString();
            
            this.Close();
        }
        #endregion

        #region Botão Retornar
        private void btnretornar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA RETORNAR AO MENU ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
            {
                this.Close();
            }
        }
        #endregion

        #region Load
        private void PesquisaCliente_Load(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = AtualizaGridCodigo(txtfiltro.Text);
            dtgPesquisaCliente.DataSource = AtualizaGridNome(txtFiltroNome.Text);

            // cabeçalho datagrid
            dtgPesquisaCliente.Columns[0].HeaderText = "CODIGO";
            dtgPesquisaCliente.Columns[1].HeaderText = "RAZÃO SOCIAL";
            dtgPesquisaCliente.Columns[2].HeaderText = "CPF";
            dtgPesquisaCliente.Columns[3].HeaderText = "CIDADE";
            
            //largura das colucas
            dtgPesquisaCliente.Columns[0].Width = 60;
            dtgPesquisaCliente.Columns[1].Width = 220;
            dtgPesquisaCliente.Columns[2].Width = 140;
            dtgPesquisaCliente.Columns[3].Width = 215;                     

            //permissões da datagrid
            dtgPesquisaCliente.ReadOnly = true;
            dtgPesquisaCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPesquisaCliente.AllowUserToAddRows = false;
            dtgPesquisaCliente.AllowUserToDeleteRows = false;
            dtgPesquisaCliente.AllowUserToResizeColumns = false;
            dtgPesquisaCliente.AllowUserToResizeRows = false; 
        }
        #endregion

        #region Atualiza Grid

        public DataTable AtualizaGridCodigo(string filtro)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                // data adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (filtro.Length == 0)
                {
                    da.SelectCommand.CommandText = "select codigo, nome, cpf, cidade from cadcliente order by nome";

                }
                else
                {
                    da.SelectCommand.CommandText = "select codigo, nome, cpf, cidade from cadcliente where codigo like '%' + @prod_cod + '%' order by nome";
                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@prod_nome", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cod", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cpf", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cidade", filtro);
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

        #region Filtro DataGridView Codigo
        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = AtualizaGridCodigo(txtfiltro.Text);
        }
        #endregion

        #region Atualiza Grid Nome

        public DataTable AtualizaGridNome(string filtro)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                // data adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (filtro.Length == 0)
                {
                    da.SelectCommand.CommandText = "select codigo, nome, cpf, cidade from cadcliente order by nome";

                }
                else
                {
                    da.SelectCommand.CommandText = "select codigo, nome, cpf, cidade from cadcliente where nome like '%' + @prod_nome + '%' order by nome";
                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@prod_nome", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cod", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cpf", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cidade", filtro);                    
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

        #region Filtro DataGridView Nome
        private void txtFiltroNome_TextChanged(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = AtualizaGridNome(txtFiltroNome.Text);
        }
        #endregion

       #region Atualiza Grid Cidade

        public DataTable AtualizaGridCidade(string filtro)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                // data adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (filtro.Length == 0)
                {
                    da.SelectCommand.CommandText = "select codigo, nome, cpf, cidade from cadcliente order by nome";

                }
                else
                {
                    da.SelectCommand.CommandText = "select codigo, nome, cpf, cidade from cadcliente where cidade like '%' + @prod_cidade + '%' order by nome";
                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@prod_cidade", filtro);
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

       #region Filtro DataGridView Cidade
        private void txtFiltroCidade_TextChanged(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = AtualizaGridCidade(txtFiltroCidade.Text);
        }
        #endregion

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = AtualizaGridCPF(txtCPF.Text);
        }

        #region Atualiza Grid CPF

        public DataTable AtualizaGridCPF(string filtro)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                // data adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (filtro.Length == 0)
                {
                    da.SelectCommand.CommandText = "select codigo, nome, cpf, cidade from cadcliente order by nome";

                }
                else
                {
                    da.SelectCommand.CommandText = "select codigo, nome, cpf, cidade from cadcliente where cpf like '%' + @prod_cpf + '%' order by nome";
                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@prod_cpf", filtro);
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
    }
}
