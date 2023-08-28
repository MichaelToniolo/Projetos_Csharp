using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Toda vez que criar conexão com o Banco de Dados addicionar a linha abaixo
using System.Data.SqlClient;

namespace Agenda
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #region Inserir Click
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Encapsulamento enc = new Encapsulamento();
            enc.age_nome = txtNome.Text;
            enc.age_dtnasc = dtpdtnasc.Value;
            enc.age_email = txtEmail.Text;
            enc.age_telcel = mtbCel.Text;
            enc.age_telres = lblTelRes.Text;
            enc.age_uf = cbbUF.Text;            
            
            //Condição de Radio Button

            if (rdbM.Checked == true)
            {
                enc.age_sexo = "M";
            }
            else
            {
                enc.age_sexo = "F";
            }

            //Conexão
            SqlConnection cn = new SqlConnection();

            try
            {
                //Chamando o endereço de conexão
                cn.ConnectionString = Dados.StringDeConexao;
                //Command
                //chamando o comando de conexão
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into agenda (age_nome, age_dtnasc, " +
                    "age_emails, age_telcel, age_telres, age_sexo, age_uf) Values (@age_nome, @age_dtnasc, @age_emails, " +
                    "@age_telcel, @age_telres, @age_sexo, @age_uf)";

                //Abrir Conexão
                cn.Open();

                //Passar valores para os campos
                cmd.Parameters.AddWithValue("@age_nome", enc.age_nome);
                cmd.Parameters.AddWithValue("@age_dtnasc", enc.age_dtnasc);
                cmd.Parameters.AddWithValue("@age_emails", enc.age_email);
                cmd.Parameters.AddWithValue("@age_telcel", enc.age_telcel);
                cmd.Parameters.AddWithValue("@age_telres", enc.age_telres);
                cmd.Parameters.AddWithValue("@age_sexo", enc.age_sexo);
                cmd.Parameters.AddWithValue("@age_uf", enc.age_uf);
                //Testar o campo nome
                if (enc.age_nome.Trim().Length == 0)
                {
                    throw new Exception("O Campo Nome é obrigatório");
                    txtNome.Focus();
                }

                //Testar o Sexo
                if (rdbF.Checked == false && rdbM.Checked == false)
                {
                    gpbSexo.Focus();
                    throw new Exception("O campo SEXO é Obrigatório");
                }

                //Executar a Query de INSERT

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro incluido com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                AtualizaGrid();
                //Fecha a conexão com o Banco!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                cn.Close();
                
                
            }
        }
        #endregion
           
        #region Charateres
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.CharacterCasing = CharacterCasing.Lower;
        }
        #endregion

        #region LimpaTela
        public void LimpaTela()
        {
            txtNome.Clear();
            dtpdtnasc.Value = DateTime.Now;
            txtEmail.Clear();
            mtbCel.Clear();
            mtbRes.Clear();
            txtNome.Focus();
            btnInserir.Enabled = true;
            txtCodigo.Clear();
        }
        #endregion

        #region AtualizaGrid
        public void AtualizaGrid()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                con.ConnectionString = Dados.StringDeConexao;

                //Adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = "select * from agenda";

                da.Fill(dt);

                // Preencer a DataGridView

                dgvAgenda.DataSource = dt;

                //CABEÇALHO
                dgvAgenda.Columns[0].HeaderText = "Código";
                dgvAgenda.Columns[1].HeaderText = "Nome";
                dgvAgenda.Columns[2].HeaderText = "Data de Nascimento";
                dgvAgenda.Columns[3].HeaderText = "E-mail";
                dgvAgenda.Columns[4].HeaderText = "Tel.Cel";
                dgvAgenda.Columns[5].HeaderText = "Tel.Res";
                dgvAgenda.Columns[6].HeaderText = "UF";
                dgvAgenda.Columns[7].HeaderText = "Sexo";


                //LARGURA
                dgvAgenda.Columns[0].Width = 40;
                dgvAgenda.Columns[1].Width = 100;
                dgvAgenda.Columns[2].Width = 100;
                dgvAgenda.Columns[3].Width = 100;
                dgvAgenda.Columns[4].Width = 100;
                dgvAgenda.Columns[5].Width = 100;
                dgvAgenda.Columns[6].Width = 40;
                dgvAgenda.Columns[7].Width = 40;
                //Configurar Seleção

                dgvAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //OPERAÇOES DESEJADAS

                dgvAgenda.AllowUserToAddRows = false;
                dgvAgenda.AllowUserToAddRows = false;
                dgvAgenda.ReadOnly = true;
            }
            catch (SqlException ex)
            {

            }
            finally
            {

            }
        }
        #endregion

        #region Load
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            AtualizaGrid();
        }
        #endregion

        #region Click Datagrid
        private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnInserir.Enabled = false;

            txtCodigo.Text = dgvAgenda[0, dgvAgenda.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvAgenda[1, dgvAgenda.CurrentRow.Index].Value.ToString();
            dtpdtnasc.Value = Convert.ToDateTime(dgvAgenda[2, dgvAgenda.CurrentRow.Index].Value.ToString());
            txtEmail.Text = dgvAgenda[3, dgvAgenda.CurrentRow.Index].Value.ToString();
            mtbCel.Text = dgvAgenda[4, dgvAgenda.CurrentRow.Index].Value.ToString();
            mtbRes.Text = dgvAgenda[5, dgvAgenda.CurrentRow.Index].Value.ToString();
            if (dgvAgenda[6, dgvAgenda.CurrentRow.Index].Value.ToString() == "M")
            {
                rdbM.Checked = true;
            }
            else
            {
                rdbF.Checked = true;
            }
        }
        #endregion

        #region Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Realmente excluir?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Conexão
                SqlConnection con = new SqlConnection();


                try
                {
                    con.ConnectionString = Dados.StringDeConexao;

                    //COMMANDO
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from agenda where age_id = @age_id";

                    con.Open();

                    //Passagem de parâmetro
                    cmd.Parameters.AddWithValue("@age_id", txtCodigo.Text);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado == 1)
                    {
                        MessageBox.Show("Cliente excluído com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("Não foi possível excluir o Cliente");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    AtualizaGrid();
                    LimpaTela();
                }
            }
            

        }
        #endregion

        #region BtnLimpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
        #endregion

        #region
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Encapsulamento enc = new Encapsulamento();

            enc.age_id = Convert.ToInt16(txtCodigo.Text);
            enc.age_nome = txtNome.Text;
            enc.age_dtnasc = dtpdtnasc.Value;
            enc.age_email = txtEmail.Text;
            enc.age_telcel = mtbCel.Text;
            enc.age_telres = mtbRes.Text;
            enc.age_uf = cbbUF.Text;

            if (rdbM.Checked == true)
            {
                enc.age_sexo = "M";
            }
            else
            {
                enc.age_sexo = "F";
            }

            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Dados.StringDeConexao;

                //Command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update agenda set age_nome = @age_nome, age_dtnasc = @age_dtnasc, " +
                    "age_emails = @age_emails, age_telcel = @age_telcel, age_telres = @age_telres, " +
                    "age_sexo = @age_sexo, age_uf = @age_uf where age_id = @age_id";

                //Passagem de valores
                cmd.Parameters.AddWithValue("@age_id", enc.age_id);
                cmd.Parameters.AddWithValue("@age_nome", enc.age_nome);
                cmd.Parameters.AddWithValue("@age_dtnasc", enc.age_dtnasc);
                cmd.Parameters.AddWithValue("@age_emails", enc.age_email);
                cmd.Parameters.AddWithValue("@age_telcel", enc.age_telcel);
                cmd.Parameters.AddWithValue("@age_telres", enc.age_telres);
                cmd.Parameters.AddWithValue("@age_sexo", enc.age_sexo);
                cmd.Parameters.AddWithValue("@age_uf", enc.age_uf);

                if (enc.age_nome.Trim().Length == 0)
                {
                    throw new Exception("O Campo NOME é de preenchimento obrigatório");
                }

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com êxito", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaTela();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                con.Close();
                AtualizaGrid();
            }
                

        }
        #endregion
    }
}