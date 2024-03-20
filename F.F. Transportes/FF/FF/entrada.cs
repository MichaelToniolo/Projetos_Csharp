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
    public partial class entrada : Form
    {
        int forcod;
        public entrada()
        {
            InitializeComponent();
        }

        #region Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmpesquisafornecedor f = new frmpesquisafornecedor();
            f.ShowDialog();
            txtfornecedor.Text = f.nome;
            forcod = Convert.ToInt32(f.codigo);
           

            f.Close();
        }
        #endregion

        #region botão Finalizar

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection();
            try
            {
                entradainformation en = new entradainformation();
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
                        //string forcodigo = Convert.ToString(item.SubItems[5].Text);

                        en.Dataentrada = Convert.ToDateTime(datacadastro.Value);
                        en.Cidade = cidade;
                        en.Fornecedor = fornecedor;
                        en.Nf = Convert.ToInt32(nf);
                        en.Volume = Convert.ToInt32(volume);
                        en.Codifornecedor = forcod;
                        en.Valor = Convert.ToDecimal(valor);


                        //command
                        SqlCommand cmde = new SqlCommand();
                        cmde.Connection = con;
                        cmde.CommandType = CommandType.Text;
                        cmde.CommandText = "insert into entrada(volume, fornecedor, cidade, dataentrada, nf, cadfornecedor_codigo, valor ) values (@volume, @fornecedor, @cidade, @dataentrada, @nf, @cadfornecedor_codigo, @valor) select SCOPE_IDENTITY()";



                        cmde.Parameters.AddWithValue("@codigo", en.Codigo);
                        cmde.Parameters.AddWithValue("@volume", en.Volume);
                        cmde.Parameters.AddWithValue("@fornecedor", en.Fornecedor);
                        cmde.Parameters.AddWithValue("@cidade", en.Cidade);
                        cmde.Parameters.AddWithValue("@dataentrada", en.Dataentrada);
                        cmde.Parameters.AddWithValue("@nf", en.Nf);
                        //cmde.Parameters.AddWithValue("@baixa_codigo", en.Baixacodigo);
                        cmde.Parameters.AddWithValue("@cadfornecedor_codigo", en.Codifornecedor);
                        cmde.Parameters.AddWithValue("@valor", en.Valor);


                        int ven_cod = Convert.ToInt32(cmde.ExecuteScalar());
                        en.Codigo = ven_cod;

                        
                    }

                    MessageBox.Show("ENTRADA EFETUADA COM SUCESSO" + " " + "CODIGO"  + " ", "Baixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                LimpaTela();
                listaentrada.Items.Clear();
                
                
            }
        }
        #endregion

        #region lista fornecedor
        public DataTable ListaCliente()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                //Conexão
                con.ConnectionString = conexao.conexaoBancoDados;

                //DataAdapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = "select codigo, fornecedor from cadfornecedor";

                //Preenher DataTable
                da.Fill(dt);
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

        #region Inserir

        private void btninserir_Click(object sender, EventArgs e)
        {



            if (txtcidade.Text.Length > 0 || +
                txtfornecedor.Text.Length > 0 || +
                txtnf.Text.Length > 0 || txtvalor.Text.Length > 0 || txtvolume.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = conexao.conexaoBancoDados;

                    con.Open();

                    entradainformation usu = new entradainformation();
                    usu.Fornecedor = txtfornecedor.Text;
                    usu.Nf = Convert.ToInt16(txtnf.Text);

                    //command
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select count(fornecedor) from entrada WHERE fornecedor = @txtfornecedor and nf = @txtnf";

                    // Parametros
                    cmd.Parameters.AddWithValue("@txtfornecedor", usu.Fornecedor);
                    cmd.Parameters.AddWithValue("@txtnf", usu.Nf);

                    // Abrir conexão

                    //executar query

                    cmd.ExecuteNonQuery();

                    


                    int quantidade;
                    quantidade = Convert.ToInt32(txtnf.Text);
                    int resultado;
                    resultado = Convert.ToInt32(cmd.ExecuteScalar());

                    //verificar Resuldado
                    if (resultado == 0 && quantidade > 0)
                    {
                        this.Visible = true;
                        ListViewItem item = new ListViewItem(txtfornecedor.Text);

                        //adicionar subitem no ListView
                        item.SubItems.Add(Convert.ToString(txtnf.Text));
                        item.SubItems.Add(Convert.ToString(txtvolume.Text));
                        item.SubItems.Add(Convert.ToString(txtcidade.Text));
                        item.SubItems.Add(Convert.ToString(txtvalor.Text));

                        //colocar objetos na ListView
                        this.listaentrada.Items.Add(item);

                    }


                    else
                    {
                        throw new Exception("Nota fiscal já cadastrada para este fornecedor.");
                    }
                }



                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }     
               
        #endregion

        #region botão excluir
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

        #region Load
        private void entrada_Load(object sender, EventArgs e)
        {

            txtfornecedor.DataSource = ListaCliente();
            txtfornecedor.ValueMember = "codigo";
            txtfornecedor.DisplayMember = "fornecedor";

            LimpaTela();
            
            listaentrada.View = System.Windows.Forms.View.Details;
            listaentrada.FullRowSelect = true;
            listaentrada.Columns.Add("Fornecedor", 70, HorizontalAlignment.Center);
            listaentrada.Columns.Add("NFe", 100, HorizontalAlignment.Left);
            listaentrada.Columns.Add("Volume", 100, HorizontalAlignment.Left);
            listaentrada.Columns.Add("Cidade", 100, HorizontalAlignment.Left);
            listaentrada.Columns.Add("Valor NFe", 100, HorizontalAlignment.Left);

           
        }
        #endregion

        #region Botão voltar
        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                LimpaTela();
            }
        }
        #endregion

        #region Botão Limpar
        private void btnlimpatela_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
        #endregion

        #region Método Limpa Tela
        public void LimpaTela()
        {

            txtvolume.Clear();
            txtvalor.Clear();
            txtnf.Clear();
            txtfornecedor.SelectedIndex = -1;
            txtcodigo.Clear();
            txtcidade.Clear();
            //listaentrada.Columns.Clear();
            //listaentrada.View = System.Windows.Forms.View.Details;
            
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
                con.ConnectionString = conexao.conexaoBancoDados;

                // data adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;



                if (filtro.Length == 0)
                {
                    da.SelectCommand.CommandText = "select codigo, fornecedor, nf, volume, cidade, valor from entrada";

                }
                else
                {
                    da.SelectCommand.CommandText = "select codigo, fornecedor, nf, volume, cidade, valor from entrada where entrada like '%' + @prod_nome + '%' or codigo like '%' + @prod_cod + '%' or cpf like '%' + @prod_cpf + '%' or cnpj like '%' + @prod_cnpj + '%' or cidade like '%' + @prod_cidade + '%'";
                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@prod_nome", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cod", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cpf", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cnpj", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cidade", filtro);
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
    }
}
