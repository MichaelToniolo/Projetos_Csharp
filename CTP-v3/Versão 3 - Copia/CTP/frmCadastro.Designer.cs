namespace CTP
{
    partial class frmCadastro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.tabCad = new System.Windows.Forms.TabControl();
            this.btnCadCliente = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.MaskedTextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.lblCredito = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblIE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbtipo = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cbbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblRG = new System.Windows.Forms.Label();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.cbbUF = new System.Windows.Forms.ComboBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpaTela = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.btnCadProduto = new System.Windows.Forms.TabPage();
            this.dtppDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.btnpRetornar = new System.Windows.Forms.Button();
            this.lblpBusca = new System.Windows.Forms.Label();
            this.txtpBusca = new System.Windows.Forms.TextBox();
            this.btnpLimpaTela = new System.Windows.Forms.Button();
            this.btnpExcluir = new System.Windows.Forms.Button();
            this.btnpAlterar = new System.Windows.Forms.Button();
            this.btnpInserir = new System.Windows.Forms.Button();
            this.txtpEstoque = new System.Windows.Forms.TextBox();
            this.lblpEstoque = new System.Windows.Forms.Label();
            this.dtgpProduto = new System.Windows.Forms.DataGridView();
            this.lblpDataCadstro = new System.Windows.Forms.Label();
            this.txtpMarca = new System.Windows.Forms.TextBox();
            this.lblpMarca = new System.Windows.Forms.Label();
            this.txtpFornecedor = new System.Windows.Forms.TextBox();
            this.lblpFornecedor = new System.Windows.Forms.Label();
            this.txtpPreco = new System.Windows.Forms.TextBox();
            this.lblpPreco = new System.Windows.Forms.Label();
            this.txtpNome = new System.Windows.Forms.TextBox();
            this.lblpNome = new System.Windows.Forms.Label();
            this.txtpCodigo = new System.Windows.Forms.TextBox();
            this.lblpCodigo = new System.Windows.Forms.Label();
            this.tabCad.SuspendLayout();
            this.btnCadCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.btnCadProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCad
            // 
            this.tabCad.Controls.Add(this.btnCadCliente);
            this.tabCad.Controls.Add(this.btnCadProduto);
            this.tabCad.Location = new System.Drawing.Point(2, 12);
            this.tabCad.Name = "tabCad";
            this.tabCad.SelectedIndex = 0;
            this.tabCad.Size = new System.Drawing.Size(789, 548);
            this.tabCad.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabCad.TabIndex = 0;
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCadCliente.Controls.Add(this.label3);
            this.btnCadCliente.Controls.Add(this.label2);
            this.btnCadCliente.Controls.Add(this.txtIE);
            this.btnCadCliente.Controls.Add(this.txtCredito);
            this.btnCadCliente.Controls.Add(this.lblCredito);
            this.btnCadCliente.Controls.Add(this.cbbStatus);
            this.btnCadCliente.Controls.Add(this.lblStatus);
            this.btnCadCliente.Controls.Add(this.lblIE);
            this.btnCadCliente.Controls.Add(this.label1);
            this.btnCadCliente.Controls.Add(this.cbbtipo);
            this.btnCadCliente.Controls.Add(this.txtCep);
            this.btnCadCliente.Controls.Add(this.lblMensagem);
            this.btnCadCliente.Controls.Add(this.mtbCNPJ);
            this.btnCadCliente.Controls.Add(this.lblCNPJ);
            this.btnCadCliente.Controls.Add(this.dtgCliente);
            this.btnCadCliente.Controls.Add(this.lblEstadoCivil);
            this.btnCadCliente.Controls.Add(this.cbbEstadoCivil);
            this.btnCadCliente.Controls.Add(this.lblNascimento);
            this.btnCadCliente.Controls.Add(this.dtpNascimento);
            this.btnCadCliente.Controls.Add(this.lblRG);
            this.btnCadCliente.Controls.Add(this.mtbRG);
            this.btnCadCliente.Controls.Add(this.txtNumero);
            this.btnCadCliente.Controls.Add(this.lblNumero);
            this.btnCadCliente.Controls.Add(this.txtEmail);
            this.btnCadCliente.Controls.Add(this.lblEmail);
            this.btnCadCliente.Controls.Add(this.mtbCPF);
            this.btnCadCliente.Controls.Add(this.cbbUF);
            this.btnCadCliente.Controls.Add(this.btnMenu);
            this.btnCadCliente.Controls.Add(this.mtbCelular);
            this.btnCadCliente.Controls.Add(this.mtbTelefone);
            this.btnCadCliente.Controls.Add(this.txtCodigo);
            this.btnCadCliente.Controls.Add(this.lblCodigo);
            this.btnCadCliente.Controls.Add(this.txtBusca);
            this.btnCadCliente.Controls.Add(this.lblBusca);
            this.btnCadCliente.Controls.Add(this.btnAlterar);
            this.btnCadCliente.Controls.Add(this.btnExcluir);
            this.btnCadCliente.Controls.Add(this.btnLimpaTela);
            this.btnCadCliente.Controls.Add(this.btnInserir);
            this.btnCadCliente.Controls.Add(this.txtComplemento);
            this.btnCadCliente.Controls.Add(this.txtCidade);
            this.btnCadCliente.Controls.Add(this.lblCelular);
            this.btnCadCliente.Controls.Add(this.lblUF);
            this.btnCadCliente.Controls.Add(this.lblCidade);
            this.btnCadCliente.Controls.Add(this.lblCep);
            this.btnCadCliente.Controls.Add(this.lblComplemento);
            this.btnCadCliente.Controls.Add(this.txtBairro);
            this.btnCadCliente.Controls.Add(this.txtEndereco);
            this.btnCadCliente.Controls.Add(this.txtRazaoSocial);
            this.btnCadCliente.Controls.Add(this.lblCPF);
            this.btnCadCliente.Controls.Add(this.lblTelefone);
            this.btnCadCliente.Controls.Add(this.lblBairro);
            this.btnCadCliente.Controls.Add(this.lblEndereco);
            this.btnCadCliente.Controls.Add(this.lblRazaoSocial);
            this.btnCadCliente.Location = new System.Drawing.Point(4, 22);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Padding = new System.Windows.Forms.Padding(3);
            this.btnCadCliente.Size = new System.Drawing.Size(781, 522);
            this.btnCadCliente.TabIndex = 1;
            this.btnCadCliente.Text = "Clientes/Fornecedores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 14);
            this.label3.TabIndex = 179;
            this.label3.Text = "Campo Obrigatório";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 178;
            this.label2.Text = "*";
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(269, 29);
            this.txtIE.Mask = "000,000,000,000";
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(100, 20);
            this.txtIE.TabIndex = 0;
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(613, 163);
            this.txtCredito.MaxLength = 9;
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(76, 20);
            this.txtCredito.TabIndex = 19;
            this.txtCredito.Visible = false;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.Location = new System.Drawing.Point(515, 166);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(92, 14);
            this.lblCredito.TabIndex = 177;
            this.lblCredito.Text = "Lim. Crédito:";
            this.lblCredito.Visible = false;
            // 
            // cbbStatus
            // 
            this.cbbStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Ativo",
            "Não Ativo"});
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbbStatus.Location = new System.Drawing.Point(419, 163);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(89, 21);
            this.cbbStatus.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(360, 166);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 14);
            this.lblStatus.TabIndex = 175;
            this.lblStatus.Text = "Status:";
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIE.Location = new System.Drawing.Point(231, 32);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(32, 14);
            this.lblIE.TabIndex = 174;
            this.lblIE.Text = "I.E.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(163, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 172;
            this.label1.Text = "*Tipo:";
            // 
            // cbbtipo
            // 
            this.cbbtipo.FormattingEnabled = true;
            this.cbbtipo.Items.AddRange(new object[] {
            "Cliente",
            "Fornecedor"});
            this.cbbtipo.Location = new System.Drawing.Point(209, 5);
            this.cbbtipo.Name = "cbbtipo";
            this.cbbtipo.Size = new System.Drawing.Size(108, 21);
            this.cbbtipo.TabIndex = 3;
            this.cbbtipo.SelectedValueChanged += new System.EventHandler(this.cbbtipo_SelectedValueChanged);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(112, 84);
            this.txtCep.Mask = "00000000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(58, 20);
            this.txtCep.TabIndex = 10;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(509, 116);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 169;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.ForeColor = System.Drawing.Color.Black;
            this.mtbCNPJ.Location = new System.Drawing.Point(112, 29);
            this.mtbCNPJ.Mask = "00.000.000/0000-00";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(106, 20);
            this.mtbCNPJ.TabIndex = 2;
            this.mtbCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCNPJ_KeyPress);
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(41, 32);
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
            this.dtgCliente.Location = new System.Drawing.Point(42, 217);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.Size = new System.Drawing.Size(704, 222);
            this.dtgCliente.TabIndex = 22;
            this.dtgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCliente_CellClick);
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEstadoCivil.Location = new System.Drawing.Point(542, 61);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(69, 14);
            this.lblEstadoCivil.TabIndex = 159;
            this.lblEstadoCivil.Text = "Est. Civil:";
            this.lblEstadoCivil.Visible = false;
            // 
            // cbbEstadoCivil
            // 
            this.cbbEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstadoCivil.FormattingEnabled = true;
            this.cbbEstadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)",
            "Não Especificado(a)"});
            this.cbbEstadoCivil.Location = new System.Drawing.Point(617, 58);
            this.cbbEstadoCivil.Name = "cbbEstadoCivil";
            this.cbbEstadoCivil.Size = new System.Drawing.Size(131, 21);
            this.cbbEstadoCivil.TabIndex = 9;
            this.cbbEstadoCivil.Visible = false;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNascimento.Location = new System.Drawing.Point(336, 61);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(88, 14);
            this.lblNascimento.TabIndex = 157;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(430, 58);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(99, 20);
            this.dtpNascimento.TabIndex = 8;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRG.Location = new System.Drawing.Point(211, 61);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(29, 14);
            this.lblRG.TabIndex = 154;
            this.lblRG.Text = "RG:";
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(246, 58);
            this.mtbRG.Mask = "00.000.000-0";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(74, 20);
            this.mtbRG.TabIndex = 7;
            this.mtbRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbRG_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(377, 107);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(59, 20);
            this.txtNumero.TabIndex = 12;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(344, 107);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(27, 14);
            this.lblNumero.TabIndex = 151;
            this.lblNumero.Text = "Nº:";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(112, 163);
            this.txtEmail.MaxLength = 79;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(42, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 14);
            this.lblEmail.TabIndex = 148;
            this.lblEmail.Text = "E-mail:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.ForeColor = System.Drawing.Color.Black;
            this.mtbCPF.Location = new System.Drawing.Point(112, 58);
            this.mtbCPF.Mask = "000.000.000/00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(83, 20);
            this.mtbCPF.TabIndex = 5;
            // 
            // cbbUF
            // 
            this.cbbUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbbUF.Location = new System.Drawing.Point(532, 136);
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(52, 21);
            this.cbbUF.TabIndex = 16;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Crimson;
            this.btnMenu.Location = new System.Drawing.Point(669, 451);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(77, 65);
            this.btnMenu.TabIndex = 29;
            this.btnMenu.Text = "&Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // mtbCelular
            // 
            this.mtbCelular.ForeColor = System.Drawing.Color.Black;
            this.mtbCelular.Location = new System.Drawing.Point(297, 191);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(106, 20);
            this.mtbCelular.TabIndex = 21;
            this.mtbCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCelular_KeyPress);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.ForeColor = System.Drawing.Color.Black;
            this.mtbTelefone.Location = new System.Drawing.Point(112, 191);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(106, 20);
            this.mtbTelefone.TabIndex = 20;
            this.mtbTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbTelefone_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(112, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(45, 20);
            this.txtCodigo.TabIndex = 146;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(41, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 14);
            this.lblCodigo.TabIndex = 145;
            this.lblCodigo.Text = "Código:";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(96, 485);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(500, 20);
            this.txtBusca.TabIndex = 30;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(42, 488);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(55, 16);
            this.lblBusca.TabIndex = 144;
            this.lblBusca.Text = "&Busca:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(190, 451);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(78, 27);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(354, 451);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(78, 27);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpaTela
            // 
            this.btnLimpaTela.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpaTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaTela.Location = new System.Drawing.Point(518, 451);
            this.btnLimpaTela.Name = "btnLimpaTela";
            this.btnLimpaTela.Size = new System.Drawing.Size(78, 27);
            this.btnLimpaTela.TabIndex = 28;
            this.btnLimpaTela.Text = "Limpa Tela";
            this.btnLimpaTela.UseVisualStyleBackColor = false;
            this.btnLimpaTela.Click += new System.EventHandler(this.btnLimpaTela_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(42, 451);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(78, 27);
            this.btnInserir.TabIndex = 25;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtComplemento
            // 
            this.txtComplemento.ForeColor = System.Drawing.Color.Black;
            this.txtComplemento.Location = new System.Drawing.Point(563, 107);
            this.txtComplemento.MaxLength = 9;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(138, 20);
            this.txtComplemento.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.ForeColor = System.Drawing.Color.Black;
            this.txtCidade.Location = new System.Drawing.Point(292, 136);
            this.txtCidade.MaxLength = 79;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(196, 20);
            this.txtCidade.TabIndex = 15;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(231, 194);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(66, 14);
            this.lblCelular.TabIndex = 139;
            this.lblCelular.Text = "*Celular:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(498, 139);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(28, 14);
            this.lblUF.TabIndex = 138;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(231, 139);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(55, 14);
            this.lblCidade.TabIndex = 135;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(41, 87);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(35, 14);
            this.lblCep.TabIndex = 134;
            this.lblCep.Text = "CEP:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(456, 107);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(101, 14);
            this.lblComplemento.TabIndex = 132;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtBairro
            // 
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(112, 136);
            this.txtBairro.MaxLength = 99;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(107, 20);
            this.txtBairro.TabIndex = 14;
            // 
            // txtEndereco
            // 
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.Location = new System.Drawing.Point(112, 110);
            this.txtEndereco.MaxLength = 99;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(205, 20);
            this.txtEndereco.TabIndex = 11;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.ForeColor = System.Drawing.Color.Black;
            this.txtRazaoSocial.Location = new System.Drawing.Point(377, 6);
            this.txtRazaoSocial.MaxLength = 49;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(379, 20);
            this.txtRazaoSocial.TabIndex = 1;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(41, 61);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 14);
            this.lblCPF.TabIndex = 126;
            this.lblCPF.Text = "*CPF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(42, 194);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(73, 14);
            this.lblTelefone.TabIndex = 124;
            this.lblTelefone.Text = "*Telefone:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(42, 139);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(53, 14);
            this.lblBairro.TabIndex = 123;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(41, 113);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(70, 14);
            this.lblEndereco.TabIndex = 121;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(323, 9);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(54, 14);
            this.lblRazaoSocial.TabIndex = 119;
            this.lblRazaoSocial.Text = "*Nome:";
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadProduto.Controls.Add(this.dtppDataCadastro);
            this.btnCadProduto.Controls.Add(this.btnpRetornar);
            this.btnCadProduto.Controls.Add(this.lblpBusca);
            this.btnCadProduto.Controls.Add(this.txtpBusca);
            this.btnCadProduto.Controls.Add(this.btnpLimpaTela);
            this.btnCadProduto.Controls.Add(this.btnpExcluir);
            this.btnCadProduto.Controls.Add(this.btnpAlterar);
            this.btnCadProduto.Controls.Add(this.btnpInserir);
            this.btnCadProduto.Controls.Add(this.txtpEstoque);
            this.btnCadProduto.Controls.Add(this.lblpEstoque);
            this.btnCadProduto.Controls.Add(this.dtgpProduto);
            this.btnCadProduto.Controls.Add(this.lblpDataCadstro);
            this.btnCadProduto.Controls.Add(this.txtpMarca);
            this.btnCadProduto.Controls.Add(this.lblpMarca);
            this.btnCadProduto.Controls.Add(this.txtpFornecedor);
            this.btnCadProduto.Controls.Add(this.lblpFornecedor);
            this.btnCadProduto.Controls.Add(this.txtpPreco);
            this.btnCadProduto.Controls.Add(this.lblpPreco);
            this.btnCadProduto.Controls.Add(this.txtpNome);
            this.btnCadProduto.Controls.Add(this.lblpNome);
            this.btnCadProduto.Controls.Add(this.txtpCodigo);
            this.btnCadProduto.Controls.Add(this.lblpCodigo);
            this.btnCadProduto.Location = new System.Drawing.Point(4, 22);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Padding = new System.Windows.Forms.Padding(3);
            this.btnCadProduto.Size = new System.Drawing.Size(781, 522);
            this.btnCadProduto.TabIndex = 2;
            this.btnCadProduto.Text = "Produtos";
            // 
            // dtppDataCadastro
            // 
            this.dtppDataCadastro.Enabled = false;
            this.dtppDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtppDataCadastro.Location = new System.Drawing.Point(604, 29);
            this.dtppDataCadastro.Name = "dtppDataCadastro";
            this.dtppDataCadastro.Size = new System.Drawing.Size(100, 20);
            this.dtppDataCadastro.TabIndex = 6;
            // 
            // btnpRetornar
            // 
            this.btnpRetornar.BackColor = System.Drawing.SystemColors.Control;
            this.btnpRetornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpRetornar.ForeColor = System.Drawing.Color.Crimson;
            this.btnpRetornar.Location = new System.Drawing.Point(673, 456);
            this.btnpRetornar.Name = "btnpRetornar";
            this.btnpRetornar.Size = new System.Drawing.Size(75, 59);
            this.btnpRetornar.TabIndex = 13;
            this.btnpRetornar.Text = "Menu";
            this.btnpRetornar.UseVisualStyleBackColor = false;
            this.btnpRetornar.Click += new System.EventHandler(this.btnpRetornar_Click);
            // 
            // lblpBusca
            // 
            this.lblpBusca.AutoSize = true;
            this.lblpBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBusca.Location = new System.Drawing.Point(36, 490);
            this.lblpBusca.Name = "lblpBusca";
            this.lblpBusca.Size = new System.Drawing.Size(55, 16);
            this.lblpBusca.TabIndex = 57;
            this.lblpBusca.Text = "&Busca:";
            // 
            // txtpBusca
            // 
            this.txtpBusca.Location = new System.Drawing.Point(94, 489);
            this.txtpBusca.Name = "txtpBusca";
            this.txtpBusca.Size = new System.Drawing.Size(295, 20);
            this.txtpBusca.TabIndex = 12;
            this.txtpBusca.TextChanged += new System.EventHandler(this.txtpBusca_TextChanged);
            // 
            // btnpLimpaTela
            // 
            this.btnpLimpaTela.BackColor = System.Drawing.SystemColors.Control;
            this.btnpLimpaTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpLimpaTela.Location = new System.Drawing.Point(483, 447);
            this.btnpLimpaTela.Name = "btnpLimpaTela";
            this.btnpLimpaTela.Size = new System.Drawing.Size(78, 27);
            this.btnpLimpaTela.TabIndex = 11;
            this.btnpLimpaTela.Text = "Limpa Tela";
            this.btnpLimpaTela.UseVisualStyleBackColor = false;
            this.btnpLimpaTela.Click += new System.EventHandler(this.btnpLimpaTela_Click);
            // 
            // btnpExcluir
            // 
            this.btnpExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnpExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpExcluir.Location = new System.Drawing.Point(336, 447);
            this.btnpExcluir.Name = "btnpExcluir";
            this.btnpExcluir.Size = new System.Drawing.Size(78, 27);
            this.btnpExcluir.TabIndex = 10;
            this.btnpExcluir.Text = "Excluir";
            this.btnpExcluir.UseVisualStyleBackColor = false;
            this.btnpExcluir.Click += new System.EventHandler(this.btnpExcluir_Click);
            // 
            // btnpAlterar
            // 
            this.btnpAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnpAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpAlterar.Location = new System.Drawing.Point(186, 447);
            this.btnpAlterar.Name = "btnpAlterar";
            this.btnpAlterar.Size = new System.Drawing.Size(78, 27);
            this.btnpAlterar.TabIndex = 9;
            this.btnpAlterar.Text = "Alterar";
            this.btnpAlterar.UseVisualStyleBackColor = false;
            this.btnpAlterar.Click += new System.EventHandler(this.btnpAlterar_Click);
            // 
            // btnpInserir
            // 
            this.btnpInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btnpInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpInserir.Location = new System.Drawing.Point(39, 447);
            this.btnpInserir.Name = "btnpInserir";
            this.btnpInserir.Size = new System.Drawing.Size(78, 27);
            this.btnpInserir.TabIndex = 8;
            this.btnpInserir.Text = "Inserir";
            this.btnpInserir.UseVisualStyleBackColor = false;
            this.btnpInserir.Click += new System.EventHandler(this.btnpInserir_Click);
            // 
            // txtpEstoque
            // 
            this.txtpEstoque.Enabled = false;
            this.txtpEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpEstoque.Location = new System.Drawing.Point(126, 81);
            this.txtpEstoque.MaxLength = 1000;
            this.txtpEstoque.Name = "txtpEstoque";
            this.txtpEstoque.Size = new System.Drawing.Size(169, 20);
            this.txtpEstoque.TabIndex = 2;
            // 
            // lblpEstoque
            // 
            this.lblpEstoque.AutoSize = true;
            this.lblpEstoque.Enabled = false;
            this.lblpEstoque.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpEstoque.Location = new System.Drawing.Point(36, 81);
            this.lblpEstoque.Name = "lblpEstoque";
            this.lblpEstoque.Size = new System.Drawing.Size(61, 14);
            this.lblpEstoque.TabIndex = 56;
            this.lblpEstoque.Text = "Estoque:";
            // 
            // dtgpProduto
            // 
            this.dtgpProduto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgpProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgpProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgpProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgpProduto.Location = new System.Drawing.Point(39, 107);
            this.dtgpProduto.Name = "dtgpProduto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgpProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgpProduto.Size = new System.Drawing.Size(709, 311);
            this.dtgpProduto.TabIndex = 7;
            this.dtgpProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgpProduto_CellClick);
            // 
            // lblpDataCadstro
            // 
            this.lblpDataCadstro.AutoSize = true;
            this.lblpDataCadstro.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpDataCadstro.Location = new System.Drawing.Point(495, 32);
            this.lblpDataCadstro.Name = "lblpDataCadstro";
            this.lblpDataCadstro.Size = new System.Drawing.Size(103, 14);
            this.lblpDataCadstro.TabIndex = 49;
            this.lblpDataCadstro.Text = "Data Cadastro:";
            // 
            // txtpMarca
            // 
            this.txtpMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpMarca.Location = new System.Drawing.Point(126, 29);
            this.txtpMarca.MaxLength = 49;
            this.txtpMarca.Name = "txtpMarca";
            this.txtpMarca.Size = new System.Drawing.Size(208, 20);
            this.txtpMarca.TabIndex = 4;
            // 
            // lblpMarca
            // 
            this.lblpMarca.AutoSize = true;
            this.lblpMarca.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpMarca.Location = new System.Drawing.Point(36, 32);
            this.lblpMarca.Name = "lblpMarca";
            this.lblpMarca.Size = new System.Drawing.Size(51, 14);
            this.lblpMarca.TabIndex = 44;
            this.lblpMarca.Text = "Marca:";
            // 
            // txtpFornecedor
            // 
            this.txtpFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpFornecedor.Location = new System.Drawing.Point(126, 55);
            this.txtpFornecedor.MaxLength = 49;
            this.txtpFornecedor.Name = "txtpFornecedor";
            this.txtpFornecedor.Size = new System.Drawing.Size(578, 20);
            this.txtpFornecedor.TabIndex = 3;
            this.txtpFornecedor.Click += new System.EventHandler(this.txtpFornecedor_Click);
            // 
            // lblpFornecedor
            // 
            this.lblpFornecedor.AutoSize = true;
            this.lblpFornecedor.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpFornecedor.Location = new System.Drawing.Point(36, 55);
            this.lblpFornecedor.Name = "lblpFornecedor";
            this.lblpFornecedor.Size = new System.Drawing.Size(84, 14);
            this.lblpFornecedor.TabIndex = 43;
            this.lblpFornecedor.Text = "Fornecedor:";
            // 
            // txtpPreco
            // 
            this.txtpPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpPreco.Location = new System.Drawing.Point(393, 29);
            this.txtpPreco.MaxLength = 9;
            this.txtpPreco.Name = "txtpPreco";
            this.txtpPreco.Size = new System.Drawing.Size(88, 20);
            this.txtpPreco.TabIndex = 5;
            // 
            // lblpPreco
            // 
            this.lblpPreco.AutoSize = true;
            this.lblpPreco.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpPreco.Location = new System.Drawing.Point(341, 32);
            this.lblpPreco.Name = "lblpPreco";
            this.lblpPreco.Size = new System.Drawing.Size(46, 14);
            this.lblpPreco.TabIndex = 39;
            this.lblpPreco.Text = "Preço:";
            // 
            // txtpNome
            // 
            this.txtpNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpNome.Location = new System.Drawing.Point(276, 3);
            this.txtpNome.MaxLength = 29;
            this.txtpNome.Name = "txtpNome";
            this.txtpNome.Size = new System.Drawing.Size(428, 20);
            this.txtpNome.TabIndex = 1;
            // 
            // lblpNome
            // 
            this.lblpNome.AutoSize = true;
            this.lblpNome.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpNome.Location = new System.Drawing.Point(198, 3);
            this.lblpNome.Name = "lblpNome";
            this.lblpNome.Size = new System.Drawing.Size(72, 14);
            this.lblpNome.TabIndex = 37;
            this.lblpNome.Text = "Descrição:";
            // 
            // txtpCodigo
            // 
            this.txtpCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpCodigo.Location = new System.Drawing.Point(126, 3);
            this.txtpCodigo.Name = "txtpCodigo";
            this.txtpCodigo.Size = new System.Drawing.Size(68, 20);
            this.txtpCodigo.TabIndex = 35;
            // 
            // lblpCodigo
            // 
            this.lblpCodigo.AutoSize = true;
            this.lblpCodigo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpCodigo.Location = new System.Drawing.Point(36, 6);
            this.lblpCodigo.Name = "lblpCodigo";
            this.lblpCodigo.Size = new System.Drawing.Size(53, 14);
            this.lblpCodigo.TabIndex = 33;
            this.lblpCodigo.Text = "Código:";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.ControlBox = false;
            this.Controls.Add(this.tabCad);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.tabCad.ResumeLayout(false);
            this.btnCadCliente.ResumeLayout(false);
            this.btnCadCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.btnCadProduto.ResumeLayout(false);
            this.btnCadProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCad;
        private System.Windows.Forms.TabPage btnCadCliente;
        private System.Windows.Forms.TabPage btnCadProduto;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cbbEstadoCivil;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.ComboBox cbbUF;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpaTela;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.DateTimePicker dtppDataCadastro;
        private System.Windows.Forms.Button btnpRetornar;
        private System.Windows.Forms.Label lblpBusca;
        private System.Windows.Forms.TextBox txtpBusca;
        private System.Windows.Forms.Button btnpLimpaTela;
        private System.Windows.Forms.Button btnpExcluir;
        private System.Windows.Forms.Button btnpAlterar;
        private System.Windows.Forms.Button btnpInserir;
        private System.Windows.Forms.TextBox txtpEstoque;
        private System.Windows.Forms.Label lblpEstoque;
        private System.Windows.Forms.DataGridView dtgpProduto;
        private System.Windows.Forms.Label lblpDataCadstro;
        private System.Windows.Forms.TextBox txtpMarca;
        private System.Windows.Forms.Label lblpMarca;
        private System.Windows.Forms.TextBox txtpFornecedor;
        private System.Windows.Forms.Label lblpFornecedor;
        private System.Windows.Forms.TextBox txtpPreco;
        private System.Windows.Forms.Label lblpPreco;
        private System.Windows.Forms.TextBox txtpNome;
        private System.Windows.Forms.Label lblpNome;
        private System.Windows.Forms.TextBox txtpCodigo;
        private System.Windows.Forms.Label lblpCodigo;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbtipo;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtIE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}