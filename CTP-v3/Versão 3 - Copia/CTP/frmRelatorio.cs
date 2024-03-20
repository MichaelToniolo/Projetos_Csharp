using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;


namespace CTP
{
    public partial class frmRelatorio : Form
    {
        decimal preco = 0;
        decimal quantidade = 0;
        

        decimal total = 0;
        

        public frmRelatorio()
        {
            InitializeComponent();
        }

        #region Botão Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string dataform = datavendas.Text;
            string dataform2 = dataVendas2.Text;
            dgvconsulta.DataSource = cons(dataform);
            dgvconsulta.DataSource = cons(dataform2);

            //atualiza grid
            dgvconsulta.Columns[0].HeaderText = "CODIGO CLIENTE";
            dgvconsulta.Columns[0].Width = 60;
            dgvconsulta.Columns[1].HeaderText = "RAZAO SOCIAL";
            dgvconsulta.Columns[1].Width = 150;
            dgvconsulta.Columns[2].HeaderText = "CODIGO PRODUTO";
            dgvconsulta.Columns[2].Width = 150;
            dgvconsulta.Columns[3].HeaderText = "DESCRICAO PRODUTO";
            dgvconsulta.Columns[3].Width = 100;
            dgvconsulta.Columns[4].HeaderText = "MARCA";
            dgvconsulta.Columns[4].Width = 100;
            dgvconsulta.Columns[5].HeaderText = "PRECO";
            dgvconsulta.Columns[5].Width = 100;
            dgvconsulta.Columns[6].HeaderText = "QUANTIDADE";
            dgvconsulta.Columns[6].Width = 100;
            dgvconsulta.Columns[7].HeaderText = "O.S CODIGO";
            dgvconsulta.Columns[7].Width = 100;
            dgvconsulta.Columns[8].HeaderText = "DATA DA O.S";
            dgvconsulta.Columns[8].Width = 100;

            //Permisão da data Grid
            dgvconsulta.ReadOnly = true;
            dgvconsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvconsulta.AllowDrop = false;
            dgvconsulta.AllowUserToAddRows = false;
            dgvconsulta.AllowUserToDeleteRows = false;
            dgvconsulta.AllowUserToOrderColumns = false;
            dgvconsulta.AllowUserToResizeColumns = true;
            dgvconsulta.AllowUserToResizeRows = false;


            for (int i = 0; i < dgvconsulta.Rows.Count; i++)
            {
                preco = Convert.ToDecimal(dgvconsulta.Rows[i].Cells[5].Value);
                quantidade = Convert.ToDecimal(dgvconsulta.Rows[i].Cells[6].Value);
                total = total + preco * quantidade;

                
                TbxReceita.Text = total.ToString("C");
                

            }
            btnPesquisar.Enabled = false;
            
            
            
        }
        #endregion

        #region Lista Venda
        public System.Data.DataTable cons(string data)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //command
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (cbbCliente.Text == "" && cbbProduto.Text == "")
                {
                    da.SelectCommand.CommandText = "select b.cadcliente_codigo, b.nome, p.codigo, p.descricao, p.marca, e.preco, e.estoque_qtd, e.baixa_codigo, b.datab as datavenda from produto as p right join estoque as e on p.codigo = e.produto_codigo left join baixa as b on e.baixa_codigo = b.codigo where datab >= @ven_data and datab <= @ven_data2";
                }
                else if (cbbProduto.Text.Length > 0 && cbbCliente.Text.Length > 0)
                {
                    da.SelectCommand.CommandText = "select b.cadcliente_codigo, b.nome, p.codigo, p.descricao, p.marca, e.preco, e.estoque_qtd, e.baixa_codigo, b.datab as datavenda from produto as p right join estoque as e on p.codigo = e.produto_codigo left join baixa as b on e.baixa_codigo = b.codigo where p.descricao = @p_codigo and b.nome = @c_codigo and datab >= @ven_data and datab <= @ven_data2";
                }
                else if (cbbCliente.Text.Length > 0)
                {
                    da.SelectCommand.CommandText = "select b.cadcliente_codigo, b.nome, p.codigo, p.descricao, p.marca, e.preco, e.estoque_qtd, e.baixa_codigo, b.datab as datavenda from produto as p right join estoque as e on p.codigo = e.produto_codigo left join baixa as b on e.baixa_codigo = b.codigo where b.nome = @c_codigo and datab >= @ven_data and datab <= @ven_data2";
                }
                else if (cbbProduto.Text.Length > 0)
                {
                    da.SelectCommand.CommandText = "select b.cadcliente_codigo, b.nome, p.codigo, p.descricao, p.marca, e.preco, e.estoque_qtd, e.baixa_codigo, b.datab as datavenda from produto as p right join estoque as e on p.codigo = e.produto_codigo left join baixa as b on e.baixa_codigo = b.codigo where p.descricao = @p_codigo and datab >= @ven_data and datab <= @ven_data2";
                }
                
