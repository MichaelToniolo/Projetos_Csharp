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
    public partial class frmCadastro : Form
    {
        /*
        string cpf, cpfIn;
        char cdig;
        int dig1, dig2;
        */

        public frmCadastro()
        {
            InitializeComponent();
        }

        #region Botão Inserir
        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (cbbtipo.SelectedIndex >= 0 && txtRazaoSocial.Text.Length > 0 && mtbCPF.TextLength > 0 && mtbTelefone.TextLength > 0 || mtbCelular.TextLength > 0)
            {


                clienteInformation usu = new clienteInformation();
                usu.Cl_nome = txtRazaoSocial.Text;
                usu.Cl_complemento = txtComplemento.Text;
                usu.Cl_cpf = mtbCPF.Text;
                usu.Cl_bairro = txtBairro.Text;
                usu.Cl_cep = txtCep.Text;
                usu.Cl_cidade = txtCidade.Text;
                usu.Cl_uf = cbbUF.Text;
                usu.Cl_telefone = mtbTelefone.Text;
                usu.Cl_celular = mtbCelular.Text;
                usu.Cl_cnpj = mtbCNPJ.Text;
                if (txtNumero.TextLength == 0)
                {
                    usu.Cl_numero = 000;
                }
                else
                {
                    usu.Cl_numero = Convert.ToInt32(txtNumero.Text);
                }
                //usu.Cl_sexo = cbbSexo.Text;
                usu.Cl_estadocivil = cbbEstadoCivil.Text;
                usu.Cl_email = txtEmail.Text;
                usu.Cl_nascimento = Convert.ToDateTime(dtpNascimento.Text);
                //usu.Cl_codigo = Convert.ToInt32(txtCodigo.Text);
                usu.Cl_endereco = txtEndereco.Text;
                usu.Cl_rg = mtbRG.Text;
                usu.Cl_tipo = cbbtipo.Text;
                usu.Ie = txtIE.Text;
                usu.Status = cbbStatus.Text;

                if (txtCredito.TextLength == 0)
                {
                    usu.Credito = 000;
                }
                else
                {
                    usu.Credito = Convert.ToDecimal(txtCredito.Text);
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
                    cmd.CommandText = "insert into cadcliente (nome, complemento, cpf, bairro, cep, cidade, uf, telefone, celular, cnpj, endereco, numero, email, nascimento, rg, estadocivil, tipo, iest, statuscliente, credito) values (@cliente_nome, @cliente_comple, @cliente_cpf, @cliente_bairro, @cliente_cep, @cliente_cidade, @cliente_uf, @cliente_telefone, @cliente_celular, @cliente_cnpj, @cliente_endereco, @cliente_numero, @cliente_email, @cliente_nascimento, @cliente_rg, @cliente_estadocivil, @tipo, @ie, @status, @credito)";

                    //parametros
                    //cmd.Parameters.AddWithValue("@cliente_codigo", usu.Cl_codigo);
                    cmd.Parameters.AddWithValue("@cliente_nome", usu.Cl_nome);
                    cmd.Parameters.AddWithValue("@cliente_comple", usu.Cl_complemento);
                    cmd.Parameters.AddWithValue("@cliente_cpf", usu.Cl_cpf);
                    cmd.Parameters.AddWithValue("@cliente_bairro", usu.Cl_bairro);
                    cmd.Parameters.AddWithValue("@cliente_cep", usu.Cl_cep);
                    cmd.Parameters.AddWithValue("@cliente_cidade", usu.Cl_cidade);
                    cmd.Parameters.AddWithValue("@cliente_uf", usu.Cl_uf);
                    cmd.Parameters.AddWithValue("@cliente_telefone", usu.Cl_telefone);
                    cmd.Parameters.AddWithValue("@cliente_celular", usu.Cl_celular);
                    cmd.Parameters.AddWithValue("@cliente_cnpj", usu.Cl_cnpj);
                    cmd.Parameters.AddWithValue("@cliente_endereco", usu.Cl_endereco);
                    cmd.Parameters.AddWithValue("@cliente_numero", usu.Cl_numero);
                    cmd.Parameters.AddWithValue("@cliente_email", usu.Cl_email);
                    //cmd.Parameters.AddWithValue("@cliente_sexo", usu.Cl_sexo);
                    cmd.Parameters.AddWithValue("@cliente_nascimento", usu.Cl_nascimento);
                    //cmd.Parameters.AddWithValue("@cliente_chapa", usu.Cl_chapa);
                    cmd.Parameters.AddWithValue("@cliente_rg", usu.Cl_rg);
                    cmd.Parameters.AddWithValue("@cliente_estadocivil", usu.Cl_estadocivil);
                    cmd.Parameters.AddWithValue("@tipo", usu.Cl_tipo);
                    cmd.Parameters.AddWithValue("@ie", usu.Ie);
                    cmd.Parameters.AddWithValue("@status", usu.Status);
                    cmd.Parameters.AddWithValue("@credito", usu.Credito);
                    // Abrir conexão
                    con.Open();


                    cmd.ExecuteNonQuery();



                    MessageBox.Show("Usuario Cadastrado Com Sucesso.", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaTela();

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
                    dtgCliente.DataSource = AtualizaGrid(txtBusca.Text);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Método Limpa Tela
        public void LimpaTela()
        {
            cbbtipo.Enabled = true;
            cbbStatus.SelectedIndex = -1;
            txtCredito.Clear();
            btnInserir.Enabled = true;
            txtCep.Clear();
            txtCodigo.Clear();
            txtRazaoSocial.Clear();
            mtbCNPJ.Clear();
            mtbCPF.Clear();
            mtbRG.Clear();
            txtIE.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            mtbTelefone.Clear();
            mtbCelular.Clear();
            dtpNascimento.ResetText();
            cbbEstadoCivil.SelectedIndex = -1;
            //cbbSexo.SelectedIndex = -1;
            cbbUF.SelectedIndex = -1;
            txtRazaoSocial.Focus();
            cbbtipo.SelectedIndex = -1;

        }
        #endregion

        #region Validar CPF
        /*
        private void validarCPF()
        {
            if (mtbCPF.Text.Length == 11)
            {
                try
                {
                    //tirar os pontos e barras
                    cpf = mtbCPF.Text.Trim();
                    //guardar cpf original para comprar no fim
                    cpfIn = cpf;
                    //tirar os digitos
                    cpf = cpf.Remove(cpf.Length - 2);

                    //Verificar digito 1 com a forumla dada
                    for (int i = 0; i < 9; i++)
                    {
                        cdig = char.Parse(cpf.Substring(i, 1));
                        int temp = int.Parse(cdig.ToString()) * (10 - i);
                        dig1 += temp;
                    }
                    dig1 = dig1 % 11;

                    if (dig1 < 2)
                    {
                        dig1 = 0;
                    }
                    else
                    {
                        dig1 = 11 - dig1;
                    }

                    //acrescenta o dígito obtido
                    cpf += dig1.ToString();

                    //Verificar digito 2 com a forumla dada
                    for (int i = 0; i < 10; i++)
                    {
                        cdig = char.Parse(cpf.Substring(i, 1));
                        int temp = int.Parse(cdig.ToString()) * (11 - i);
                        dig2 = dig2 + temp;
                    }
                    dig2 = dig2 % 11;

                    if (dig2 < 2)
                    {
                        dig2 = 0;
                    }
                    else
                    {
                        dig2 = 11 - dig2;
                    }

                    //acrescenta o dígito obtido
                    cpf += dig2;

                    //se o cpf modificado for igual ao inserido mostra mensagem de ok
                    if (cpfIn == cpf)
                    {
                        lblMensagem.ForeColor = Color.Green;
                        lblMensagem.Text = "CPF Válido";
                    }
                    //caso contrário mensagem de inválido
                    else
                    {
                        lblMensagem.ForeColor = Color.Red;
                        lblMensagem.Text = "CPF Inválido ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erro");
                }
                finally
                {
                    //zerar variáveis para não dar problema nas próximas verificações
                    dig1 = 0;
                    dig2 = 0;
                }
            }
            else
            {
                MessageBox.Show("CPF com formato inválido\n Insira 11 números, sem pontos, vírgulas ou barras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
          */
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
                    da.SelectCommand.CommandText = "select codigo, nome, cnpj, cpf, estadocivil, rg, nascimento, cep, endereco, numero, complemento, bairro, cidade, uf, email, telefone, celular, tipo, iest, statuscliente, credito from cadcliente";

                }
                else
                {
                    da.SelectCommand.CommandText = "select codigo, nome, cnpj, cpf, estadocivil, rg, nascimento, cep, endereco, numero, complemento, bairro, cidade, uf, email, telefone, celular, tipo, iest, statuscliente, credito from cadcliente where nome like '%' + @prod_nome + '%' or codigo like '%' + @prod_cod + '%' or cpf like '%' + @prod_cpf + '%' or cnpj like '%' + @prod_cnpj + '%' or cidade like '%' + @prod_cidade + '%' + @prod_ie '%'";
                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@prod_nome", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cod", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cpf", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cnpj", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@prod_cidade", filtro);
                    da.SelectCommand.Parameters.AddWithValue("@pro_ie", filtro);
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

        #region Botão Alterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.TextLength > 0)
            {
                if (cbbtipo.SelectedIndex >= 0 && txtRazaoSocial.Text.Length > 0 && mtbCPF.Text.Length > 0)
                {
                    clienteInformation usu = new clienteInformation();
                    usu.Cl_codigo = Convert.ToInt32(txtCodigo.Text);
                    usu.Cl_nome = txtRazaoSocial.Text;
                    usu.Cl_complemento = txtComplemento.Text;
                    usu.Cl_cpf = mtbCPF.Text;
                    usu.Cl_bairro = txtBairro.Text;
                    usu.Cl_cep = txtCep.Text;
                    usu.Cl_cidade = txtCidade.Text;
                    usu.Cl_uf = cbbUF.Text;
                    usu.Cl_telefone = mtbTelefone.Text;
                    usu.Cl_celular = mtbCelular.Text;
                    usu.Cl_cnpj = mtbCNPJ.Text;
                    usu.Cl_numero = Convert.ToInt32(txtNumero.Text);
                    //usu.Cl_sexo = cbbSexo.Text;
                    usu.Cl_estadocivil = cbbEstadoCivil.Text;
                    usu.Cl_email = txtEmail.Text;
                    usu.Cl_nascimento = Convert.ToDateTime(dtpNascimento.Text);
                    usu.Cl_codigo = Convert.ToInt32(txtCodigo.Text);
                    usu.Cl_endereco = txtEndereco.Text;
                    usu.Cl_rg = mtbRG.Text;
                    usu.Cl_tipo = cbbtipo.Text;
                    usu.Ie = txtIE.Text;
                    usu.Status = cbbStatus.Text;
                    usu.Credito = Convert.ToDecimal(txtCredito.Text);


                    SqlConnection con = new SqlConnection();
                    try
                    {
                        //conexão
                        con.ConnectionString = Dados.conexaoBancoDados;

                        // command
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update cadcliente set nome = @cliente_nome, complemento = @cliente_comple, cpf = @cliente_cpf, bairro = @cliente_bairro, cep = @cliente_cep, cidade = @cliente_cidade, uf = @cliente_uf, telefone = @cliente_telefone, celular = @cliente_celular, cnpj = @cliente_cnpj, endereco = @cliente_endereco, numero = @cliente_numero, email = @cliente_email,  estadocivil = @cliente_estadocivil, rg = @cliente_rg, tipo = @tipo, iest = @cliente_ie, statuscliente = @cliente_status, credito = @cliente_credito where codigo = @cliente_codigo";

                        //parametros
                        cmd.Parameters.AddWithValue("@cliente_codigo", usu.Cl_codigo);
                        cmd.Parameters.AddWithValue("@cliente_nome", usu.Cl_nome);
                        cmd.Parameters.AddWithValue("@cliente_comple", usu.Cl_complemento);
                        cmd.Parameters.AddWithValue("@cliente_cpf", usu.Cl_cpf);
                        cmd.Parameters.AddWithValue("@cliente_bairro", usu.Cl_bairro);
                        cmd.Parameters.AddWithValue("@cliente_cep", usu.Cl_cep);
                        cmd.Parameters.AddWithValue("@cliente_cidade", usu.Cl_cidade);
                        cmd.Parameters.AddWithValue("@cliente_uf", usu.Cl_uf);
                        cmd.Parameters.AddWithValue("@cliente_telefone", usu.Cl_telefone);
                        cmd.Parameters.AddWithValue("@cliente_celular", usu.Cl_celular);
                        cmd.Parameters.AddWithValue("@cliente_cnpj", usu.Cl_cnpj);
                        cmd.Parameters.AddWithValue("@cliente_endereco", usu.Cl_endereco);
                        cmd.Parameters.AddWithValue("@cliente_numero", usu.Cl_numero);
                        cmd.Parameters.AddWithValue("@cliente_email", usu.Cl_email);
                        //cmd.Parameters.AddWithValue("@cliente_sexo", usu.Cl_sexo);
                        cmd.Parameters.AddWithValue("@cliente_nascimento", usu.Cl_nascimento);
                        cmd.Parameters.AddWithValue("@cliente_estadocivil", usu.Cl_estadocivil);
                        cmd.Parameters.AddWithValue("@cliente_rg", usu.Cl_rg);
                        cmd.Parameters.AddWithValue("@tipo", usu.Cl_tipo);
                        cmd.Parameters.AddWithValue("@cliente_ie", usu.Ie);
                        cmd.Parameters.AddWithValue("@cliente_status", usu.Status);
                        cmd.Parameters.AddWithValue("@cliente_credito", usu.Credito);
                        // Abrir conexão
                        con.Open();

                        //executar query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Atualizado Com Sucesso", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaTela();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                        dtgCliente.DataSource = AtualizaGrid(txtBusca.Text);
                    }

                }

            }
            else
            {
                MessageBox.Show("Selecione um Cliente e verifique se os campos preenchidos estão corretos.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Load
        private void frmCadastro_Load(object sender, EventArgs e)
        {

            txtRazaoSocial.Focus();
            dtgCliente.DataSource = AtualizaGrid(txtBusca.Text);

            //Cabeçalho da datagrid
            dtgCliente.Columns[0].HeaderText = "Codigo";
            dtgCliente.Columns[1].HeaderText = "Razão Social";
            dtgCliente.Columns[2].HeaderText = "CNPJ";
            dtgCliente.Columns[3].HeaderText = "CPF";
            //dtgCliente.Columns[4].HeaderText = "Sexo";
            dtgCliente.Columns[4].HeaderText = "Civil";
            dtgCliente.Columns[5].HeaderText = "RG";
            dtgCliente.Columns[6].HeaderText = "Nascimento";
            dtgCliente.Columns[7].HeaderText = "CEP";
            dtgCliente.Columns[8].HeaderText = "Endereço";
            dtgCliente.Columns[9].HeaderText = "Número";
            dtgCliente.Columns[10].HeaderText = "Complemento";
            dtgCliente.Columns[11].HeaderText = "Bairro";
            dtgCliente.Columns[12].HeaderText = "Cidade";
            dtgCliente.Columns[13].HeaderText = "UF";
            dtgCliente.Columns[14].HeaderText = "Email";
            dtgCliente.Columns[15].HeaderText = "Telefone";
            dtgCliente.Columns[16].HeaderText = "Celular";
            dtgCliente.Columns[17].HeaderText = "Tipo";
            dtgCliente.Columns[18].HeaderText = "I.E.";
            dtgCliente.Columns[19].HeaderText = "Status";
            dtgCliente.Columns[20].HeaderText = "Crédito";

            //Largura das colunas
            dtgCliente.Columns[0].Width = 60;
            dtgCliente.Columns[1].Width = 200;
            dtgCliente.Columns[2].Width = 150;
            dtgCliente.Columns[3].Width = 200;
            dtgCliente.Columns[4].Width = 120;
            dtgCliente.Columns[5].Width = 150;
            dtgCliente.Columns[6].Width = 80;
            dtgCliente.Columns[7].Width = 100;
            dtgCliente.Columns[8].Width = 130;
            dtgCliente.Columns[9].Width = 100;
            dtgCliente.Columns[10].Width = 100;
            dtgCliente.Columns[11].Width = 110;
            dtgCliente.Columns[12].Width = 110;
            dtgCliente.Columns[13].Width = 110;
            dtgCliente.Columns[14].Width = 80;
            dtgCliente.Columns[15].Width = 110;
            dtgCliente.Columns[16].Width = 90;
            dtgCliente.Columns[17].Width = 110;
            dtgCliente.Columns[18].Width = 90;
            dtgCliente.Columns[19].Width = 100;
            dtgCliente.Columns[20].Width = 80;
            //dtgCliente.Columns[21].Width = 80;

            //Permissões da datagrid
            dtgCliente.ReadOnly = true;
            dtgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCliente.AllowUserToAddRows = false;
            dtgCliente.AllowUserToDeleteRows = false;
            dtgCliente.AllowUserToResizeColumns = true;
            dtgCliente.AllowUserToResizeRows = false;

            dtgpProduto.DataSource = AtualizaGridP(txtpBusca.Text);

            //Cabeçalho da datagrid
            dtgpProduto.Columns[0].HeaderText = "Codigo";
            dtgpProduto.Columns[1].HeaderText = "Descrição";
            dtgpProduto.Columns[2].HeaderText = "Estoque";
            dtgpProduto.Columns[3].HeaderText = "Preço";
            dtgpProduto.Columns[4].HeaderText = "Marca";
            dtgpProduto.Columns[5].HeaderText = "Fornecedor";
            dtgpProduto.Columns[6].HeaderText = "Data Cadastro";


            //Largura das colunas
            dtgCliente.Columns[0].Width = 60;
            dtgCliente.Columns[1].Width = 200;
            dtgCliente.Columns[2].Width = 150;
            dtgCliente.Columns[3].Width = 200;
            dtgCliente.Columns[4].Width = 120;
            dtgCliente.Columns[5].Width = 150;
            dtgCliente.Columns[6].Width = 80;


            //Permissões da datagrid
            dtgpProduto.ReadOnly = true;
            dtgpProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgpProduto.AllowUserToAddRows = false;
            dtgpProduto.AllowUserToDeleteRows = false;
            dtgpProduto.AllowUserToResizeColumns = true;
            dtgpProduto.AllowUserToResizeRows = false;

            //Travando Data
            dtppDataCadastro.Enabled = false;


        }
        #endregion

        #region Click da DataGrid
        private void dtgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnInserir.Enabled = false;
            cbbtipo.Enabled = false;

            txtCodigo.Text = dtgCliente[0, dtgCliente.CurrentRow.Index].Value.ToString();
            txtRazaoSocial.Text = dtgCliente[1, dtgCliente.CurrentRow.Index].Value.ToString();
            mtbCNPJ.Text = dtgCliente[2, dtgCliente.CurrentRow.Index].Value.ToString();
            mtbCPF.Text = dtgCliente[3, dtgCliente.CurrentRow.Index].Value.ToString();
            //cbbSexo.Text = dtgCliente[4, dtgCliente.CurrentRow.Index].Value.ToString();
            cbbEstadoCivil.Text = dtgCliente[4, dtgCliente.CurrentRow.Index].Value.ToString();
            mtbRG.Text = dtgCliente[5, dtgCliente.CurrentRow.Index].Value.ToString();
            dtpNascimento.Text = dtgCliente[6, dtgCliente.CurrentRow.Index].Value.ToString();
            txtCep.Text = dtgCliente[7, dtgCliente.CurrentRow.Index].Value.ToString();
            txtEndereco.Text = dtgCliente[8, dtgCliente.CurrentRow.Index].Value.ToString();
            txtNumero.Text = dtgCliente[9, dtgCliente.CurrentRow.Index].Value.ToString();
            txtComplemento.Text = dtgCliente[10, dtgCliente.CurrentRow.Index].Value.ToString();
            txtBairro.Text = dtgCliente[11, dtgCliente.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dtgCliente[12, dtgCliente.CurrentRow.Index].Value.ToString();
            cbbUF.Text = dtgCliente[13, dtgCliente.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dtgCliente[14, dtgCliente.CurrentRow.Index].Value.ToString();
            mtbTelefone.Text = dtgCliente[15, dtgCliente.CurrentRow.Index].Value.ToString();
            mtbCelular.Text = dtgCliente[16, dtgCliente.CurrentRow.Index].Value.ToString();
            cbbtipo.Text = dtgCliente[17, dtgCliente.CurrentRow.Index].Value.ToString();
            txtIE.Text = dtgCliente[18, dtgCliente.CurrentRow.Index].Value.ToString();
            cbbStatus.Text = dtgCliente[19, dtgCliente.CurrentRow.Index].Value.ToString();
            txtCredito.Text = dtgCliente[20, dtgCliente.CurrentRow.Index].Value.ToString();

        }
        #endregion

        #region Busca
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dtgCliente.DataSource = AtualizaGrid(txtBusca.Text);
        }
        #endregion

        #region Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.TextLength > 0)
            {
                clienteInformation usu = new clienteInformation();
                usu.Cl_codigo = Convert.ToInt32(txtCodigo.Text);


                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    //command
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from cadcliente where codigo = @cliente_codigo";

                    //parametros
                    cmd.Parameters.AddWithValue("@cliente_codigo", usu.Cl_codigo);


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
                    dtgCliente.DataSource = AtualizaGrid(txtBusca.Text);
                }
            }
            else
            {
                MessageBox.Show("Selecione Cliente Para Excluir", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Botão Limpa Tela
        private void btnLimpaTela_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
        #endregion

        /*#region CPF Keypress
        private void mtbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

                if (e.KeyChar == 13)
                {
                    //validarCPF();
                }
            }

        }
        #endregion
        */

        /*#region CEP Keypress
        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion
        */
        #region RG Keypress
        private void mtbRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region CNPJ Keypress
        private void mtbCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Número Keypress
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Telefone Keyprerss
        private void mtbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Celular Keypress
        private void mtbCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Botão Retornar
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (txtCodigo.TextLength == 0)
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

        #region Botão Inserir Produto
        private void btnpInserir_Click(object sender, EventArgs e)
        {
            if (cbbEstadoCivil.Text != "Solteiro(A)" && cbbEstadoCivil.Text != "Casado(A)" && txtpNome.Text.Length > 0 && txtpEstoque.Text.Length >= 0 && txtpFornecedor.Text.Length > 0 && txtpMarca.Text.Length > 0 && txtpPreco.Text.Length > 0)
            {
                if (txtpEstoque.Text.Length >= 0)
                {

                    ProdutoInformation usu = new ProdutoInformation();
                    usu.Pr_datacad = Convert.ToDateTime(dtppDataCadastro.Text);
                    usu.Pr_descricao = txtpNome.Text;
                    usu.Pr_marca = txtpMarca.Text;
                    usu.Pr_quantidade = 0;
                    usu.Pr_preco = Convert.ToDecimal(txtpPreco.Text);
                    usu.Pr_fornecedor = txtpFornecedor.Text;



                    SqlConnection con = new SqlConnection();
                    try
                    {
                        //conexão
                        con.ConnectionString = Dados.conexaoBancoDados;

                        //command
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into produto (descricao, quantidade, preco, marca, fornecedor, datacad) values (@prod_nome, @prod_estoque, @prod_preco, @prod_marca, @prod_fornecedor, @prod_datacadastro)";

                        //parametros
                        cmd.Parameters.AddWithValue("@prod_nome", usu.Pr_descricao);
                        cmd.Parameters.AddWithValue("@prod_estoque", usu.Pr_quantidade);
                        cmd.Parameters.AddWithValue("@prod_preco", usu.Pr_preco);
                        cmd.Parameters.AddWithValue("@prod_marca", usu.Pr_marca);
                        cmd.Parameters.AddWithValue("@prod_fornecedor", usu.Pr_fornecedor);
                        cmd.Parameters.AddWithValue("@prod_datacadastro", usu.Pr_datacad);


                        // Abrir conexão
                        con.Open();

                        //executar query

                        cmd.ExecuteNonQuery();



                        MessageBox.Show("Produto Cadastrado Com Sucesso.", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaTela();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                        limpatelaProduto();
                        dtgpProduto.DataSource = AtualizaGridP(txtpBusca.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Informe a quantidade");

                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        #endregion

        #region Atualiza Grid Produtos

        public DataTable AtualizaGridP(string filtro)
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
                    da.SelectCommand.CommandText = "select codigo, descricao, quantidade, preco, marca, fornecedor, datacad from produto";

                }
                else
                {
                    da.SelectCommand.CommandText = "select codigo, descricao, quantidade, preco, marca, fornecedor, datacad from produto where descricao like '%' + @prod_nome + '%'";
                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@prod_nome", filtro);
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

        #region Botão Alterar Produto
        private void btnpAlterar_Click(object sender, EventArgs e)
        {

            if (txtpCodigo.TextLength > 0)
            {

                ProdutoInformation usu = new ProdutoInformation();
                usu.Pr_codigo = Convert.ToInt32(txtpCodigo.Text);

                usu.Pr_preco = Convert.ToDecimal(txtpPreco.Text);
                usu.Pr_quantidade = Convert.ToInt32(txtpEstoque.Text);
                usu.Pr_fornecedor = txtpFornecedor.Text;
                usu.Pr_marca = txtpMarca.Text;

                usu.Pr_descricao = txtpNome.Text;
                usu.Pr_datacad = Convert.ToDateTime(dtppDataCadastro.Text);


                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    // command
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update produto set descricao = @prod_nome, preco = @prod_preco, quantidade = @prod_estoque, fornecedor = @prod_fornecedor, marca = @prod_marca,datacad = @prod_datacadastro where codigo = @prod_codigo";

                    //parametros
                    cmd.Parameters.AddWithValue("@prod_codigo", usu.Pr_codigo);
                    cmd.Parameters.AddWithValue("@prod_preco", usu.Pr_preco);
                    cmd.Parameters.AddWithValue("@prod_estoque", usu.Pr_quantidade);
                    cmd.Parameters.AddWithValue("@prod_fornecedor", usu.Pr_fornecedor);
                    cmd.Parameters.AddWithValue("@prod_marca", usu.Pr_marca);
                    cmd.Parameters.AddWithValue("@prod_nome", usu.Pr_descricao);
                    cmd.Parameters.AddWithValue("@prod_datacadastro", usu.Pr_datacad);

                    // Abrir conexão
                    con.Open();

                    //executar query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("atualizado com sucesso", "atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    con.Close();
                    limpatelaProduto();
                    dtgpProduto.DataSource = AtualizaGridP(txtpBusca.Text);
                }
            }
            else
            {
                MessageBox.Show("Selecione Produto Para Alterar", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region clik da grid Produto
        private void dtgpProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnpInserir.Enabled = false;
            txtpEstoque.Enabled = false;


            txtpCodigo.Text = dtgpProduto[0, dtgpProduto.CurrentRow.Index].Value.ToString();
            txtpNome.Text = dtgpProduto[1, dtgpProduto.CurrentRow.Index].Value.ToString();
            txtpEstoque.Text = dtgpProduto[2, dtgpProduto.CurrentRow.Index].Value.ToString();
            txtpPreco.Text = dtgpProduto[3, dtgpProduto.CurrentRow.Index].Value.ToString();
            txtpMarca.Text = dtgpProduto[4, dtgpProduto.CurrentRow.Index].Value.ToString();
            txtpFornecedor.Text = dtgpProduto[5, dtgpProduto.CurrentRow.Index].Value.ToString();
            dtppDataCadastro.Text = dtgpProduto[6, dtgpProduto.CurrentRow.Index].Value.ToString();

        }
        #endregion

        #region Botão excluir
        private void btnpExcluir_Click(object sender, EventArgs e)
        {
            if (txtpCodigo.TextLength > 0)
            {
                ProdutoInformation usu = new ProdutoInformation();
                usu.Pr_codigo = Convert.ToInt32(txtpCodigo.Text);

                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    //command
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from produto where codigo = @prod_codigo";

                    //parametros
                    cmd.Parameters.AddWithValue("@prod_codigo", usu.Pr_codigo);
                    //Abrir conexão
                    con.Open();

                    if (MessageBox.Show("Confirma Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //executar query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Excluido Com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    dtgpProduto.DataSource = AtualizaGridP(txtpBusca.Text);
                }
            }
            else
            {
                MessageBox.Show("Selecione Um Produto Para Excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        #endregion

        #region Limpa Tela Produtos
        public void limpatelaProduto()
        {
            btnpInserir.Enabled = true;
            txtpCodigo.Clear();
            txtpEstoque.Clear();
            txtpFornecedor.Clear();
            txtpMarca.Clear();
            txtpNome.Clear();
            txtpPreco.Clear();
            txtpNome.Focus();

        }
        #endregion

        #region Botão Limpa Tela

        private void btnpLimpaTela_Click(object sender, EventArgs e)
        {
            limpatelaProduto();
        }
        #endregion

        #region Botão Retornar
        private void btnpRetornar_Click(object sender, EventArgs e)
        {
            if (txtpCodigo.TextLength == 0)
            {
                if (MessageBox.Show("DESEJA RETORNAR AO MENU ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Limpa a Tela", "AVISO");
            }

        }
        #endregion

        #region Click Busca Fornecedor
        private void txtpFornecedor_Click(object sender, EventArgs e)
        {
            frmPesquisaFornecedor p = new frmPesquisaFornecedor();          
            p.ShowDialog();
            txtpFornecedor.Text = p.nome;
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo.TextLength == 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Limpa a Tela", "AVISO");
            }
        }

        private void txtpBusca_TextChanged(object sender, EventArgs e)
        {
            dtgpProduto.DataSource = AtualizaGridP(txtpBusca.Text);

        }

        private void cbbtipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbtipo.Text == "Cliente")
            {
                txtIE.Enabled = false;
                mtbCNPJ.Enabled = false;

                txtIE.Visible = false;
                mtbCNPJ.Visible = false;

                lblCNPJ.Visible = false;
                lblIE.Visible = false;

                lblCPF.Visible = true;
                mtbCPF.Enabled = true;
                mtbCPF.Visible = true;

                lblRG.Visible = true;
                mtbRG.Enabled = true;
                mtbRG.Visible = true;

                lblNascimento.Visible = true;
                dtpNascimento.Enabled = true;
                dtpNascimento.Visible = true;
            }
            else if (cbbtipo.Text == "Fornecedor")
            {
                txtIE.Enabled = true;
                mtbCNPJ.Enabled = true;

                txtIE.Visible = true;
                mtbCNPJ.Visible = true;

                lblCNPJ.Visible = true;
                lblIE.Visible = true;

                lblCPF.Visible = false;
                mtbCPF.Enabled = false;
                mtbCPF.Visible = false;

                lblRG.Visible = false;
                mtbRG.Enabled = false;
                mtbRG.Visible = false;

                lblNascimento.Visible = false;
                dtpNascimento.Enabled = false;
                dtpNascimento.Visible = false;

            }
            else
            {
                txtIE.Enabled = true;
                mtbCNPJ.Enabled = true;

                txtIE.Visible = true;
                mtbCNPJ.Visible = true;

                lblCNPJ.Visible = true;
                lblIE.Visible = true;

                lblCPF.Visible = true;
                mtbCPF.Enabled = true;
                mtbCPF.Visible = true;

                lblRG.Visible = true;
                mtbRG.Enabled = true;
                mtbRG.Visible = true;

                lblNascimento.Visible = true;
                dtpNascimento.Enabled = true;
                dtpNascimento.Visible = true;
            }
        }
    }
}