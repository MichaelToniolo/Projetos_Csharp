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
    public partial class frmcadastro : Form
    {
        string cpf, cpfIn;
        char cdig;
        int dig1, dig2;

        public frmcadastro()
        {
            InitializeComponent();
        }
        #region Botão Cadastrar
        private void btnInserir_Click(object sender, EventArgs e)
        {
            validarCPF();
            if (txtRazaoSocial.Text.Length > 0)
            {
                if (lblMensagem.Text == "CPF Válido")
                {

                    lblMensagem.ForeColor = Color.Green;
                    lblMensagem.Text = "CPF Válido";

                    Fornecedor usu = new Fornecedor();
                    usu.Fornecedorr = txtRazaoSocial.Text;
                    //usu.Cl_complemento = txtComplemento.Text;
                    usu.Cpf = mtbCPF.Text;
                    usu.Bairro = txtBairro.Text;
                    usu.Cep = txtCep.Text;
                    //usu.Cidade = txtCidade.Text;
                    usu.Estado = cbbUF.Text;
                    usu.Telefone = mtbTelefone.Text;
                    usu.Celular = mtbCelular.Text;
                    usu.Cnpj = mtbCNPJ.Text;
                    //usu.Cl_numero = Convert.ToInt32(txtNumero.Text);
                    //usu.Cl_sexo = cbbSexo.Text;
                    //usu.Cl_estadocivil = cbbEstadoCivil.Text;
                    usu.Email = txtEmail.Text;
                    //usu.Cl_nascimento = Convert.ToDateTime(dtpNascimento.Text);
                    //usu.Cl_codigo = Convert.ToInt32(txtCodigo.Text);
                    usu.Endereco = txtEndereco.Text;
                    //usu.Cl_rg = mtbRG.Text;
                    //usu.Cl_tipo = cbbtipo.Text;
                    usu.Cidade = txtCidade.Text;
                    usu.Numero = txtNumero.Text;

                    SqlConnection con = new SqlConnection();
                    try
                    {

                        //conexão
                        con.ConnectionString = conexao.conexaoBancoDados;

                        //command
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into cadfornecedor (fornecedor, cpf, bairro, cep, estado, telefone, celular, cnpj, email, endereco, cidade, numero) values (@cliente_nome, @cliente_cpf, @cliente_bairro, @cliente_cep, @cliente_uf, @cliente_telefone, @cliente_celular, @cliente_cnpj, @cliente_email, @cliente_endereco, @cliente_cidade, @cliente_numero)";

                        //parametros
                        //cmd.Parameters.AddWithValue("@cliente_codigo", usu.Cl_codigo);
                        cmd.Parameters.AddWithValue("@cliente_nome", usu.Fornecedorr);
                        //cmd.Parameters.AddWithValue("@cliente_comple", usu.Cl_complemento);
                        //cmd.Parameters.AddWithValue("@cliente_lagradouro", usu.Cl_lagradouro);
                        cmd.Parameters.AddWithValue("@cliente_cpf", usu.Cpf);
                        cmd.Parameters.AddWithValue("@cliente_bairro", usu.Bairro);
                        cmd.Parameters.AddWithValue("@cliente_cep", usu.Cep);
                        //cmd.Parameters.AddWithValue("@cliente_cidade", usu.Cl_cidade);
                        cmd.Parameters.AddWithValue("@cliente_uf", usu.Estado);
                        cmd.Parameters.AddWithValue("@cliente_telefone", usu.Telefone);
                        cmd.Parameters.AddWithValue("@cliente_celular", usu.Celular);
                        cmd.Parameters.AddWithValue("@cliente_cnpj", usu.Cnpj);
                        //cmd.Parameters.AddWithValue("@cliente_numero", usu.Cl_numero);
                        cmd.Parameters.AddWithValue("@cliente_email", usu.Email);
                        //cmd.Parameters.AddWithValue("@cliente_sexo", usu.Cl_sexo);
                        //cmd.Parameters.AddWithValue("@cliente_nascimento", usu.Cl_nascimento);
                        //cmd.Parameters.AddWithValue("@cliente_chapa", usu.Cl_chapa);
                        //cmd.Parameters.AddWithValue("@cliente_rg", usu.Cl_rg);
                        //cmd.Parameters.AddWithValue("@cliente_estadocivil", usu.Cl_estadocivil);
                        //cmd.Parameters.AddWithValue("@tipo", usu.Cl_tipo);
                        cmd.Parameters.AddWithValue("@cliente_endereco", usu.Endereco);
                        cmd.Parameters.AddWithValue("@cliente_cidade", usu.Cidade);
                        cmd.Parameters.AddWithValue("@cliente_numero", usu.Numero);
                        // Abrir conexão
                        con.Open();

                        //executar query

                        cmd.ExecuteNonQuery();



                        MessageBox.Show("Usuario Cadastrado Com Sucesso.", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaTela();

                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("CPF ou CNPJ Já cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                        dtgCliente.DataSource = AtualizaGrid(txtBusca.Text);
                    }

                }

                else
                {
                    MessageBox.Show("Por Gentileza Informe CPF Valido");

                }
            }
            else
            {
                MessageBox.Show("Por Gentileza Informe a Razão Social", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Validar CPF
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
        #endregion

        #region Método Limpa Tela
        public void LimpaTela()
        {
            btnInserir.Enabled = true;
            txtCodigo.Clear();
            txtRazaoSocial.Clear();
            mtbCNPJ.Clear();
            mtbCPF.Clear();
            
            txtCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
           
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            mtbTelefone.Clear();
            mtbCelular.Clear();
           
            cbbUF.SelectedIndex = -1;
            txtRazaoSocial.Focus();
            

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
                    da.SelectCommand.CommandText = "select codigo, fornecedor, cpf, cnpj, telefone, celular, email, endereco, numero, bairro, cidade, estado, cep from cadfornecedor";

                }
                else
                {
                    da.SelectCommand.CommandText = "select codigo, fornecedor, cpf, cnpj, telefone, celular, email, endereco, numero, bairro, cidade, estado, cep from cadfornecedor where fornecedor like '%' + @prod_nome + '%' or codigo like '%' + @prod_cod + '%' or cpf like '%' + @prod_cpf + '%' or cnpj like '%' + @prod_cnpj + '%' or cidade like '%' + @prod_cidade + '%'";
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

        #region Botão Alterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.TextLength > 0)
            {
                if (txtRazaoSocial.TextLength > 0)
                {
                    Fornecedor usu = new Fornecedor();
                    usu.Codigo = Convert.ToInt32(txtCodigo.Text);
                    usu.Fornecedorr = txtRazaoSocial.Text;
                    
                    usu.Cpf = mtbCPF.Text;
                    usu.Bairro = txtBairro.Text;
                    usu.Cep = txtCep.Text;
                    usu.Cidade = txtCidade.Text;
                    usu.Estado = cbbUF.Text;
                    usu.Telefone = mtbTelefone.Text;
                    usu.Celular = mtbCelular.Text;
                    usu.Cnpj = mtbCNPJ.Text;
                    usu.Numero = txtNumero.Text;
                    
                    
                    usu.Email = txtEmail.Text;
                    
                    
                    usu.Endereco = txtEndereco.Text;
                    
                    
                    validarCPF();

                    SqlConnection con = new SqlConnection();
                    try
                    {
                        //conexão
                        con.ConnectionString = conexao.conexaoBancoDados;

                        // command
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update cadfornecedor set fornecedor = @cliente_nome, cpf = @cliente_cpf, bairro = @cliente_bairro, cep = @cliente_cep, estado = @cliente_uf, telefone = @cliente_telefone, celular = @cliente_celular, cnpj = @cliente_cnpj, email = @cliente_email, endereco = @cliente_endereco, cidade = @cliente_cidade, numero = @cliente_numero where codigo = @cliente_codigo";

                        //parametros
                        cmd.Parameters.AddWithValue("@cliente_codigo", usu.Codigo);
                        cmd.Parameters.AddWithValue("@cliente_nome", usu.Fornecedorr);
                        //cmd.Parameters.AddWithValue("@cliente_comple", usu.Cl_complemento);
                        //cmd.Parameters.AddWithValue("@cliente_lagradouro", usu.Cl_lagradouro);
                        cmd.Parameters.AddWithValue("@cliente_cpf", usu.Cpf);
                        cmd.Parameters.AddWithValue("@cliente_bairro", usu.Bairro);
                        cmd.Parameters.AddWithValue("@cliente_cep", usu.Cep);
                        //cmd.Parameters.AddWithValue("@cliente_cidade", usu.Cl_cidade);
                        cmd.Parameters.AddWithValue("@cliente_uf", usu.Estado);
                        cmd.Parameters.AddWithValue("@cliente_telefone", usu.Telefone);
                        cmd.Parameters.AddWithValue("@cliente_celular", usu.Celular);
                        cmd.Parameters.AddWithValue("@cliente_cnpj", usu.Cnpj);
                        //cmd.Parameters.AddWithValue("@cliente_numero", usu.Cl_numero);
                        cmd.Parameters.AddWithValue("@cliente_email", usu.Email);
                        //cmd.Parameters.AddWithValue("@cliente_sexo", usu.Cl_sexo);
                        //cmd.Parameters.AddWithValue("@cliente_nascimento", usu.Cl_nascimento);
                        //cmd.Parameters.AddWithValue("@cliente_chapa", usu.Cl_chapa);
                        //cmd.Parameters.AddWithValue("@cliente_rg", usu.Cl_rg);
                        //cmd.Parameters.AddWithValue("@cliente_estadocivil", usu.Cl_estadocivil);
                        //cmd.Parameters.AddWithValue("@tipo", usu.Cl_tipo);
                        cmd.Parameters.AddWithValue("@cliente_endereco", usu.Endereco);
                        cmd.Parameters.AddWithValue("@cliente_cidade", usu.Cidade);
                        cmd.Parameters.AddWithValue("@cliente_numero", usu.Numero);

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
                else
                {
                    MessageBox.Show("Selecione Cliente Para Alterar", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Click Da DataGrid
        private void dtgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnInserir.Enabled = false;
            txtCodigo.Text = dtgCliente[0, dtgCliente.CurrentRow.Index].Value.ToString();
            txtRazaoSocial.Text = dtgCliente[1, dtgCliente.CurrentRow.Index].Value.ToString();
            mtbCPF.Text = dtgCliente[2, dtgCliente.CurrentRow.Index].Value.ToString();
            mtbCNPJ.Text = dtgCliente[3, dtgCliente.CurrentRow.Index].Value.ToString();
            mtbTelefone.Text = dtgCliente[4, dtgCliente.CurrentRow.Index].Value.ToString();
            mtbCelular.Text = dtgCliente[5, dtgCliente.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dtgCliente[6, dtgCliente.CurrentRow.Index].Value.ToString();            
            txtEndereco.Text = dtgCliente[7, dtgCliente.CurrentRow.Index].Value.ToString();
            txtNumero.Text = dtgCliente[8, dtgCliente.CurrentRow.Index].Value.ToString();
            txtBairro.Text = dtgCliente[9, dtgCliente.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dtgCliente[10, dtgCliente.CurrentRow.Index].Value.ToString();
            cbbUF.Text = dtgCliente[11, dtgCliente.CurrentRow.Index].Value.ToString();
            txtCep.Text = dtgCliente[12, dtgCliente.CurrentRow.Index].Value.ToString();
        }
        #endregion

        #region Load
        private void frmcadastro_Load(object sender, EventArgs e)
        {
            dtgCliente.DataSource = AtualizaGrid(txtBusca.Text);

            //Cabeçalho da datagrid
            dtgCliente.Columns[0].HeaderText = "Codigo";
            dtgCliente.Columns[1].HeaderText = "Fornecedor";
            dtgCliente.Columns[2].HeaderText = "Cpf";
            dtgCliente.Columns[3].HeaderText = "Cnpj";
            dtgCliente.Columns[4].HeaderText = "Telefone";
            dtgCliente.Columns[5].HeaderText = "Celular";
            dtgCliente.Columns[6].HeaderText = "Email";
            dtgCliente.Columns[7].HeaderText = "endereco";
            dtgCliente.Columns[8].HeaderText = "Numero";
            dtgCliente.Columns[9].HeaderText = "Bairro";
            dtgCliente.Columns[10].HeaderText = "Cidade";
            dtgCliente.Columns[11].HeaderText = "Estado";
            dtgCliente.Columns[12].HeaderText = "Cep";          


            //Largura das colunas
            dtgCliente.Columns[0].Width = 60;
            dtgCliente.Columns[1].Width = 200;
            dtgCliente.Columns[2].Width = 150;
            dtgCliente.Columns[3].Width = 200;
            dtgCliente.Columns[4].Width = 120;
            dtgCliente.Columns[5].Width = 150;
            dtgCliente.Columns[6].Width = 80;
            dtgCliente.Columns[7].Width = 100;
            dtgCliente.Columns[8].Width = 40;
            dtgCliente.Columns[9].Width = 100;
            dtgCliente.Columns[10].Width = 100;
            dtgCliente.Columns[11].Width = 110;
            dtgCliente.Columns[12].Width = 110;
            

            //Permissões da datagrid
            dtgCliente.ReadOnly = true;
            dtgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCliente.AllowUserToAddRows = false;
            dtgCliente.AllowUserToDeleteRows = false;
            dtgCliente.AllowUserToResizeColumns = false;
            dtgCliente.AllowUserToResizeRows = false;

            
            //Largura das colunas
            dtgCliente.Columns[0].Width = 60;
            dtgCliente.Columns[1].Width = 200;
            dtgCliente.Columns[2].Width = 150;
            dtgCliente.Columns[3].Width = 200;
            dtgCliente.Columns[4].Width = 120;
            dtgCliente.Columns[5].Width = 150;
            dtgCliente.Columns[6].Width = 80;
            dtgCliente.Columns[7].Width = 80;
            dtgCliente.Columns[8].Width = 80;
            dtgCliente.Columns[9].Width = 80;
            dtgCliente.Columns[10].Width = 80;
            dtgCliente.Columns[11].Width = 80;
            dtgCliente.Columns[12].Width = 80;


            
        }
        #endregion

        #region Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.TextLength > 0)
            {
                Fornecedor usu = new Fornecedor();
                usu.Codigo = Convert.ToInt32(txtCodigo.Text);


                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = conexao.conexaoBancoDados;

                    //command
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from cadfornecedor where codigo = @cliente_codigo";

                    //parametros
                    cmd.Parameters.AddWithValue("@cliente_codigo", usu.Codigo);


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

    }
}
