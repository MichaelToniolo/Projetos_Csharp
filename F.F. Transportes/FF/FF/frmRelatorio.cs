using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Root.Reports;


namespace FF
{


    public partial class frmRelatorio : Form
    {
        decimal preco, total = 0;

        public frmRelatorio()
        {
            InitializeComponent();
        }

        #region Lista Venda
        public DataTable cons(string data)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                //conexão
                con.ConnectionString = conexao.conexaoBancoDados;

                //command
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (cbbCliente.Text == "" && cbbProduto.Text == "")
                {
                    da.SelectCommand.CommandText = "select p.fornecedor, p.nota, p.valor, p.cidade, p.recebedor, p.motorista, p.caminhao, p.volume, p.codigo as codigo from baixa as p where databaixa >= @ven_data and databaixa <= @ven_data2";
                }
                else if (cbbProduto.Text.Length > 0)
                {
                    da.SelectCommand.CommandText = "select p.fornecedor, p.nota, p.valor, p.cidade, p.recebedor, p.motorista, p.caminhao, p.volume, p.codigo as codigo from baixa as p where fornecedor = @p_codigo and databaixa >= @ven_data and databaixa <= @ven_data2";
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

        #region Botão Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string dataform = datavendas.Text;
            string dataform2 = dataVendas2.Text;
            dgvconsulta.DataSource = cons(dataform);
            dgvconsulta.DataSource = cons(dataform2);

            //atualiza grid
            dgvconsulta.Columns[0].HeaderText = "Fornecedor";
            dgvconsulta.Columns[0].Width = 200;
            dgvconsulta.Columns[1].HeaderText = "Nota";
            dgvconsulta.Columns[1].Width = 150;
            dgvconsulta.Columns[2].HeaderText = "Valor";
            dgvconsulta.Columns[2].Width = 150;
            dgvconsulta.Columns[3].HeaderText = "Cidade";
            dgvconsulta.Columns[3].Width = 100;
            dgvconsulta.Columns[4].HeaderText = "Recebedor";
            dgvconsulta.Columns[4].Width = 100;
            dgvconsulta.Columns[5].HeaderText = "Motorista";
            dgvconsulta.Columns[5].Width = 100;
            dgvconsulta.Columns[6].HeaderText = "Caminhão";
            dgvconsulta.Columns[6].Width = 100;
            dgvconsulta.Columns[7].HeaderText = "Volume";
            dgvconsulta.Columns[7].Width = 100;
            dgvconsulta.Columns[8].HeaderText = "Codigo";
            dgvconsulta.Columns[8].Width = 100;



            //Permisão da data Grid
            dgvconsulta.ReadOnly = true;
            dgvconsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvconsulta.AllowDrop = false;
            dgvconsulta.AllowUserToAddRows = false;
            dgvconsulta.AllowUserToDeleteRows = false;
            dgvconsulta.AllowUserToOrderColumns = false;
            dgvconsulta.AllowUserToResizeColumns = false;
            dgvconsulta.AllowUserToResizeRows = false;

            for (int i = 0; i < dgvconsulta.Rows.Count; i++)
            {
                preco = Convert.ToDecimal(dgvconsulta.Rows[i].Cells[2].Value);
                total = total + preco;
                TbxReceita.Text = total.ToString("C");

            }
        }
        #endregion

        #region Botão Pesquisa Fornecedor
        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            frmpesquisafornecedor pqp = new frmpesquisafornecedor();
            pqp.ShowDialog();
            cbbProduto.Text = pqp.nome;
            pqp.Close();
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog(); // novo



            Excel.Application App; // Aplicação Excel
            Excel.Workbook WorkBook; // Pasta
            Excel.Worksheet WorkSheet; // Planilha
            object misValue = System.Reflection.Missing.Value;

            App = new Excel.Application();
            WorkBook = App.Workbooks.Add(misValue);
            WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            // passa as celulas do DataGridView para a Pasta do Excel
            for (i = 0; i <= dgvconsulta.RowCount - 1; i++)
            {
                for (j = 0; j <= dgvconsulta.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgvconsulta[j, i];
                    WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            // define algumas propriedades da caixa salvar
            salvar.Title = "Exportar para Excel";
            salvar.Filter = "Arquivo do Excel *.xls | *.xls";
            salvar.ShowDialog(); // mostra

            // salva o arquivo
            WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            WorkBook.Close(true, misValue, misValue);
            App.Quit(); // encerra o excel

            MessageBox.Show("Exportado com sucesso!");
        }

       /* private void button2_Click_1(object sender, EventArgs e)
        {
            // Variavel do Nome e caminho do arquivo
            string vArq = "";
            // Abre janela para usuário escolher a pasta onde o arquivo será gerado
            FolderBrowserDialog vSalvar = new FolderBrowserDialog();
            // Verifica se o usuário clicou em ok ou cancelar na janela de seleção da pasta
            if (vSalvar.ShowDialog() == DialogResult.Cancel)
                return; // Cancela todo processo
            // Insere na variavel o caminho selecionado pelo usuário e concatena com o nome do arquivo
            vArq = vSalvar.SelectedPath + "\\" + txtNomeArquivo.Text.Trim() + ".pdf";
            try
            {
                // Cria um objeto PDF
                Report vPdf = new Report(new PdfFormatter());
                // Define a fonte que sera usada no relatório PDF
                FontDef vDef = new FontDef(vPdf, FontDef.StandardFont.TimesRoman);
                FontProp vDrop = new FontProp(vDef, 12);
                // Cria uma Nova Pagina
                Page vPage = new Page(vPdf);
                // Escreve no Arquivo
                
                vPage.AddCB_MM(5, new RepString(vDrop, dgvconsulta.DataSource.ToString())); // Centraliza
               
                // Salvar Arquivo no disco
                vPdf.Save(vArq);
                MessageBox.Show("Arquivo Gerado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Gerar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }*/

       
    }
}
