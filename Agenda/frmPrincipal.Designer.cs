namespace Agenda
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDT_nasc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpdtnasc = new System.Windows.Forms.DateTimePicker();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelRes = new System.Windows.Forms.Label();
            this.mtbRes = new System.Windows.Forms.MaskedTextBox();
            this.lblTelCel = new System.Windows.Forms.Label();
            this.mtbCel = new System.Windows.Forms.MaskedTextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.lblUF = new System.Windows.Forms.Label();
            this.cbbUF = new System.Windows.Forms.ComboBox();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblDT_nasc
            // 
            this.lblDT_nasc.AutoSize = true;
            this.lblDT_nasc.Location = new System.Drawing.Point(25, 79);
            this.lblDT_nasc.Name = "lblDT_nasc";
            this.lblDT_nasc.Size = new System.Drawing.Size(107, 13);
            this.lblDT_nasc.TabIndex = 1;
            this.lblDT_nasc.Text = "Data de Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // dtpdtnasc
            // 
            this.dtpdtnasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdtnasc.Location = new System.Drawing.Point(154, 73);
            this.dtpdtnasc.Name = "dtpdtnasc";
            this.dtpdtnasc.Size = new System.Drawing.Size(96, 20);
            this.dtpdtnasc.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblTelRes
            // 
            this.lblTelRes.AutoSize = true;
            this.lblTelRes.Location = new System.Drawing.Point(25, 194);
            this.lblTelRes.Name = "lblTelRes";
            this.lblTelRes.Size = new System.Drawing.Size(77, 13);
            this.lblTelRes.TabIndex = 6;
            this.lblTelRes.Text = "Telefone Res.:";
            // 
            // mtbRes
            // 
            this.mtbRes.Location = new System.Drawing.Point(134, 187);
            this.mtbRes.Mask = "(99) 0000-0000";
            this.mtbRes.Name = "mtbRes";
            this.mtbRes.Size = new System.Drawing.Size(85, 20);
            this.mtbRes.TabIndex = 7;
            // 
            // lblTelCel
            // 
            this.lblTelCel.AutoSize = true;
            this.lblTelCel.Location = new System.Drawing.Point(242, 194);
            this.lblTelCel.Name = "lblTelCel";
            this.lblTelCel.Size = new System.Drawing.Size(73, 13);
            this.lblTelCel.TabIndex = 8;
            this.lblTelCel.Text = "Telefone Cel.:";
            // 
            // mtbCel
            // 
            this.mtbCel.Location = new System.Drawing.Point(330, 187);
            this.mtbCel.Mask = "(99) 0000-0000";
            this.mtbCel.Name = "mtbCel";
            this.mtbCel.Size = new System.Drawing.Size(86, 20);
            this.mtbCel.TabIndex = 9;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(27, 227);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(144, 227);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(263, 227);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "&Editar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbF);
            this.gpbSexo.Controls.Add(this.rdbM);
            this.gpbSexo.Location = new System.Drawing.Point(341, 12);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(208, 81);
            this.gpbSexo.TabIndex = 13;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(117, 36);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(67, 17);
            this.rdbF.TabIndex = 1;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "Feminino";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(11, 36);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(73, 17);
            this.rdbM.TabIndex = 0;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "Masculino";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(25, 154);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 14;
            this.lblUF.Text = "UF:";
            // 
            // cbbUF
            // 
            this.cbbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUF.FormattingEnabled = true;
            this.cbbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbbUF.Location = new System.Drawing.Point(69, 154);
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(63, 21);
            this.cbbUF.Sorted = true;
            this.cbbUF.TabIndex = 15;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(28, 287);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(521, 187);
            this.dgvAgenda.TabIndex = 16;
            this.dgvAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellClick);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(28, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(92, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(109, 20);
            this.txtCodigo.TabIndex = 18;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(458, 227);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 486);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.cbbUF);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.mtbCel);
            this.Controls.Add(this.lblTelCel);
            this.Controls.Add(this.mtbRes);
            this.Controls.Add(this.lblTelRes);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dtpdtnasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDT_nasc);
            this.Controls.Add(this.lblNome);
            this.Name = "frmPrincipal";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDT_nasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpdtnasc;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelRes;
        private System.Windows.Forms.MaskedTextBox mtbRes;
        private System.Windows.Forms.Label lblTelCel;
        private System.Windows.Forms.MaskedTextBox mtbCel;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox cbbUF;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnLimpar;
    }
}

