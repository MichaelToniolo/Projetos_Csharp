namespace CTP
{
    partial class frmOrcamento
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.cbbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.listavenda = new System.Windows.Forms.ListView();
            this.txtcancelar = new System.Windows.Forms.Button();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.txtquantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.lbldata = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParcela = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.lblCondicao = new System.Windows.Forms.Label();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.lblVendedorVenda = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbCondicao = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblDescontoValor = new System.Windows.Forms.Label();
            this.txtDescontoValor = new System.Windows.Forms.TextBox();
            this.txtDescontoPorcentagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtSubT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(3, 7);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 15);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // cbbCliente
            // 
            this.cbbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(99, 5);
            this.cbbCliente.MaxLength = 49;
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(175, 21);
            this.cbbCliente.TabIndex = 3;
            this.cbbCliente.SelectedIndexChanged += new System.EventHandler(this.cbbCliente_SelectedIndexChanged);
            // 
            // cbbProduto
            // 
            this.cbbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProduto.FormattingEnabled = true;
            this.cbbProduto.Location = new System.Drawing.Point(591, 28);
            this.cbbProduto.Name = "cbbProduto";
            this.cbbProduto.Size = new System.Drawing.Size(183, 37);
            this.cbbProduto.TabIndex = 6;
            this.cbbProduto.SelectedIndexChanged += new System.EventHandler(this.cbbProduto_SelectedIndexChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(447, 31);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(138, 29);
            this.lblProduto.TabIndex = 5;
            this.lblProduto.Text = "PRODUTO:";
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackgroundImage = global::LEVINNI.Properties.Resources.LUPA;
            this.btnPesquisarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(780, 25);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(40, 40);
            this.btnPesquisarProduto.TabIndex = 4;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // listavenda
            // 
            this.listavenda.BackColor = System.Drawing.Color.White;
            this.listavenda.FullRowSelect = true;
            this.listavenda.Location = new System.Drawing.Point(32, 203);
            this.listavenda.Name = "listavenda";
            this.listavenda.Size = new System.Drawing.Size(785, 125);
            this.listavenda.TabIndex = 24;
            this.listavenda.UseCompatibleStateImageBehavior = false;
            // 
            // txtcancelar
            // 
            this.txtcancelar.BackColor = System.Drawing.Color.DarkRed;
            this.txtcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcancelar.ForeColor = System.Drawing.Color.White;
            this.txtcancelar.Location = new System.Drawing.Point(477, 422);
            this.txtcancelar.Name = "txtcancelar";
            this.txtcancelar.Size = new System.Drawing.Size(310, 52);
            this.txtcancelar.TabIndex = 28;
            this.txtcancelar.Text = "CANCELAR";
            this.txtcancelar.UseVisualStyleBackColor = false;
            this.txtcancelar.Click += new System.EventHandler(this.txtcancelar_Click);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.ForeColor = System.Drawing.Color.White;
            this.btnfinalizar.Location = new System.Drawing.Point(477, 474);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(310, 55);
            this.btnfinalizar.TabIndex = 27;
            this.btnfinalizar.Text = "FINALIZAR VENDA";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.Color.DarkRed;
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.ForeColor = System.Drawing.Color.White;
            this.btnremover.Location = new System.Drawing.Point(728, 157);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(92, 40);
            this.btnremover.TabIndex = 26;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.Color.Green;
            this.btnadicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionar.ForeColor = System.Drawing.Color.White;
            this.btnadicionar.Location = new System.Drawing.Point(611, 157);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(89, 40);
            this.btnadicionar.TabIndex = 25;
            this.btnadicionar.Text = "Inserir";
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // txtquantidade
            // 
            this.txtquantidade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtquantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidade.Location = new System.Drawing.Point(591, 75);
            this.txtquantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(229, 30);
            this.txtquantidade.TabIndex = 29;
            this.txtquantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantidade.ThousandsSeparator = true;
            this.txtquantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "QUANTIDADE:";
            // 
            // dtpdata
            // 
            this.dtpdata.Enabled = false;
            this.dtpdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdata.Location = new System.Drawing.Point(546, 3);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(100, 20);
            this.dtpdata.TabIndex = 31;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.BackColor = System.Drawing.Color.Transparent;
            this.lbldata.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.Color.Black;
            this.lbldata.Location = new System.Drawing.Point(504, 5);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(36, 15);
            this.lbldata.TabIndex = 32;
            this.lbldata.Text = "Data:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(363, 3);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 33;
            this.txtcodigo.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Crimson;
            this.btnMenu.Location = new System.Drawing.Point(477, 535);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(310, 34);
            this.btnMenu.TabIndex = 34;
            this.btnMenu.Text = "&Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNomeArquivo.Location = new System.Drawing.Point(46, 6);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(103, 15);
            this.lblNomeArquivo.TabIndex = 35;
            this.lblNomeArquivo.Text = "Nome do Arquivo";
            this.lblNomeArquivo.Visible = false;
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(152, 5);
            this.txtNomeArquivo.MaxLength = 49;
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(189, 20);
            this.txtNomeArquivo.TabIndex = 39;
            this.txtNomeArquivo.Visible = false;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCredito.Location = new System.Drawing.Point(492, 390);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(86, 15);
            this.lblCredito.TabIndex = 40;
            this.lblCredito.Text = "LIM. CRÉDITO:";
            this.lblCredito.Visible = false;
            // 
            // txtCredito
            // 
            this.txtCredito.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCredito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCredito.Enabled = false;
            this.txtCredito.Location = new System.Drawing.Point(591, 392);
            this.txtCredito.MaxLength = 9;
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(175, 13);
            this.txtCredito.TabIndex = 41;
            this.txtCredito.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(70, 539);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(253, 35);
            this.txtTotal.TabIndex = 42;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(67, 520);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(155, 19);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "TOTAL DO PEDIDO";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(591, 116);
            this.txtPreco.MaxLength = 49;
            this.txtPreco.Multiline = true;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(229, 29);
            this.txtPreco.TabIndex = 45;
            this.txtPreco.Text = "0,00";
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(481, 116);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(104, 29);
            this.lblPreco.TabIndex = 44;
            this.lblPreco.Text = "PREÇO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "PARCELAS:";
            // 
            // txtParcela
            // 
            this.txtParcela.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtParcela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParcela.Location = new System.Drawing.Point(99, 91);
            this.txtParcela.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(175, 16);
            this.txtParcela.TabIndex = 46;
            this.txtParcela.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.txtIntervalo);
            this.panel1.Controls.Add(this.lblIntervalo);
            this.panel1.Controls.Add(this.lblCondicao);
            this.panel1.Controls.Add(this.dtpVencimento);
            this.panel1.Controls.Add(this.lblVendedorVenda);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbbCondicao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbCliente);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblVendedor);
            this.panel1.Controls.Add(this.txtParcela);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(32, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 166);
            this.panel1.TabIndex = 48;
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Location = new System.Drawing.Point(234, 113);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(40, 20);
            this.txtIntervalo.TabIndex = 164;
            this.txtIntervalo.Text = "0";
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalo.Location = new System.Drawing.Point(193, 115);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(35, 15);
            this.lblIntervalo.TabIndex = 165;
            this.lblIntervalo.Text = "Dias:";
            // 
            // lblCondicao
            // 
            this.lblCondicao.AutoSize = true;
            this.lblCondicao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCondicao.Location = new System.Drawing.Point(2, 70);
            this.lblCondicao.Name = "lblCondicao";
            this.lblCondicao.Size = new System.Drawing.Size(81, 15);
            this.lblCondicao.TabIndex = 50;
            this.lblCondicao.Text = "COND. PGTO:";
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(99, 113);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(84, 20);
            this.dtpVencimento.TabIndex = 162;
            // 
            // lblVendedorVenda
            // 
            this.lblVendedorVenda.AutoSize = true;
            this.lblVendedorVenda.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorVenda.Location = new System.Drawing.Point(105, 34);
            this.lblVendedorVenda.Name = "lblVendedorVenda";
            this.lblVendedorVenda.Size = new System.Drawing.Size(0, 27);
            this.lblVendedorVenda.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 163;
            this.label8.Text = "1º Vencimento:";
            // 
            // cbbCondicao
            // 
            this.cbbCondicao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCondicao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCondicao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCondicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCondicao.FormattingEnabled = true;
            this.cbbCondicao.Items.AddRange(new object[] {
            "Á VISTA",
            "CARTÃO DE DÉBITO",
            "CARTÃO DE CRÉDITO",
            "CHEQUE"});
            this.cbbCondicao.Location = new System.Drawing.Point(99, 64);
            this.cbbCondicao.Name = "cbbCondicao";
            this.cbbCondicao.Size = new System.Drawing.Size(175, 21);
            this.cbbCondicao.TabIndex = 49;
            this.cbbCondicao.SelectedIndexChanged += new System.EventHandler(this.cbbCondicao_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LEVINNI.Properties.Resources.LUPA;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(280, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 21);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendedor.Location = new System.Drawing.Point(3, 43);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(73, 15);
            this.lblVendedor.TabIndex = 6;
            this.lblVendedor.Text = "VENDEDOR:";
            // 
            // lblDescontoValor
            // 
            this.lblDescontoValor.AutoSize = true;
            this.lblDescontoValor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoValor.Location = new System.Drawing.Point(185, 337);
            this.lblDescontoValor.Name = "lblDescontoValor";
            this.lblDescontoValor.Size = new System.Drawing.Size(147, 29);
            this.lblDescontoValor.TabIndex = 50;
            this.lblDescontoValor.Text = "DESCONTO";
            // 
            // txtDescontoValor
            // 
            this.txtDescontoValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescontoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoValor.Location = new System.Drawing.Point(228, 370);
            this.txtDescontoValor.Name = "txtDescontoValor";
            this.txtDescontoValor.Size = new System.Drawing.Size(95, 44);
            this.txtDescontoValor.TabIndex = 49;
            this.txtDescontoValor.Text = "0,00";
            this.txtDescontoValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescontoPorcentagem
            // 
            this.txtDescontoPorcentagem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescontoPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoPorcentagem.Location = new System.Drawing.Point(228, 420);
            this.txtDescontoPorcentagem.Name = "txtDescontoPorcentagem";
            this.txtDescontoPorcentagem.Size = new System.Drawing.Size(95, 44);
            this.txtDescontoPorcentagem.TabIndex = 51;
            this.txtDescontoPorcentagem.Text = "0";
            this.txtDescontoPorcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 29);
            this.label3.TabIndex = 52;
            this.label3.Text = "R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 29);
            this.label4.TabIndex = 53;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 56;
            this.label5.Text = "R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 55;
            this.label6.Text = "ENTRADA";
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(70, 370);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(95, 44);
            this.txtEntrada.TabIndex = 54;
            this.txtEntrada.Text = "0,00";
            this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 57;
            this.label7.Text = "R$";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(16, 488);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(155, 29);
            this.lblSubTotal.TabIndex = 59;
            this.lblSubTotal.Text = "SUB TOTAL:";
            // 
            // txtSubT
            // 
            this.txtSubT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSubT.Enabled = false;
            this.txtSubT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubT.Location = new System.Drawing.Point(174, 484);
            this.txtSubT.Name = "txtSubT";
            this.txtSubT.ReadOnly = true;
            this.txtSubT.Size = new System.Drawing.Size(149, 29);
            this.txtSubT.TabIndex = 60;
            this.txtSubT.Text = "0,00";
            this.txtSubT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(848, 586);
            this.ControlBox = false;
            this.Controls.Add(this.txtSubT);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescontoPorcentagem);
            this.Controls.Add(this.lblDescontoValor);
            this.Controls.Add(this.txtDescontoValor);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.txtcancelar);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.listavenda);
            this.Controls.Add(this.cbbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnPesquisarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAIXA";
            this.Load += new System.EventHandler(this.frmOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtquantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.ComboBox cbbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.ListView listavenda;
        private System.Windows.Forms.Button txtcancelar;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.NumericUpDown txtquantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtParcela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVendedorVenda;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cbbCondicao;
        private System.Windows.Forms.Label lblCondicao;
        private System.Windows.Forms.Label lblDescontoValor;
        private System.Windows.Forms.TextBox txtDescontoValor;
        private System.Windows.Forms.TextBox txtDescontoPorcentagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIntervalo;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtSubT;
    }
}