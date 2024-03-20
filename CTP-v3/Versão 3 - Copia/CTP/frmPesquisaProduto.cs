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
    public partial class frmPesquisaProduto : Form
    {
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }

        public string codigo, descricao, marca, preco;

        #region Click da DataGridView
        private void dtgPesquisaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            codigo = dtgPesquisaProduto[0, dtgPesquisaProduto.CurrentRow.Index].Value.ToString();
            descricao = dtgPesquisaProduto[1, dtgPesquisaProduto.CurrentRow.Index].Value.ToString();
            marca = dtgPesquisaProduto[2, dtgPesquisaProduto.CurrentRow.Index].Value.ToString();
            preco = dtgPesquisaProduto[3, dtgPesquisaProduto.CurrentRow.Index].Value.ToString();

            this.Close();
        }
        #endregion

        #region Load
        private void frmPesquisaProduto_Load(object sender, EventArgs e)
        {
            dtgPesquisaProduto.DataSource = AtualizaGrid(txtfiltro.Text);


            // cabeçalho datagrid
            dtgPesquisaProduto.Columns[0].HeaderText = "CODIGO";
            dtgPesquisaProduto.Columns[1].HeaderText = "DESCRIÇÃO";
            //dtgPesquisaCliente.Columns[2].HeaderText = "ESTOQUE";
            dtgPesquisaProduto.Columns[2].HeaderText = "MARCA";
            //dtgPesquisaCliente.Columns[4].HeaderText = "CADASTRO";
            dtgPesquisaProduto.Columns[3].HeaderText = "PRECO";
            dtgPesquisaProduto.Columns[4].HeaderText = "QUANTIDADE";

            //largura das colucas
            dtgPesquisaProduto.Columns[0].Width = 60;
            dtgPesquisaProduto.Columns[1].Width = 380;
            dtgPesquisaProduto.Columns[2].Width = 120;
            dtgPesquisaProduto.Columns[3].Width = 100;
            dtgPesquisaProduto.Columns[4].Width = 100;

            //permissões da datagrid
            dtgPesquisaProduto.ReadOnly = true;
            dtgPesquisaProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPesquisaProduto.AllowUserToAddRows = false;
            dtgPesquisaProduto.AllowUserToDeleteRows = false;
            dtgPesquisaProduto.AllowUserToResizeColumns = false;
            dtgPesquisaProduto.AllowUserToResizeRows = false; 
        }
        #endregion

        #region Atualiza Grid

        public DataTable AtualizaGrid(string filtro)
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
                    da.SelectCommand.CommandText = "select codigo, descricao, marca, preco, quantidade from produto";

                }
                else
                {
                    da.SelectCommand.CommandText = "select codigo, descricao, marca, preco, quantidade from produto where descricao like '%' + @prod_nome + '%'";
                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@prod_nome", filtro);
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

        #region Menu
        private void btnretornar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA RETORNAR AO MENU ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
            {
                this.Close();
            }
        }
        #endregion

        #region Buscar
        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            dtgPesquisaProduto.DataSource = AtualizaGrid(txtfiltro.Text);
        }
        #endregion

       
    }
}
