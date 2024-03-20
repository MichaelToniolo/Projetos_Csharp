using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;

namespace CTP
{
    public partial class frmOrcamento : Form
    {
        public string vendedor;

        public frmOrcamento()
        {
            InitializeComponent();
        }

        #region Váriaveis Globais
        string co;
        decimal preco, total;
        public string p;
        decimal descontoP = 0;
        decimal entrada = 0;
        decimal descontoV = 0;
        #endregion

        #region Load
        private void frmOrcamento_Load(object sender, EventArgs e)
        {
            //Passar o nome do usuario logado para o caixa / vendedor
            lblVendedorVenda.Text = vendedor;

            cbbCliente.Enabled = true;
            cbbCliente.DataSource = PesquisaCliente();
            cbbCliente.ValueMember = "codigo";
            cbbCliente.DisplayMember = "nome";

            cbbCliente.SelectedIndex = -1;

            cbbProduto.DataSource = PesquisaProduto();
            cbbProduto.ValueMember = "codigo";
            cbbProduto.DisplayMember = "descricao";

            cbbProduto.SelectedIndex = -1;

            listavenda.View = System.Windows.Forms.View.Details;
            listavenda.FullRowSelect = true;

            listavenda.Columns.Add("PRODUTO", 151, HorizontalAlignment.Left);
            listavenda.Columns.Add("CODIGO", 49, HorizontalAlignment.Center);
            listavenda.Columns.Add("QTDE", 49, HorizontalAlignment.Left);
            listavenda.Columns.Add("TOTAL", 49, HorizontalAlignment.Left);

            txtParcela.Enabled = false;
            dtpVencimento.Enabled = false;
            txtIntervalo.Enabled = false;
        }
        #endregion

        #region Botão Pesquisa Cliente
        private void button1_Click(object sender, EventArgs e)
        {
            PesquisaCliente pro = new PesquisaCliente();
            pro.ShowDialog();
            //txtcodigo.Text = pro.codigo;
            cbbCliente.Text = pro.nome;
            //txtCredito.Text = pro.credito;
            pro.Close();

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
                da.SelectCommand.CommandText = "select codigo, nome, credito from cadcliente where tipo = 'cliente' and statuscliente = 'Ativo' ";

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
        public DataTable PesquisaProduto()
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
                da.SelectCommand.CommandText = "select codigo, descricao, preco from produto";

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

        #region Botão Pesquisa Produto
        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto pqp = new frmPesquisaProduto();
            pqp.ShowDialog();

            cbbProduto.Text = pqp.descricao;
            preco = Convert.ToDecimal(pqp.preco);
            txtPreco.Text = Convert.ToString(preco);


            pqp.Close();
        }
        #endregion

