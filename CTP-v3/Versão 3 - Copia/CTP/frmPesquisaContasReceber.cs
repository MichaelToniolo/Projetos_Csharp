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
    public partial class frmPesquisaContasReceber : Form
    {
        public frmPesquisaContasReceber()
        {
            InitializeComponent();
        }

        public string codigo, ficha, nome, parcela, valor, especie, datavencimento, prazo, baixado;

        #region Load
        private void frmPesquisaContasReceber_Load(object sender, EventArgs e)
        {
            dtgPesquisaFicha.DataSource = AtualizaGrid(txtfiltro.Text);
            
            // cabeçalho datagrid
            dtgPesquisaFicha.Columns[0].HeaderText = "CODIGO";
            dtgPesquisaFicha.Columns[1].HeaderText = "FICHA";
            dtgPesquisaFicha.Columns[2].HeaderText = "CLIENTE";
            dtgPesquisaFicha.Columns[3].HeaderText = "PARCELA";
            dtgPesquisaFicha.Columns[4].HeaderText = "VALOR";
            dtgPesquisaFicha.Columns[5].HeaderText = "ESPECIE";
            dtgPesquisaFicha.Columns[6].HeaderText = "VENCIMENTO";
            dtgPesquisaFicha.Columns[7].HeaderText = "PRAZO";
            dtgPesquisaFicha.Columns[8].HeaderText = "BAIXADO";


            //largura das colucas
            dtgPesquisaFicha.Columns[0].Width = 60;
            dtgPesquisaFicha.Columns[1].Width = 80;
            dtgPesquisaFicha.Columns[2].Width = 220;
            dtgPesquisaFicha.Columns[3].Width = 60;
            dtgPesquisaFicha.Columns[4].Width = 100;
            dtgPesquisaFicha.Columns[5].Width = 130;
            dtgPesquisaFicha.Columns[6].Width = 150;
            dtgPesquisaFicha.Columns[7].Width = 50;
            dtgPesquisaFicha.Columns[8].Width = 80;
            
            //permissões da datagrid
            dtgPesquisaFicha.ReadOnly = true;
            dtgPesquisaFicha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPesquisaFicha.AllowUserToAddRows = false;
            dtgPesquisaFicha.AllowUserToDeleteRows = false;
            dtgPesquisaFicha.AllowUserToResizeColumns = false;
            dtgPesquisaFicha.AllowUserToResizeRows = false;
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
                    da.SelectCommand.CommandText = "select cv.codigo, cv.ficha, cl.nome, cv.parcela, cv.valor, cv.especie, cv.datavencimento, cv.prazo, cv.baixado FROM contasareceber as cv INNER JOIN cadcliente as cl on cl.codigo = cv.codigocliente";

                }
                else
                {
                    da.SelectCommand.CommandText = "select cv.codigo, cv.ficha, cl.nome, cv.parcela, cv.valor, cv.especie, cv.datavencimento, cv.prazo, cv.baixado FROM contasareceber as cv INNER JOIN cadcliente as cl on cl.codigo = cv.codigocliente where cl.nome like '%' + @cl_nome + '%' or cv.ficha like '%' + @cr_ficha + '%' or cv.especie like '%' + @cr_especie + '%' or cv.datavencimento like '%' + @cr_datavencimento + '%'";
                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@cl_nome", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@cr_ficha", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@cr_especie", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@cr_datavencimento", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@cr_prazo", filtro);
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

        #region Filtro DataGridView
        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            dtgPesquisaFicha.DataSource = AtualizaGrid(txtfiltro.Text);
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

        private void dtgPesquisaFicha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dtgPesquisaFicha[0, dtgPesquisaFicha.CurrentRow.Index].Value.ToString();
            ficha = dtgPesquisaFicha[1, dtgPesquisaFicha.CurrentRow.Index].Value.ToString();
            nome = dtgPesquisaFicha[2, dtgPesquisaFicha.CurrentRow.Index].Value.ToString();
            parcela = dtgPesquisaFicha[3, dtgPesquisaFicha.CurrentRow.Index].Value.ToString();
            valor = dtgPesquisaFicha[4, dtgPesquisaFicha.CurrentRow.Index].Value.ToString();
            especie = dtgPesquisaFicha[5, dtgPesquisaFicha.CurrentRow.Index].Value.ToString();
            datavencimento = dtgPesquisaFicha[6, dtgPesquisaFicha.CurrentRow.Index].Value.ToString();
            prazo = dtgPesquisaFicha[7, dtgPesquisaFicha.CurrentRow.Index].Value.ToString();
            baixado = dtgPesquisaFicha[8, dtgPesquisaFicha.CurrentRow.Index].Value.ToString();
            this.Close();
        }
    }
}
