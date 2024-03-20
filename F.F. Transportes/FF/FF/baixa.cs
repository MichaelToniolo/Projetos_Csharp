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
    public partial class baixa : Form
    {
        //int forcod;

        public baixa()
        {
            InitializeComponent();
        }

        #region Botão Inserir
        private void btninserir_Click(object sender, EventArgs e)
        {
            if (txtnf.TextLength == 0)
            {
                MessageBox.Show("Selecione uma NF", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = conexao.conexaoBancoDados;

                    con.Open();

                    if (txtfornecedor.TextLength > 0)
                    {
                        //preparar a ListView para inserção dos produtos
                        ListViewItem item = new ListViewItem(txtfornecedor.Text);
                        int quantidade = Convert.ToInt32(txtnf.Text);

                        if (quantidade > 0)
                        {

                            //adicionar subitem no ListView
                            item.SubItems.Add(Convert.ToString(txtnf.Text));
                            item.SubItems.Add(Convert.ToString(txtvolume.Text));
                            item.SubItems.Add(Convert.ToString(txtcidade.Text));
                            item.SubItems.Add(Convert.ToString(txtvalor.Text));
                            item.SubItems.Add(Convert.ToString(txtmotorista.Text));
                            item.SubItems.Add(Convert.ToString(txtrecebedor.Text));
                            item.SubItems.Add(Convert.ToString(txtcaminhao.Text));

                            //colocar objetos na ListView
                            this.listaentrada.Items.Add(item);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {

                    txtnf.Focus();
                    con.Close();
                }
            }
        }
        #endregion       

        #region Botão Excluir

        private void btnexcluir_Click(object sender, EventArgs e)
        {
              
            {
                if (listaentrada.SelectedItems.Count != 0)
                {

                    listaentrada.Items.RemoveAt(Convert.ToInt32(listaentrada.SelectedIndices[0].ToString()));

                }
                else
                {
                    MessageBox.Show("Escolha Produto Para Remover ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        #endregion       

        #region Botão Expedicao
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPendentes f = new frmPendentes();
            f.ShowDialog();
            txtnf.Text = f.nf;
            txtfornecedor.Text = f.fornecedor;
            txtvalor.Text = f.valor;
            txtcidade.Text = f.cidade;
            txtvolume.Text = f.volume;

            f.Close();
        }
        #endregion

        #region Load
        private void baixa_Load(object sender, EventArgs e)
        {
            listaentrada.View = System.Windows.Forms.View.Details;
            listaentrada.FullRowSelect = true;
            listaentrada.Columns.Add("Fornecedor", 70, HorizontalAlignment.Center);
            listaentrada.Columns.Add("NF", 100, HorizontalAlignment.Left);
            listaentrada.Columns.Add("Volume", 100, HorizontalAlignment.Left);
            listaentrada.Columns.Add("Cidade", 100, HorizontalAlignment.Left);
            listaentrada.Columns.Add("Valor NF", 100, HorizontalAlignment.Left);
            listaentrada.Columns.Add("Motorista", 100, HorizontalAlignment.Left);
            listaentrada.Columns.Add("Recebedor", 100, HorizontalAlignment.Left);
            listaentrada.Columns.Add("Caminhão", 100, HorizontalAlignment.Left);
        }
        #endregion

        #region Botão Finalizar
        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                baixainformation en = new baixainformation();

                //conexão
                con.ConnectionString = conexao.conexaoBancoDados;

                // Abrir conexão
                con.Open();

                if (listaentrada.Items.Count > 0)
                {
                    foreach (ListViewItem item in listaentrada.Items)
                    {
                        string fornecedor = Convert.ToString(item.SubItems[0].Text);
                        string nf = Convert.ToString(item.SubItems[1].Text);
                        string volume = Convert.ToString(item.SubItems[2].Text);
                        string cidade = Convert.ToString(item.SubItems[3].Text);
                        string valor = Convert.ToString(item.SubItems[4].Text);
                        string moto = Convert.ToString(item.SubItems[5].Text);
                        string rece = Convert.ToString(item.SubItems[6].Text);
                        string camin = Convert.ToString(item.SubItems[7].Text);

                        en.Data = Convert.ToDateTime(datacadastro.Value);
                        en.Cidade = cidade;
                        en.Fornecedor = fornecedor;
                        en.Nota = nf;
                        en.Volume = Convert.ToInt32(volume);
                        en.Motorista = moto;
                        en.Valor = Convert.ToDecimal(valor);
                        en.Recebedor = rece;
                        en.Caminhao = camin;

                        //command
                        SqlCommand cmde = new SqlCommand();
                        cmde.Connection = con;
                        cmde.CommandType = CommandType.Text;
                        cmde.CommandText = "insert into baixa(volume, fornecedor, cidade, databaixa, nota, motorista, valor, recebedor, caminhao ) values (@volume, @fornecedor, @cidade, @databaixa, @nota, @motorista, @valor, @recebedor, @caminhao) select SCOPE_IDENTITY()";



                        cmde.Parameters.AddWithValue("@codigo", en.Codigo);
                        cmde.Parameters.AddWithValue("@volume", en.Volume);
                        cmde.Parameters.AddWithValue("@fornecedor", en.Fornecedor);
                        cmde.Parameters.AddWithValue("@cidade", en.Cidade);
                        cmde.Parameters.AddWithValue("@databaixa", en.Data);
                        cmde.Parameters.AddWithValue("@nota", en.Nota);                       
                        cmde.Parameters.AddWithValue("@motorista", en.Motorista);
                        cmde.Parameters.AddWithValue("@valor", en.Valor);
                        cmde.Parameters.AddWithValue("@recebedor", en.Recebedor);
                        cmde.Parameters.AddWithValue("@caminhao", en.Caminhao);


                        int ven_cod = Convert.ToInt32(cmde.ExecuteScalar());
                        en.Codigo = ven_cod;
                        
                    }

                    MessageBox.Show("ENTRADA EFETUADA COM SUCESSO" + " " + "CODIGO" + " ", "Baixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limpatela();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
        