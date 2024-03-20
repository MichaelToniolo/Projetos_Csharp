namespace FF
{
    partial class frmcadastro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCadCliente = new System.Windows.Forms.TabPage();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.cbbUF = new System.Windows.Forms.ComboBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblBusca = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpaTela = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.tabCad = new System.Windows.Forms.TabControl();
            this.btnCadCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.tabCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadCliente.Controls.Add(this.txtCep);
            this.btnCadCliente.Controls.Add(this.lblMensagem);
            this.btnCadCliente.Controls.Add(this.mtbCNPJ);
            this.btnCadCliente.Controls.Add(this.lblCNPJ);
            this.btnCadCliente.Controls.Add(this.dtgCliente);
            this.btnCadCliente.Controls.Add(this.txtNumero);
            this.btnCadCliente.Controls.Add(this.txtEmail);
            this.btnCadCliente.Controls.Add(this.txtCodigo);
            this.btnCadCliente.Controls.Add(this.txtBusca);
            this.btnCadCliente.Controls.Add(this.txtCidade);
            this.btnCadCliente.Controls.Add(this.txtBairro);
            this.btnCadCliente.Controls.Add(this.txtEndereco);
            this.btnCadCliente.Controls.Add(this.txtRazaoSocial);
            this.btnCadCliente.Controls.Add(this.lblNumero);
            this.btnCadCliente.Controls.Add(this.lblEmail);
            this.btnCadCliente.Controls.Add(this.mtbCPF);
            this.btnCadCliente.Controls.Add(this.cbbUF);
            this.btnCadCliente.Controls.Add(this.btnMenu);
            this.btnCadCliente.Controls.Add(this.mtbCelular);
            this.btnCadCliente.Controls.Add(this.mtbTelefone);
            this.btnCadCliente.Controls.Add(this.lblCodigo);
            this.btnCadCliente.Controls.Add(this.lblBusca);
            this.btnCadCliente.Controls.Add(this.btnAlterar);
            this.btnCadCliente.Controls.Add(this.btnExcluir);
            this.btnCadCliente.Controls.Add(this.btnLimpaTela);
            this.btnCadCliente.Controls.Add(this.btnInserir);
            this.btnCadCliente.Controls.Add(this.lblCelular);
            this.btnCadCliente.Controls.Add(this.lblUF);
            this.btnCadCliente.Controls.Add(this.lblCidade);
            this.btnCadCliente.Controls.Add(this.lblCep);
            this.btnCadCliente.Controls.Add(this.lblCPF);
            this.btnCadCliente.Controls.Add(this.lblTelefone);
            this.btnCadCliente.Controls.Add(this.lblBairro);
            this.btnCadCliente.Controls.Add(this.lblEndereco);
            this.btnCadCliente.Controls.Add(this.lblRazaoSocial);
            this.btnCadCliente.Location = new System.Drawing.Point(4, 22);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Padding = new System.Windows.Forms.Padding(3);
            this.btnCadCliente.Size = new System.Drawing.Size(819, 476);
            this.btnCadCliente.TabIndex = 1;
            this.btnCadCliente.Text = "Cliente / Fornecedor";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(112, 96);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(58, 20);
            this.txtCep.TabIndex = 9;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(268, 73);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 169;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.ForeColor = System.Drawing.Color.Black;
            this.mtbCNPJ.Location = new System.Drawing.Point(111, 44);
            this.mtbCNPJ.Mask = "00.000.000/0000-00";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(106, 20);
            this.mtbCNPJ.TabIndex = 2;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(40, 47);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(44, 14);
            this.lblCNPJ.TabIndex = 167;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // dtgCliente
            // 
            this.dtgCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCliente.Location = new System.Drawing.Point(42, 221);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.Size = new System.Drawing.Size(704, 165);
            this.dtgCliente.TabIndex = 19;
            this.dtgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCliente_CellClick);
            // 
            // txtNumero
            // 
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(373, 128);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(45, 20);
            this.txtNumero.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(111, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(111, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(95, 20);
            this.txtCodigo.TabIndex = 146;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(153, 482);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(338, 20);
            this.txtBusca.TabIndex = 24;
            // 
            // txtCidade
            // 
            this.txtCidade.ForeColor = System.Drawing.Color.Black;
            this.txtCidade.Location = new System.Drawing.Point(302, 154);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(157, 20);
            this.txtCidade.TabIndex = 14;
            // 
            // txtBairro
            // 
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(111, 158);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(107, 20);
            this.txtBairro.TabIndex = 13;
            // 
            // txtEndereco
            // 
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.Location = new System.Drawing.Point(111, 125);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(205, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.ForeColor = System.Drawing.Color.Black;
            this.txtRazaoSocial.Location = new System.Drawing.Point(392, 21);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(354, 20);
            this.txtRazaoSocial.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(340, 131);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(27, 14);
            this.lblNumero.TabIndex = 151;
            this.lblNumero.Text = "Nº:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 192);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 14);
            this.lblEmail.TabIndex = 148;
            this.lblEmail.Text = "E-mail:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.ForeColor = System.Drawing.Color.Black;
            this.mtbCPF.Location = new System.Drawing.Point(110, 70);
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(83, 20);
            this.mtbCPF.TabIndex = 4;
            // 
            // cbbUF
            // 
            this.cbbUF.ForeColor = System.Drawing.Color.Black;
            this.cbbUF.FormattingEnabled = true;
            this.cbbUF.Items.AddRange(new object[] {
            "AC ",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbbUF.Location = new System.Drawing.Point(510, 154);
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(52, 21);
            this.cbbUF.TabIndex = 15;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(584, 480);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 25;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // mtbCelular
            // 
            this.mtbCelular.ForeColor = System.Drawing.Color.Black;
            this.mtbCelular.Location = new System.Drawing.Point(542, 189);
            this.mtbCelular.Mask = "(99) 0000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(106, 20);
            this.mtbCelular.TabIndex = 18;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.ForeColor = System.Drawing.Color.Black;
            this.mtbTelefone.Location = new System.Drawing.Point(354, 189);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(106, 20);
            this.mtbTelefone.TabIndex = 17;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(39, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 14);
            this.lblCodigo.TabIndex = 145;
            this.lblCodigo.Text = "Código";
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(103, 485);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(44, 14);
            this.lblBusca.TabIndex = 144;
            this.lblBusca.Text = "Busca";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(229, 402);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(52, 27);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(411, 402);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(52, 27);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpaTela
            // 
            this.btnLimpaTela.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpaTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaTela.Location = new System.Drawing.Point(537, 402);
            this.btnLimpaTela.Name = "btnLimpaTela";
            this.btnLimpaTela.Size = new System.Drawing.Size(52, 27);
            this.btnLimpaTela.TabIndex = 23;
            this.btnLimpaTela.Text = "Limpa Tela";
            this.btnLimpaTela.UseVisualStyleBackColor = false;
            this.btnLimpaTela.Click += new System.EventHandler(this.btnLimpaTela_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(57, 402);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(52, 27);
            this.btnInserir.TabIndex = 20;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(476, 189);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(60, 14);
            this.lblCelular.TabIndex = 139;
            this.lblCelular.Text = "Celular:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(476, 157);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(28, 14);
            this.lblUF.TabIndex = 138;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(238, 154);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(55, 14);
            this.lblCidade.TabIndex = 135;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(40, 99);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(35, 14);
            this.lblCep.TabIndex = 134;
            this.lblCep.Text = "CEP:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(39, 73);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(35, 14);
            this.lblCPF.TabIndex = 126;
            this.lblCPF.Text = "CPF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(283, 192);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(67, 14);
            this.lblTelefone.TabIndex = 124;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(40, 164);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(53, 14);
            this.lblBairro.TabIndex = 123;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(40, 128);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(70, 14);
            this.lblEndereco.TabIndex = 121;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(299, 24);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(90, 14);
            this.lblRazaoSocial.TabIndex = 119;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // tabCad
            // 
            this.tabCad.Controls.Add(this.btnCadCliente);
            this.tabCad.Location = new System.Drawing.Point(12, 12);
            this.tabCad.Name = "tabCad";
            this.tabCad.SelectedIndex = 0;
            this.tabCad.Size = new System.Drawing.Size(827, 502);
            this.tabCad.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabCad.TabIndex = 1;
            // 
            // frmcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 521);
            this.Controls.Add(this.tabCad);
            this.Name = "frmcadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcadastro";
            this.Load += new System.EventHandler(this.frmcadastro_Load);
            this.btnCadCliente.ResumeLayout(false);
            this.btnCadCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.tabCad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage btnCadCliente;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.ComboBox cbbUF;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpaTela;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TabControl tabCad;
    }
}