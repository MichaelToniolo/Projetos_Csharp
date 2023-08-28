using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DadosPessoais
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region LetrasMaiúsculas

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }
        #endregion

        #region
        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                //validar o nome
                if (nome.Length == 0)
                {
                    txtNome.Focus();
                    throw new Exception("É necessário preecher nome");
                }

                DateTime dtnasc = dtpData.Value;
                string uf = cbbUF.Text;

                //validar estado
                
                if (uf.Length == 0 )
                {
                    throw new Exception("Favor preencher o Estado (UF)");
                }
                string sexo;

                //validar sexo
                if(rdbM.Checked == false && rdbF.Checked == false)
                {
                    throw new Exception("Favor preencher o sexo");
                }

                else if (rdbM.Checked == true)
                {
                    sexo = "Masculino";
                }
                else
                {
                    sexo = "Feminino";
                }

                lblResultado.Text = nome + " nasceu em " + Convert.ToString(dtNasc) + " reside no estado de " + uf + ", e é do sexo " + sexo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
