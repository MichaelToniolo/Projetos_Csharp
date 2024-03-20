using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CTP;
using System.Data.SqlClient;

namespace LEVINNI
{
    public partial class frmRelatorioContasReceber : Form
    {
        decimal preco = 0;
        decimal quantidade = 0;


        decimal total = 0;

        public frmRelatorioContasReceber()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string dataform = datavendas.Text;
            string dataform2 = dataVendas2.Text;
            dgvconsulta.DataSource = cons(dataform);
            dgvconsulta.DataSource = cons(dataform2);

            //atualiza grid
            dgvconsulta.Columns[0].HeaderText = "FICHA";
            dgvconsulta.Columns[0].Width = 60;
            dgvconsulta.Columns[1].HeaderText = "CLIENTE";
            dgvconsulta.Columns[1].Width = 150;
            dgvconsulta.Columns[2].HeaderText = "VALOR";
            dgvconsulta.Columns[2].Width = 150;
            dgvconsulta.Columns[3].HeaderText = "PARCELA";
            dgvconsulta.Columns[3].Width = 100;
            dgvconsulta.Columns[4].HeaderText = "CADASTRO";
            dgvconsulta.Columns[4].Width = 100;
            dgvconsulta.Columns[5].HeaderText = "VENCIMENTO";
            dgvconsulta.Columns[5].Width = 100;
            dgvconsulta.Columns[6].HeaderText = "BAIXADO";
            dgvconsulta.Columns[6].Width = 100;

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
                preco = Convert.ToDecimal(dgvconsulta.Rows[i].Cells[2].Value);
                //quantidade = Convert.ToDecimal(dgvconsulta.Rows[i].Cells[6].Value);
                total = total + preco;



                TbxReceita.Text = Convert.ToString(Decimal.Round(total));


            }
            btnPesquisar.Enabled = false;
            
            
            
        }

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

        #region Load
        private void frmRelatorioContasReceber_Load(object sender, EventArgs e)
        {
            cbbCliente.DataSource = PesquisaCliente();
            cbbCliente.ValueMember = "codigo";
            cbbCliente.DisplayMember = "nome";

            cbbCliente.SelectedIndex = -1;
        }
        #endregion

        #region Exportar Excel
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exportar para EXCEL ?", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
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
                }
            }
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

                if (cbbCliente.Text == "")
                {
                    da.SelectCommand.CommandText = "SELECT R.ficha, R.codigocliente, R.valor, R.parcela, R.datacadastro, R.datavencimento, R.baixado FROM contasareceber AS R INNER JOIN cadcliente AS C ON codigocliente = C.codigo where datacadastro >= @ven_data and datacadastro <= @ven_data2";
                    
                }
                /*
                else if (cbbCliente.Text.Length > 0)
                {
                    da.SelectCommand.CommandText = "select b.cadcliente_codigo, b.nome, p.codigo, p.descricao, p.marca, e.preco, e.estoque_qtd, e.baixa_codigo, b.datab as datavenda from produto as p right join estoque as e on p.codigo = e.produto_codigo left join baixa as b on e.baixa_codigo = b.codigo where b.nome = @c_codigo and datab >= @ven_data and datab <= @ven_data2";
                }*/

                //parametros
                da.SelectCommand.Parameters.AddWithValue("@ven_data", datavendas.Text);
                da.SelectCommand.Parameters.AddWithValue("@ven_data2", dataVendas2.Text);
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
    }
}