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
    public partial class frmPendentes : Form
    {
        public string codigo, marca, nome, t, nf, fornecedor, valor, data, cidade, volume;
        //public DateTime data;

        public frmPendentes()
        {
            InitializeComponent();
        }

        private void frmPendentes_Load(object sender, EventArgs e)
        {
            dtgPesquisaNfe.DataSource = AtualizaGrid(txtfiltro.Text);

          //t = dtgPesquisaNfe[2, dtgPesquisaNfe.CurrentRow.Index].Value.ToString();

           
                   marca = dtgPesquisaNfe[2, dtgPesquisaNfe.CurrentCell.RowIndex].Value.ToString();

               

                   //cabeçalho datagrid
                   dtgPesquisaNfe.Columns[0].HeaderText = "Emissão";
                   dtgPesquisaNfe.Columns[1].HeaderText = "Nfe";
                   dtgPesquisaNfe.Columns[2].HeaderText = "Fornecedor";
                   dtgPesquisaNfe.Columns[3].HeaderText = "Valor";
                   dtgPesquisaNfe.Columns[4].HeaderText = "Status";
                   dtgPesquisaNfe.Columns[5].HeaderText = "Cidade";
                   dtgPesquisaNfe.Columns[6].HeaderText = "Volume";
                   
                   //largura das colunas
                   dtgPesquisaNfe.Columns[0].Width = 100;
                   dtgPesquisaNfe.Columns[1].Width = 60;
                   dtgPesquisaNfe.Columns[2].Width = 240;
                   dtgPesquisaNfe.Columns[3].Width = 100;
                   dtgPesquisaNfe.Columns[4].Width = 260;
                   dtgPesquisaNfe.Columns[5].Width = 260;
                   dtgPesquisaNfe.Columns[6].Width = 260;

                   //permissões da datagrid
                   dtgPesquisaNfe.ReadOnly = true;
                   dtgPesquisaNfe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                   dtgPesquisaNfe.AllowUserToAddRows = false;
                   dtgPesquisaNfe.AllowUserToDeleteRows = false;
                   dtgPesquisaNfe.AllowUserToResizeColumns = false;
                   dtgPesquisaNfe.AllowUserToResizeRows = false;
               
            
        }

        #region Atualiza Grid

        public DataTable AtualizaGrid(string filtro)
        {
            SqlConnection con = new SqlConnection();
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


                        //if("PENDENTE")

                        da.SelectCommand.CommandText = "select e.dataentrada, e.nf, e.fornecedor, e.valor, ISNULL(p.nota, 'PENDENTE' ), e.cidade, e.volume as NotaB from baixa as p right join entrada as e on p.nota = e.nf where E.nf <> ISNULL(P.nota,'0')";


                    }
                    /*else
                    {
                        da.SelectCommand.CommandText = "select e.nf, e.fornecedor, ISNULL(p.nota, 'PENDENTE' ) as NotaB from baixa as p right join entrada as e on p.nota = e.nf where p.nota like '%' + @prod_cnpj";

                        // Parametros
                        //da.SelectCommand.Parameters.AddWithValue("@prod_nome", filtro);
                        //da.SelectCommand.Parameters.AddWithValue("@prod_cod", filtro);
                        //da.SelectCommand.Parameters.AddWithValue("@prod_cpf", filtro);
                        da.SelectCommand.Parameters.AddWithValue("@prod_cnpj", filtro);
                        //da.SelectCommand.Parameters.AddWithValue("@prod_cidade", filtro);
                        //da.SelectCommand.Parameters.AddWithValue("@prod_tipo", filtro);
                    }*/

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

        private void dtgPesquisaNfe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            data = dtgPesquisaNfe[0, dtgPesquisaNfe.CurrentRow.Index].Value.ToString();
            nf = dtgPesquisaNfe[1, dtgPesquisaNfe.CurrentRow.Index].Value.ToString();
            fornecedor = dtgPesquisaNfe[2, dtgPesquisaNfe.CurrentRow.Index].Value.ToString();
            valor = dtgPesquisaNfe[3, dtgPesquisaNfe.CurrentRow.Index].Value.ToString();
            cidade = dtgPesquisaNfe[5, dtgPesquisaNfe.CurrentRow.Index].Value.ToString();
            volume = dtgPesquisaNfe[6, dtgPesquisaNfe.CurrentRow.Index].Value.ToString();
            

            this.Close();
        }
    }
}
