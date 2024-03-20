using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FF
{
    public partial class frmpesquisafornecedor : Form
    {
        public string codigo, marca, nome, t;

        public frmpesquisafornecedor()
        {
            InitializeComponent();
        }

        #region Load
        private void frmpesquisafornecedor_Load(object sender, EventArgs e)
        {
            dtgPesquisaFornecedor.DataSource = AtualizaGrid(txtfiltro.Text);

            t = dtgPesquisaFornecedor[4, dtgPesquisaFornecedor.CurrentRow.Index].Value.ToString();

            //cabeçalho datagrid
            dtgPesquisaFornecedor.Columns[0].HeaderText = "CODIGO";
            dtgPesquisaFornecedor.Columns[1].HeaderText = "RAZÃO SOCIAL";
            dtgPesquisaFornecedor.Columns[2].HeaderText = "CPF";
            dtgPesquisaFornecedor.Columns[3].HeaderText = "CNPJ";
            dtgPesquisaFornecedor.Columns[4].HeaderText = "CIDADE";
            

            //largura das colunas
            dtgPesquisaFornecedor.Columns[0].Width = 60;
            dtgPesquisaFornecedor.Columns[1].Width = 220;
            dtgPesquisaFornecedor.Columns[2].Width = 120;
            dtgPesquisaFornecedor.Columns[3].Width = 180;
            dtgPesquisaFornecedor.Columns[4].Width = 110;
            

            //permissões da datagrid
            dtgPesquisaFornecedor.ReadOnly = true;
            dtgPesquisaFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPesquisaFornecedor.AllowUserToAddRows = false;
            dtgPesquisaFornecedor.AllowUserToDeleteRows = false;
            dtgPesquisaFornecedor.AllowUserToResizeColumns = false;
            dtgPesquisaFornecedor.AllowUserToResizeRows = false;
        }
        #endregion

        #region Atualiza Grid

        public DataTable AtualizaGrid(string filtro)
        {
            SqlConnection con = new  SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                //conexão
                con.ConnectionString = conexao.conexaoBancoDados;

                // data adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (filtro.Length == 0)
                {
                    da.SelectCommand.CommandText = "select codigo, fornecedor, cpf, cnpj, cidade from cadfornecedor";

                }
                else
                {
                    da.SelectCommand.CommandText = "select codigo, fornecedor, cpf, cnpj, cidade from cadfornecedor where nome like '%' + @prod_nome + '%' or codigo like '%' + @prod_cod + '%' or cpf like '%' + @prod_cpf + '%' or cnpj like '%' + @prod_cnpj + '%' or cidade like '%' + @prod_cidade + '%'";
                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@prod_nome", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cod", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cpf", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cnpj", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cidade", filtro);
                    //da.SelectCommand.Parameters.AddWithValue("@prod_tipo", filtro);
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

        #region Cell Click
        private void dtgPesquisaFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dtgPesquisaFornecedor[0, dtgPesquisaFornecedor.CurrentRow.Index].Value.ToString();
            nome = dtgPesquisaFornecedor[1, dtgPesquisaFornecedor.CurrentRow.Index].Value.ToString();            

            this.Close();
        }
        #endregion

        private void btnretornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