        #region Botão Adcionar
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (cbbCliente.Text.Length == 0 || cbbProduto.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                cbbCliente.Enabled = false;


                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    //captura informa o Produto
                    estoqueinformation pdv = new estoqueinformation();
                    pdv.Produto_codigo = (int)cbbProduto.SelectedValue;

                    //captura informa o Cliente
                    clienteInformation cliv = new clienteInformation();
                    cliv.Cl_codigo = (int)cbbCliente.SelectedValue;

                    /*command responsável por buscar
                     * a quantidade em estoque do determinado produto */
                    SqlCommand cmdquant = new SqlCommand();
                    cmdquant.Connection = con;
                    cmdquant.CommandType = CommandType.Text;
                    cmdquant.CommandText = "select quantidade from produto where codigo = @prd_cod";
                    cmdquant.Parameters.AddWithValue("@prd_cod", pdv.Produto_codigo);

                    /*command responsável por buscar
                     * a quantidade em estoque do determinado produto
                    SqlCommand cmdpreco = new SqlCommand();
                    cmdpreco.Connection = con;
                    cmdpreco.CommandType = CommandType.Text;
                    cmdpreco.CommandText = "select preco from produto where codigo = @prd_cod";
                    cmdpreco.Parameters.AddWithValue("@prd_cod", pdv.Produto_codigo);*/

                    /*command responsável por buscar
                     * o Limite de Credito de determinado cliente */
                    /*SqlCommand cmdlim = new SqlCommand();
                    cmdlim.Connection = con;
                    cmdlim.CommandType = CommandType.Text;
                    cmdlim.CommandText = "select credito from cadcliente where codigo = @cli_cod";
                    cmdlim.Parameters.AddWithValue("@cli_cod", cliv.Cl_codigo);*/

                    con.Open();

                    //Executar query com obtenção de quantidade em estoque
                    //decimal resultadolim = Convert.ToDecimal(cmdlim.ExecuteScalar());
                    int resultado = Convert.ToInt32(cmdquant.ExecuteScalar());
                    //txtPreco.Text = Convert.ToString(cmdpreco.ExecuteScalar());


                    //verificar se tem o produto no estoque
                    if (resultado > 0)
                    {
                        //preparar a ListView para inserção dos produtos
                        ListViewItem item = new ListViewItem(cbbProduto.Text);
                        int quantidade = Convert.ToInt32(txtquantidade.Text);

                        if (quantidade <= resultado)
                        {
                            if ((quantidade * Convert.ToDecimal(txtPreco.Text)) > 0)
                            {

                                //adicionar subitem no ListView
                                item.SubItems.Add(Convert.ToString(pdv.Produto_codigo));
                                item.SubItems.Add(Convert.ToString(quantidade));
                                item.SubItems.Add(Convert.ToString(quantidade * Convert.ToDecimal(txtPreco.Text)));
                                item.SubItems.Add(Convert.ToString(btnremover));
                                //colocar objetos na ListView
                                this.listavenda.Items.Add(item);

                                //baixa em estoque do produto selecionado
                                SqlCommand cmdBaixa = new SqlCommand();
                                cmdBaixa.Connection = con;
                                cmdBaixa.CommandType = CommandType.Text;
                                cmdBaixa.CommandText = "update produto set quantidade = quantidade - @quantidade where codigo = @cod_baixa";

                                //parametro
                                cmdBaixa.Parameters.AddWithValue("@cod_baixa", pdv.Produto_codigo);
                                cmdBaixa.Parameters.AddWithValue("@quantidade", quantidade);

                               
                                txtSubT.Text = Convert.ToString((quantidade * Convert.ToDecimal(txtPreco.Text)) + Convert.ToDecimal(txtSubT.Text));

                                txtTotal.Text = Convert.ToString((quantidade * Convert.ToDecimal(txtPreco.Text)) + Convert.ToDecimal(txtTotal.Text));
                                total = Convert.ToDecimal(txtTotal.Text);
                                //resultadolim = resultadolim - total;
                                /* o Limite de Credito de determinado cliente */


                                pdv.Preco = Convert.ToDecimal(txtTotal.Text);

                                /*SqlCommand limite = new SqlCommand();
                                limite.Connection = con;
                                limite.CommandType = CommandType.Text;
                                limite.CommandText = "update cadcliente set credito = credito - @preco where codigo = @cli_cod";
                                limite.Parameters.AddWithValue("@cli_cod", cliv.Cl_codigo);
                                limite.Parameters.AddWithValue("@preco", pdv.Preco);*/


                                //executar a query
                                cmdBaixa.ExecuteNonQuery();
                                //limite.ExecuteNonQuery();


                            }

                            else
                            {
                                MessageBox.Show("Limite de Crédito Excedido!");
                            }
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                finally
                {


                    con.Close();
                }
            }
        }
        #endregion

        #region Botão Finalizar
        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            //Abrindo comando de conexao com o SQL - Banco de Dados
            SqlConnection con = new SqlConnection();

            //conexão com o Banco de Dados
            con.ConnectionString = Dados.conexaoBancoDados;

            //Instanciando as classes para passar para o Bando de Dados
            baixainformation ven = new baixainformation();
            contasinformation cre = new contasinformation();

            //Inicio da Gravação da venda no Banco de Dados
            try
            {
                //Verifica se a listview contem um item e inicia
                if (listavenda.Items.Count > 0)
                {
                    //Gravar Baixa - Parametros                    
                    ven.Data = dtpdata.Value;
                    ven.Nome = cbbCliente.Text;
                    ven.Cadcliente_codigo = (int)cbbCliente.SelectedValue;
                    ven.NomeArquivo = txtNomeArquivo.Text;
                    ven.Preco = Convert.ToDecimal(txtTotal.Text);

                    //Gravar Contas a Receber - Parametros                      
                    cre.Cr_codigocliente = (int)cbbCliente.SelectedValue;
                    cre.Cr_datacadastro = Convert.ToDateTime(dtpdata.Text);
                    cre.Cr_baixado = 'N';
                    cre.Cr_especie = cbbCondicao.Text;
                    int p = Convert.ToInt32(txtParcela.Text);
                    cre.Cr_valor = Convert.ToDecimal(txtTotal.Text) / p;
                    int intervalo = Convert.ToInt32(txtIntervalo.Text);
                    cre.Cr_prazo = intervalo;

                    //command
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into baixa(datab, nome, quantidade, cadcliente_codigo, oscodigo, nomearquivo, preco) values (@Data, @Nome, @Quantidade, @Cadcliente_codigo, @OsCodigo, @NomeArquivo, @preco) select SCOPE_IDENTITY()";

                    //parametros vendas
                    cmd.Parameters.AddWithValue("@data", ven.Data);
                    cmd.Parameters.AddWithValue("@nome", ven.Nome);
                    cmd.Parameters.AddWithValue("@quantidade", ven.Quantidade);
                    cmd.Parameters.AddWithValue("@cadcliente_codigo", ven.Cadcliente_codigo);
                    cmd.Parameters.AddWithValue("@oscodigo", ven.OsCodigo);
                    cmd.Parameters.AddWithValue("@nomearquivo", ven.NomeArquivo);
                    cmd.Parameters.AddWithValue("@preco", ven.Preco);


                    // Abrir conexão com o Banco de Dados
                    con.Open();

                    // Executar query com ExecuteScalar para obter o SCOPE_IDENTITY
                    int ven_cod = Convert.ToInt32(cmd.ExecuteScalar());

                    // Identificar produtos da venda
                    estoqueinformation pdv = new estoqueinformation();
                    pdv.Baixa_codigo = ven_cod;
                    txtcodigo.Text = Convert.ToString(pdv.Baixa_codigo);
                    cre.Cr_ficha = ven_cod;


                    // Comando para buscar o codigo do produto
                    SqlCommand cmdbusca = new SqlCommand();
                    cmdbusca.Connection = con;
                    cmdbusca.CommandType = CommandType.Text;
                    cmdbusca.CommandText = "select codigo from produto where descricao = @prod_nome";


                    // Comando para dar baixa nos produtos baixados no estoque
                    SqlCommand cmdinsert = new SqlCommand();
                    cmdinsert.Connection = con;
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.CommandText = " insert into estoque(baixa_codigo, produto_codigo, estoque_qtd, preco) values (@baixa_codigo, @produto_codigo, @estoque_qtd, @preco)";

                    if (txtIntervalo.Text != "0")
                    {

                        //Parcelas
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



                            try
                            {
                                //command
                                SqlCommand cmdcr = new SqlCommand();
                                cmdcr.Connection = con;
                                cmdcr.CommandType = CommandType.Text;
                                cmdcr.CommandText = "insert into contasareceber (ficha, codigocliente, valor, parcela, datacadastro, datavencimento, baixado, especie, prazo) values (@cr_ficha, @cr_codigocliente, @cr_valor, @cr_parcela, @cr_datacadastro, @cr_datavencimento, @cr_baixado, @cr_especie, @cr_prazo)";

                                //parametros
                                //cmd.Parameters.AddWithValue("@cliente_codigo", usu.Cl_codigo);
                                //cre.Cr_codigo = Convert.ToInt32(txtcodigo.Text);
                                cmdcr.Parameters.AddWithValue("@cr_ficha", cre.Cr_ficha);
                                cmdcr.Parameters.AddWithValue("@cr_codigocliente", cre.Cr_codigocliente);
                                cmdcr.Parameters.AddWithValue("@cr_valor", cre.Cr_valor);
                                cmdcr.Parameters.AddWithValue("@cr_parcela", cre.Cr_parcela);
                                cmdcr.Parameters.AddWithValue("@cr_datacadastro", cre.Cr_datacadastro);
                                cmdcr.Parameters.AddWithValue("@cr_datavencimento", cre.Cr_datavencimento);
                                cmdcr.Parameters.AddWithValue("@cr_baixado", cre.Cr_baixado);
                                cmdcr.Parameters.AddWithValue("@cr_especie", cre.Cr_especie);
                                cmdcr.Parameters.AddWithValue("@cr_prazo", cre.Cr_prazo);

                                cmdcr.ExecuteNonQuery();

                                p--;

                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK);
                            }
                        }


                        //percorrer a ListView
                        foreach (ListViewItem item in listavenda.Items)
                        {

                            /// dhfjdhasjfhjsdkjfksdjkfjsdkijfk
                            string valor = Convert.ToString(item.SubItems[2].Text);
                            pdv.Estoque_qtd = valor;

                            string real = Convert.ToString(item.SubItems[3].Text);
                            pdv.Preco = Convert.ToDecimal(real);

                            //capturar o nome do produto
                            cmdbusca.Parameters.AddWithValue("@prod_nome", item.Text);


                            //buscar o codigo do produto
                            int codigoProduto = Convert.ToInt32(cmdbusca.ExecuteScalar());

                            //passar o parametro para Insert 
                            cmdinsert.Parameters.AddWithValue("@baixa_codigo", pdv.Baixa_codigo);
                            cmdinsert.Parameters.AddWithValue("@produto_codigo", codigoProduto);
                            cmdinsert.Parameters.AddWithValue("@estoque_qtd", pdv.Estoque_qtd);
                            cmdinsert.Parameters.AddWithValue("@preco", pdv.Preco);

                            //executar a query da insert
                            cmdinsert.ExecuteNonQuery();


                            co = Convert.ToString(pdv.Baixa_codigo);

                            //limpar os parametros
                            cmdbusca.Parameters.RemoveAt("@prod_nome");

                            /////////////////////////////////////////////////
                            cmdinsert.Parameters.RemoveAt("@estoque_qtd");
                            cmdinsert.Parameters.RemoveAt("@baixa_codigo");
                            cmdinsert.Parameters.RemoveAt("@produto_codigo");
                            cmdinsert.Parameters.RemoveAt("@preco");
                        }
                    }

                    MessageBox.Show("Baixa Efetuada" + " " + "Codigo" + " " + co, "Baixa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtcancelar.Enabled = true;
                }


                else
                {
                    MessageBox.Show("Preencha todos os campos para finalizar o orçamento!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LimpaTela();
                con.Close();
            }
        }
        #endregion

        #region Botão Remover
        private void btnremover_Click(object sender, EventArgs e)
        {
            if (listavenda.SelectedItems.Count != 0)
            {
                ProdutoInformation prod = new ProdutoInformation();
                prod.Pr_descricao = listavenda.SelectedItems[0].Text;
                int quantidade = int.Parse(listavenda.FocusedItem.SubItems[2].Text);



                clienteInformation cliente = new clienteInformation();
                cliente.Cl_nome = cbbCliente.Text;
                cliente.Credito = Convert.ToDecimal(txtTotal.Text);


                SqlConnection con = new SqlConnection();
                try
                {

                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    //command extorno para estoque
                    SqlCommand cmdexterno = new SqlCommand();
                    cmdexterno.Connection = con;
                    cmdexterno.CommandType = CommandType.Text;
                    cmdexterno.CommandText = "update produto set quantidade = quantidade + @quantidade where descricao = @prod_nome";

                    //Command para retornar os valores de crédito
                    SqlCommand cmdcredito = new SqlCommand();
                    cmdcredito.Connection = con;
                    cmdcredito.CommandType = CommandType.Text;
                    cmdcredito.CommandText = "update cadcliente set credito = credito + @credito where nome = @nome";


                    //parametros
                    cmdcredito.Parameters.AddWithValue("@nome", cliente.Cl_nome);
                    cmdcredito.Parameters.AddWithValue("@credito", cliente.Credito);
                    cmdexterno.Parameters.AddWithValue("@prod_nome", prod.Pr_descricao);
                    cmdexterno.Parameters.AddWithValue("@quantidade", quantidade);

                    //abrir conexão
                    con.Open();

                    //executa a query de extorno
                    cmdexterno.ExecuteNonQuery();
                    cmdcredito.ExecuteNonQuery();

                    //remover valor do produto no total da venda
                    decimal prod_preco = Convert.ToDecimal(listavenda.FocusedItem.SubItems[3].Text);
                    decimal ven_total = Convert.ToDecimal(txtTotal.Text);
                    txtTotal.Text = Convert.ToString(ven_total - prod_preco * quantidade);

                    //remover o filme da listviw
                    listavenda.Items.RemoveAt(Convert.ToInt32(listavenda.SelectedIndices[0].ToString()));
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
            else
            {
                MessageBox.Show("Escolha Produto Para Remover ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        #endregion

        #region Botão Retornar
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (cbbCliente.Text.Length == 0)
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

        #region LimpaTela
        private void LimpaTela()
        {

            listavenda.Clear();
            /*listavenda.View = System.Windows.Forms.View.Details;
            listavenda.FullRowSelect = true;
            listavenda.Columns.Add("Descrição", 150, HorizontalAlignment.Center);
            listavenda.Columns.Add("Codigo Produto", 100, HorizontalAlignment.Left);
            listavenda.Columns.Add("Unidade", 80, HorizontalAlignment.Left);
            listavenda.Columns.Add("Preço", 60, HorizontalAlignment.Left);
            listavenda.Columns.Add("O.S. Código", 100, HorizontalAlignment.Left);
            listavenda.Columns.Add("Nome do Arquivo", 200, HorizontalAlignment.Left);*/

            txtNomeArquivo.Clear();
            //txtOsCodigo.Clear();
            cbbCliente.SelectedIndex = -1;
            cbbProduto.SelectedIndex = -1;
            txtTotal.Text = "0,00";
            txtPreco.Text = "0,00";
            cbbCliente.Enabled = true;
            txtquantidade.Text = "1";
            txtIntervalo.Text = "0";
            dtpVencimento.ResetText();
            txtParcela.ResetText();
            cbbCondicao.SelectedIndex = -1;
            txtParcela.Enabled = false;
            dtpVencimento.Enabled = false;
            txtIntervalo.Enabled = false;
        }
        #endregion

        #region BotãoLimpa tela
        private void txtcancelar_Click(object sender, EventArgs e)
        {

            if (listavenda.Items.Count > 0)
            {
                MessageBox.Show("Limpe a Lista de itens!");
            }
            else
            {
                cbbCliente.SelectedIndex = -1;
                LimpaTela();
                listavenda.Clear();

            }

        }
        #endregion

        #region Seleciona cliente

        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteInformation cliente = new clienteInformation();
            cliente.Cl_nome = cbbCliente.Text;


            SqlConnection con = new SqlConnection();
            try
            {

                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //Command para retornar os valores de crédito
                SqlCommand cmdcredito = new SqlCommand();
                cmdcredito.Connection = con;
                cmdcredito.CommandType = CommandType.Text;
                cmdcredito.CommandText = "select credito from cadcliente where nome = @nome";

                //parametros
                cmdcredito.Parameters.AddWithValue("@nome", cliente.Cl_nome);


                //abrir conexão
                con.Open();

                //executa a query de extorno
                cmdcredito.ExecuteNonQuery();

                decimal resultadolim = Convert.ToDecimal(cmdcredito.ExecuteScalar());
                txtCredito.Text = Convert.ToString(resultadolim);


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

        #region Seleciona Produto Preco
        private void cbbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoInformation produto = new ProdutoInformation();
            produto.Pr_descricao = cbbProduto.Text;


            SqlConnection con = new SqlConnection();
            try
            {

                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //Command para retornar os valores de crédito
                SqlCommand cmdcredito = new SqlCommand();
                cmdcredito.Connection = con;
                cmdcredito.CommandType = CommandType.Text;
                cmdcredito.CommandText = "select preco from produto where descricao = @nome";

                //parametros
                cmdcredito.Parameters.AddWithValue("@nome", produto.Pr_descricao);


                //abrir conexão
                con.Open();

                //executa a query de extorno
                cmdcredito.ExecuteNonQuery();

                decimal resultadolim = Convert.ToDecimal(cmdcredito.ExecuteScalar());
                txtPreco.Text = Convert.ToString(resultadolim);


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

        #region Tipo de venda Ativa ou Desativa número de parcelas
        private void cbbCondicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCondicao.SelectedIndex == 0 || cbbCondicao.SelectedIndex == 1)
            {
                txtParcela.Enabled = false;
                dtpVencimento.Enabled = false;
                txtIntervalo.Enabled = false;
            }
            else
            {
                txtParcela.Enabled = true;
                dtpVencimento.Enabled = true;
                txtIntervalo.Enabled = true;
            }
        }
        #endregion


        /*private void updateTax()
        {
            entrada = Convert.ToDecimal(txtEntrada.Text);
            this.txtEntrada.Text = txtEntrada.Text;
            updateTotal();
        }

        private void updateTotal()
        {
            this.txtTotal.Text = Convert.ToString(entrada);
        }*/

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            //updateTax();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            total = Convert.ToDecimal(txtSubT.Text);

            if (txtDescontoValor.Text == null )
            {
                txtDescontoValor.Text = "0,00";
            }
            else
            {
                descontoV = Convert.ToDecimal(txtDescontoValor.Text);

            }

            if (txtDescontoPorcentagem.TextLength == 0)
            {
                txtDescontoPorcentagem.Text = "0";
            }
            else
            {
                descontoP = Convert.ToDecimal(txtDescontoPorcentagem.Text);

            }
            //Entra valor zero
            if (txtEntrada.TextLength == 0)
            {
                txtEntrada.Text = "0,00";
            }
            else
            {
                entrada = Convert.ToDecimal(txtEntrada.Text);

            }
         
            if (entrada >= 0 && descontoV >= 0 && descontoP >= 0)
            {
                if (entrada > 0)
                {
                    txtTotal.Text = Convert.ToString(total - entrada);
                }

                else if (entrada == 0)
                {
                    txtTotal.Text = txtSubT.Text;
                }

                if (descontoP > 0 && descontoV == 0)
                {

                    txtTotal.Text = Convert.ToString(total - (((descontoP / 100) * total) + entrada));
                    
                }
                else if (descontoP == 0 && descontoV == 0 && entrada == 0)
                {
                    txtTotal.Text = txtSubT.Text;
                }


                if (descontoP == 0 && descontoV > 0)
                {
                    
                    txtTotal.Text = Convert.ToString(total - (descontoP + descontoV + entrada));
                   
                }
                else if(descontoV == 0 && descontoP == 0 && entrada ==0)
                {
                    txtTotal.Text = txtSubT.Text;
                }

            }
        }
    }
}