                //parametros
                da.SelectCommand.Parameters.AddWithValue("@ven_data", datavendas.Text);
                da.SelectCommand.Parameters.AddWithValue("@ven_data2", dataVendas2.Text);
                da.SelectCommand.Parameters.AddWithValue("@p_codigo", cbbProduto.Text);
                da.SelectCommand.Parameters.AddWithValue("@c_codigo", cbbCliente.Text);


                //executar query
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "atenção", MessageBoxButtons.OK);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region BuscaCliente
        private void button1_Click(object sender, EventArgs e)
        {
            PesquisaCliente pro = new PesquisaCliente();
            pro.ShowDialog();
            //txtcodigopro.Text = pro.codigo;
            cbbCliente.Text = pro.nome;
            //txtmarca.Text = pro.marca;
            pro.Close();
        }
        #endregion

        #region BuscarProduto
        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto pqp = new frmPesquisaProduto();
            pqp.ShowDialog();

            cbbProduto.Text = pqp.descricao;

            pqp.Close();
        }
        #endregion

        #region Limpa Tela
        private void LimpaTela()
        {
            total = 0;
            TbxReceita.Clear();
            cbbCliente.SelectedIndex = -1;
            cbbProduto.SelectedIndex = -1;
            dgvconsulta.Columns.Clear();
            //dgvconsulta.Rows.Clear();
            TbxReceita.Clear();
            datavendas.ResetText();
            dataVendas2.ResetText();
            btnPesquisar.Enabled = true;
        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
        #endregion

        #region Meotodo Pesquisa Cliente
        public System.Data.DataTable PesquisaCliente()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //dataadpter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = "select codigo, nome from cadcliente";

                //preencher datatable

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Metodo Pesquisa Produto
        public System.Data.DataTable PesquisaProduto()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //dataadpter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = "select codigo, descricao from produto";

                //preencher datatable

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Load
        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            cbbCliente.DataSource = PesquisaCliente();
            cbbCliente.ValueMember = "codigo";
            cbbCliente.DisplayMember = "nome";

            cbbCliente.SelectedIndex = -1;

            cbbProduto.DataSource = PesquisaProduto();
            cbbProduto.ValueMember = "codigo";
            cbbProduto.DisplayMember = "descricao";

            cbbProduto.SelectedIndex = -1;
        }
           #endregion

        #region Botão exportar
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvconsulta.Rows.Count == 0)
            {
                MessageBox.Show("NÃO A DADOS PARA EXPORTAR", "ATENÇÃO");
            }
            else
            {
                SaveFileDialog salvar = new SaveFileDialog(); // novo

                Microsoft.Office.Interop.Excel.Application App; // Aplicação Excel
                Microsoft.Office.Interop.Excel.Workbook WorkBook; // Pasta
                Microsoft.Office.Interop.Excel.Worksheet WorkSheet; // Planilha
                object misValue = System.Reflection.Missing.Value;

                App = new Microsoft.Office.Interop.Excel.Application();
                WorkBook = App.Workbooks.Add(misValue);
                WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                /* passa as celulas do DataGridView para a Pasta do Excel
                for (i = 0; i <= dgvconsulta.RowCount - 1; i++)
                {
                

                    for (j = 0; j <= dgvconsulta.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvconsulta[j, i];
                        WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }*/

                // passa as celulas do DataGridView para a Pasta do Excel
                for (j = 0; j < dgvconsulta.ColumnCount; j++)
                {
                    WorkSheet.Cells[1, j + 1] = dgvconsulta.Columns[j].HeaderText;
                }
                for (i = 1; i <= dgvconsulta.RowCount; i++)
                {
                    for (j = 0; j < dgvconsulta.ColumnCount; j++)
                    {
                        DataGridViewCell cell = dgvconsulta[j, i - 1];
                        WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }

                // define algumas propriedades da caixa salvar
                salvar.Title = "Exportar para Excel";
                salvar.Filter = "Arquivo do Excel *.xls | *.xls";
                //salvar.ShowDialog(); // mostra

                // salva o arquivo

                if (salvar.ShowDialog(this) == DialogResult.OK)
                {
                    WorkBook.SaveAs(salvar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
               Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                    WorkBook.Close(true, misValue, misValue);
                    App.Quit(); // encerra o excel

                    MessageBox.Show("Exportado com sucesso!");

                }
                else
                {

                    WorkBook.Close(false, misValue, misValue);
                    App.Quit(); // encerra o excel                
                }

                //string msg;

            }
        }
        #endregion


    }
}
        