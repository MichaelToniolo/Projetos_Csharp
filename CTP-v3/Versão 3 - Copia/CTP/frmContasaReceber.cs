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
    public partial class frmContasaReceber : Form
    {
        public frmContasaReceber()
        {
            InitializeComponent();
        }

        #region Botão Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (txtFicha.TextLength == 0)
            {
                if (MessageBox.Show("DESEJA RETORNAR AO MENU ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Limpe a Tela Para Retornar");
            }
        }
        #endregion

        #region Botão Limpa tela
        private void btnLimpaTela_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
        #endregion

        #region Método Limpa Tela
        public void LimpaTela()
        {
            cbbEspecie.SelectedIndex = -1;
            btnInserir.Enabled = true;
            cbbCliente.SelectedIndex = -1;
            txtFiltro.Clear();
            txtFicha.Clear();
            txtParcela.Clear();
            txtValor.Clear();
            dtpCadastro.ResetText();
            dtpVencimento.ResetText();
            cbbBaixado.SelectedIndex = -1;
            txtCodigo.Clear();
            txtIntervalo.Clear();

        }
        #endregion

        #region Botão Adicionar
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtFicha.Text.Length > 0 && cbbCliente.Text.Length > 0 && txtParcela.Text.Length > 0 && txtValor.Text.Length > 0 && dtpVencimento.Text.Length > 0)
            {


                contasinformation cre = new contasinformation();
                cre.Cr_codigocliente = (int)cbbCliente.SelectedValue;
                cre.Cr_datacadastro = Convert.ToDateTime(dtpCadastro.Text);
                cre.Cr_ficha = Convert.ToInt32(txtFicha.Text);
                cre.Cr_baixado = Convert.ToChar(cbbBaixado.Text);
                cre.Cr_especie = cbbEspecie.Text;

                int p = Convert.ToInt32(txtParcela.Text);
                cre.Cr_valor = Convert.ToDecimal(txtValor.Text) / p;
                int intervalo = Convert.ToInt32(txtIntervalo.Text);
                cre.Cr_prazo = intervalo;

                //Parcela
                while (p != 0)
                {
                    DateTime vencimento = new DateTime();
                    vencimento = Convert.ToDateTime(dtpVencimento.Text);
                    switch (p)
                    {
                        case 1:
                            cre.Cr_parcela = Convert.ToChar("A");
                            cre.Cr_datavencimento = vencimento;
                            break;
                        case 2:
                            cre.Cr_parcela = Convert.ToChar("B");
                            cre.Cr_datavencimento = vencimento.AddDays(intervalo);
                            break;
                        case 3:
                            cre.Cr_parcela = Convert.ToChar("C");
                            cre.Cr_datavencimento = vencimento.AddDays(intervalo * p);
                            break;
                        case 4:
                            cre.Cr_parcela = Convert.ToChar("D");
                            cre.Cr_datavencimento = vencimento.AddDays(intervalo * p);
                            break;
                        case 5:
                            cre.Cr_parcela = Convert.ToChar("E");
                            cre.Cr_datavencimento = vencimento.AddDays(intervalo * p);
                            break;
                        case 6:
                            cre.Cr_parcela = Convert.ToChar("F");
                            cre.Cr_datavencimento = vencimento.AddDays(intervalo * p);
                            break;
                        case 7:
                            cre.Cr_parcela = Convert.ToChar("G");
                            cre.Cr_datavencimento = vencimento.AddDays(intervalo * p);
                            break;
                        case 8:
                            cre.Cr_parcela = Convert.ToChar("H");
                            cre.Cr_datavencimento = vencimento.AddDays(intervalo * p);
                            break;
                        case 9:
                            cre.Cr_parcela = Convert.ToChar("I");
                            cre.Cr_datavencimento = vencimento.AddDays(intervalo * p);
                            break;
                        case 10:
                            cre.Cr_parcela = Convert.ToChar("J");
                            cre.Cr_datavencimento = vencimento.AddDays(intervalo * p);
                            break;
                        case 11:
                            cre.Cr_parcela = Convert.ToChar("K");
                            cre.Cr_datavencimento = vencimento.AddDays(intervalo * p);
                            break;
                        case 12:
                            cre.Cr_parcela = Convert.ToChar("L");
                            cre.Cr_datavencimento = vencimento.AddDays(intervalo * p);
                            break;
                    }

                    SqlConnection con = new SqlConnection();
                    try
                    {

                        //conexão
                        con.ConnectionString = Dados.conexaoBancoDados;

                        //command
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into contasareceber (ficha, codigocliente, valor, parcela, datacadastro, datavencimento, baixado, especie, prazo) values (@cr_ficha, @cr_codigocliente, @cr_valor, @cr_parcela, @cr_datacadastro, @cr_datavencimento, @cr_baixado, @cr_especie, @cr_prazo)";

                        //parametros
                        //cmd.Parameters.AddWithValue("@cliente_codigo", usu.Cl_codigo);
                        cmd.Parameters.AddWithValue("@cr_ficha", cre.Cr_ficha);
                        cmd.Parameters.AddWithValue("@cr_codigocliente", cre.Cr_codigocliente);
                        cmd.Parameters.AddWithValue("@cr_valor", cre.Cr_valor);
                        cmd.Parameters.AddWithValue("@cr_parcela", cre.Cr_parcela);
                        cmd.Parameters.AddWithValue("@cr_datacadastro", cre.Cr_datacadastro);
                        cmd.Parameters.AddWithValue("@cr_datavencimento", cre.Cr_datavencimento);
                        cmd.Parameters.AddWithValue("@cr_baixado", cre.Cr_baixado);
                        cmd.Parameters.AddWithValue("@cr_especie", cre.Cr_especie);
                        cmd.Parameters.AddWithValue("@cr_prazo", cre.Cr_prazo);

                        // Abrir conexão
                        con.Open();


                        cmd.ExecuteNonQuery();

                        p--;


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK);
                        //MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {//executar query
                        //executar query

                        con.Close();
                        dtgContasReceber.DataSource = AtualizaGrid(txtFiltro.Text);
                    }
                }

                MessageBox.Show("Ficha Cadastrada Sucesso.", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LimpaTela();

        }
        #endregion

        #region Load
        private void frmContasaReceber_Load(object sender, EventArgs e)
        {
            cbbCliente.Enabled = true;
            cbbCliente.DataSource = PesquisaCliente();
            cbbCliente.ValueMember = "codigo";
            cbbCliente.DisplayMember = "nome";

            cbbCliente.SelectedIndex = -1;
            cbbBaixado.SelectedIndex = 0;

            txtFicha.Focus();

            dtgContasReceber.DataSource = AtualizaGrid(txtFiltro.Text);

            //Cabeçalho da datagrid
            //dtgContasReceber.Columns[0].HeaderText = "Codigo";
            dtgContasReceber.Columns[0].HeaderText = "Ficha";
            dtgContasReceber.Columns[1].HeaderText = "Cliente";
            dtgContasReceber.Columns[2].HeaderText = "Parcela";
            dtgContasReceber.Columns[3].HeaderText = "Valor";
            dtgContasReceber.Columns[4].HeaderText = "Especie";
            dtgContasReceber.Columns[5].HeaderText = "Vencimento";
            dtgContasReceber.Columns[6].HeaderText = "Prazo";
            dtgContasReceber.Columns[7].HeaderText = "Baixado";


            //Largura das colunas
            dtgContasReceber.Columns[0].Width = 60;
            dtgContasReceber.Columns[1].Width = 200;
            dtgContasReceber.Columns[2].Width = 50;
            dtgContasReceber.Columns[3].Width = 50;
            dtgContasReceber.Columns[4].Width = 60;
            dtgContasReceber.Columns[5].Width = 80;
            dtgContasReceber.Columns[6].Width = 50;
            dtgContasReceber.Columns[7].Width = 50;


            //Permissões da datagrid
            dtgContasReceber.ReadOnly = true;
            dtgContasReceber.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgContasReceber.AllowUserToAddRows = false;
            dtgContasReceber.AllowUserToDeleteRows = false;
            dtgContasReceber.AllowUserToResizeColumns = true;
            dtgContasReceber.AllowUserToResizeRows = false;

            //Travando Data
            dtpCadastro.Enabled = false;
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
                    da.SelectCommand.CommandText = "select cv.ficha, cl.nome, cv.parcela, cv.valor, cv.especie, cv.datavencimento, cv.prazo, cv.baixado FROM contasareceber as cv INNER JOIN cadcliente as cl on cl.codigo = cv.codigocliente";

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

        #region Metodo Pesquisa Cliente
        public DataTable PesquisaCliente()
        {

            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //dataadpter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = "select codigo, nome from cadcliente where tipo = 'cliente' and statuscliente = 'Ativo' order by nome";

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtFicha.Text.Length == 0)
            {
                MessageBox.Show("Selecione uma ficha para alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dtpVencimento.Text.Length > 0)
            {
                if (MessageBox.Show("Deseja alterar o vencimento da Duplicata ?", "Vencimento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                {
                    contasinformation cr = new contasinformation();
                    cr.Cr_codigo = Convert.ToInt32(txtCodigo.Text);
                    cr.Cr_datavencimento = Convert.ToDateTime(dtpVencimento.Text);
                    cr.Cr_baixado = Convert.ToChar(cbbBaixado.Text);
                    cr.Cr_valor = Convert.ToDecimal(txtValor.Text);
                    cr.Cr_ficha = Convert.ToInt32(txtFicha.Text);
                    cr.Cr_codigocliente = (int)cbbCliente.SelectedValue;
                    cr.Cr_especie = cbbEspecie.Text;
                    cr.Cr_prazo = Convert.ToInt32(txtIntervalo.Text);

                    SqlConnection con = new SqlConnection();
                    try
                    {
                        //conexão
                        con.ConnectionString = Dados.conexaoBancoDados;

                        //command
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update contasareceber set datavencimento = @cr_datavencimento, baixado = @cr_baixado, valor = @cr_valor, ficha = @cr_ficha, codigocliente = @cr_codigocliente, especie = @cr_especie, prazo = @cr_prazo where codigo = @cr_codigo";

                        //Parametros
                        cmd.Parameters.AddWithValue("@cr_codigo", cr.Cr_codigo);
                        cmd.Parameters.AddWithValue("@cr_datavencimento", cr.Cr_datavencimento);
                        cmd.Parameters.AddWithValue("@cr_baixado", cr.Cr_baixado);
                        cmd.Parameters.AddWithValue("@cr_valor", cr.Cr_valor);
                        cmd.Parameters.AddWithValue("@cr_ficha", cr.Cr_ficha);
                        cmd.Parameters.AddWithValue("@cr_codigocliente", cr.Cr_codigocliente);
                        cmd.Parameters.AddWithValue("@cr_especie", cr.Cr_especie);
                        cmd.Parameters.AddWithValue("@cr_prazo", cr.Cr_prazo);

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
                        dtgContasReceber.DataSource = AtualizaGrid(txtFiltro.Text);
                    }
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaContasReceber p = new frmPesquisaContasReceber();
            p.ShowDialog();

            txtCodigo.Text = p.codigo;
            txtFicha.Text = p.ficha;
            txtParcela.Text = p.parcela;
            txtValor.Text = p.valor;
            cbbEspecie.Text = p.especie;
            dtpVencimento.Text = p.datavencimento;
            cbbCliente.Text = p.nome;
            txtIntervalo.Text = p.prazo;
            cbbBaixado.Text = p.baixado;

            txtParcela.Enabled = false;


        }

        #region Botão Pesquisa Cliente
        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            PesquisaCliente pro = new PesquisaCliente();
            pro.ShowDialog();
            cbbCliente.Text = pro.nome;
            pro.Close();
        }
        #endregion

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.TextLength > 0)
            {
                contasinformation cr = new contasinformation();
                cr.Cr_codigo = Convert.ToInt32(txtCodigo.Text);


                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    //command
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from contasareceber where codigo = @cr_codigo";

                    //parametros
                    cmd.Parameters.AddWithValue("@cr_codigo", cr.Cr_codigo);


                    //Abrir conexão
                    con.Open();

                    if (MessageBox.Show("Confirma Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //executar query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Excluido com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaTela();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    dtgContasReceber.DataSource = AtualizaGrid(txtFiltro.Text);
                }
            }
            else
            {
                MessageBox.Show("Selecione a Duplicata Para Excluir", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exportar para EXCEL ?", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
            {


                if (dtgContasReceber.Rows.Count == 0)
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
                    for (j = 0; j < dtgContasReceber.ColumnCount; j++)
                    {
                        WorkSheet.Cells[1, j + 1] = dtgContasReceber.Columns[j].HeaderText;
                    }
                    for (i = 1; i <= dtgContasReceber.RowCount; i++)
                    {
                        for (j = 0; j < dtgContasReceber.ColumnCount; j++)
                        {
                            DataGridViewCell cell = dtgContasReceber[j, i - 1];
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
    }
}