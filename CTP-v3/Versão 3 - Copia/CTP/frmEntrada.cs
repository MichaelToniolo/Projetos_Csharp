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
    public partial class frmEntrada : Form
    {
        string co;

        public frmEntrada()
        {
            InitializeComponent();
        }
        #region Inserir
        private void btninserir_Click(object sender, EventArgs e)
        {
            if (txtnome.TextLength == 0)
            {
                MessageBox.Show("Selecione um Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                if (txtestoque.Text.Length == 0)
                {
                    MessageBox.Show("A quantidade não pode ser igual a 0", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    con.Open();



                    //verificar se tem o produto no estoque
                    if (txtcodigopro.TextLength > 0)
                    {
                        //preparar a ListView para inserção dos produtos
                        ListViewItem item = new ListViewItem(txtcodigopro.Text);
                        int quantidade = Convert.ToInt32(txtestoque.Text);

                        if (quantidade > 0)
                        {

                            //adicionar subitem no ListView
                            item.SubItems.Add(Convert.ToString(txtnome.Text));
                            item.SubItems.Add(Convert.ToString(txtmarca.Text));
                            item.SubItems.Add(Convert.ToString(quantidade));

                            //colocar objetos na ListView
                            this.listaentrada.Items.Add(item);

                        }
                        else
                        {
                            throw new Exception("Quantidade insuficiente no estoque");
                        }
                    }
                    else
                    {
                        throw new Exception("Quantidade insuficiente no estoque");
                    }
                }
                catch (Exception )
                {
                    //MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {

                    txtnome.Focus();
                    con.Close();
                }
            }

        }

        #endregion

        #region Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto pro = new frmPesquisaProduto();
            pro.ShowDialog();
            txtcodigopro.Text = pro.codigo;
            txtnome.Text = pro.descricao;
            txtmarca.Text = pro.marca;
            pro.Close();
        }
        #endregion

        #region Botão Excluir
        private void btnexcluir_Click(object sender, EventArgs e)
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
        #endregion

        #region Load
        private void frmEntrada_Load(object sender, EventArgs e)
        {
            limpatela();

            listaentrada.View = System.Windows.Forms.View.Details;
            listaentrada.FullRowSelect = true;
            listaentrada.Columns.Add("Codigo", 70, HorizontalAlignment.Center);
            listaentrada.Columns.Add("Descricao", 100, HorizontalAlignment.Left);
            listaentrada.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            listaentrada.Columns.Add("Quantidade", 100, HorizontalAlignment.Left);
        }
        #endregion

        #region Metodo Limpa tela
        public void limpatela()
        {
            txtcodigo.Clear();
            txtcodigopro.Clear();
            datacadastro.ResetText();
            txtestoque.Clear();
            txtmarca.Clear();
            txtnome.Clear();
            listaentrada.Items.Clear();
        }
        #endregion

        #region Botão Limpa Tela
        private void btnlimpatela_Click(object sender, EventArgs e)
        {
            limpatela();
        }
        #endregion

        #region Botão Finalizar
        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                entradainformation en = new entradainformation();

                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;
                // Abrir conexão
                con.Open();


                if (listaentrada.Items.Count > 0)
                {
                    foreach (ListViewItem item in listaentrada.Items)
                    {
                        string codigoProduto = Convert.ToString(item.SubItems[0].Text);
                        string descricaoProduto = Convert.ToString(item.SubItems[1].Text);
                        string marcaProduto = Convert.ToString(item.SubItems[2].Text);
                        string quantidadeProduto = Convert.ToString(item.SubItems[3].Text);

                        en.Data = datacadastro.Value;
                        en.Produto_codigo = Convert.ToInt32(codigoProduto);
                        en.Quantidade = Convert.ToInt32(quantidadeProduto);


                        //command
                        SqlCommand cmde = new SqlCommand();
                        cmde.Connection = con;
                        cmde.CommandType = CommandType.Text;
                        cmde.CommandText = "insert into entrada(data, produto_codigo, quantidade) values (@data, @produto_codigo, @quantidade) select SCOPE_IDENTITY()";



                        //cmde.Parameters.AddWithValue("@codigo", en.Codigo);
                        cmde.Parameters.AddWithValue("@data", en.Data);
                        cmde.Parameters.AddWithValue("@produto_codigo", en.Produto_codigo);
                        cmde.Parameters.AddWithValue("@quantidade", en.Quantidade);

                        int ven_cod = Convert.ToInt32(cmde.ExecuteScalar());
                        en.Codigo = ven_cod;

                        //parametros

                        ProdutoInformation usu = new ProdutoInformation();
                        usu.Pr_codigo = Convert.ToInt32(codigoProduto);
                        usu.Pr_quantidade = Convert.ToInt32(quantidadeProduto);
                        usu.Pr_marca = marcaProduto;
                        usu.Pr_descricao = descricaoProduto;

                        // command
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update Produto set quantidade = quantidade + @quantidade where descricao = @prod_nome";

                        //parametros
                        cmd.Parameters.AddWithValue("@quantidade", usu.Pr_quantidade);
                        cmd.Parameters.AddWithValue("@prod_nome", usu.Pr_descricao);

                        //executar query

                        cmd.ExecuteNonQuery();
                        co = Convert.ToString(en.Codigo);

                        

                        cmd.Parameters.RemoveAt("@quantidade");
                        cmd.Parameters.RemoveAt("@prod_nome");
                    }

                    MessageBox.Show("ENTRADA EFETUADA COM SUCESSO" + " " + "CODIGO" +" "+ co + " ", "Baixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpatela();
                }
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Botão Retornar
        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA RETORNAR AO MENU ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
            {
                this.Close();
            }
        }
        #endregion

    }
}
