namespace CTP
{
    partial class frmContasaReceber
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFicha = new System.Windows.Forms.TextBox();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtgContasReceber = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpaTela = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbBaixado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbEspecie = new System.Windows.Forms.ComboBox();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContasReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ficha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Num. Parcela:";
            // 
            // txtFicha
            // 
            this.txtFicha.Location = new System.Drawing.Point(59, 6);
            this.txtFicha.Name = "txtFicha";
            this.txtFicha.Size = new System.Drawing.Size(100, 20);
            this.txtFicha.TabIndex = 1;
            // 
            // txtParcela
            // 
            this.txtParcela.Location = new System.Drawing.Point(234, 63);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(36, 20);
            this.txtParcela.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vencimento:";
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(464, 63);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(84, 20);
            this.dtpVencimento.TabIndex = 5;
            // 
            // dtgContasReceber
            // 
            this.dtgContasReceber.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContasReceber.Location = new System.Drawing.Point(9, 117);
            this.dtgContasReceber.Name = "dtgContasReceber";
            this.dtgContasReceber.Size = new System.Drawing.Size(659, 150);
            this.dtgContasReceber.TabIndex = 13;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Crimson;
            this.btnMenu.Location = new System.Drawing.Point(587, 294);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(77, 65);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "&Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(59, 339);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(411, 20);
            this.txtFiltro.TabIndex = 150;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(6, 342);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(44, 14);
            this.lblBusca.TabIndex = 151;
            this.lblBusca.Text = "Busca";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(91, 294);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 27);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpaTela
            // 
            this.btnLimpaTela.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpaTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaTela.Location = new System.Drawing.Point(476, 335);
            this.btnLimpaTela.Name = "btnLimpaTela";
            this.btnLimpaTela.Size = new System.Drawing.Size(84, 27);
            this.btnLimpaTela.TabIndex = 11;
            this.btnLimpaTela.Text = "Limpa Tela";
            this.btnLimpaTela.UseVisualStyleBackColor = false;
            this.btnLimpaTela.Click += new System.EventHandler(this.btnLimpaTela_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(9, 294);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(78, 27);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "&Cadastrar";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 152;
            this.label7.Text = "Data Cadastro:";
            // 
            // dtpCadastro
            // 
            this.dtpCadastro.Enabled = false;
            this.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadastro.Location = new System.Drawing.Point(256, 6);
            this.dtpCadastro.Name = "dtpCadastro";
            this.dtpCadastro.Size = new System.Drawing.Size(84, 20);
            this.dtpCadastro.TabIndex = 153;
            // 
            // cbbCliente
            // 
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(59, 32);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(262, 21);
            this.cbbCliente.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 155;
            this.label8.Text = "Baixado:";
            // 
            // cbbBaixado
            // 
            this.cbbBaixado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbBaixado.FormattingEnabled = true;
            this.cbbBaixado.ItemHeight = 13;
            this.cbbBaixado.Items.AddRange(new object[] {
            "N",
            "S"});
            this.cbbBaixado.Location = new System.Drawing.Point(205, 89);
            this.cbbBaixado.Name = "cbbBaixado";
            this.cbbBaixado.Size = new System.Drawing.Size(30, 21);
            this.cbbBaixado.TabIndex = 156;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 157;
            this.label2.Text = "Especie:";
            // 
            // cbbEspecie
            // 
            this.cbbEspecie.FormattingEnabled = true;
            this.cbbEspecie.ItemHeight = 13;
            this.cbbEspecie.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão"});
            this.cbbEspecie.Location = new System.Drawing.Point(59, 90);
            this.cbbEspecie.Name = "cbbEspecie";
            this.cbbEspecie.Size = new System.Drawing.Size(78, 21);
            this.cbbEspecie.TabIndex = 159;
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Location = new System.Drawing.Point(320, 61);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(40, 20);
            this.txtIntervalo.TabIndex = 160;
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Location = new System.Drawing.Point(283, 66);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(31, 13);
            this.lblIntervalo.TabIndex = 161;
            this.lblIntervalo.Text = "Dias:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(558, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 162;
            this.txtCodigo.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(320, 294);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 27);
            this.btnPesquisar.TabIndex = 163;
            this.btnPesquisar.Text = "&Pesquisar Duplicata";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(59, 66);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(78, 20);
            this.txtValor.TabIndex = 3;
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Location = new System.Drawing.Point(327, 32);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaCliente.TabIndex = 164;
            this.btnPesquisaCliente.Text = "Pesquisar";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(205, 294);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 27);
            this.btnExcluir.TabIndex = 165;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(439, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 27);
            this.button1.TabIndex = 166;
            this.button1.Text = "&Exportar Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmContasaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 377);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtIntervalo);
            this.Controls.Add(this.lblIntervalo);
            this.Controls.Add(this.cbbEspecie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbBaixado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbCliente);
            this.Controls.Add(this.dtpCadastro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLimpaTela);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dtgContasReceber);
            this.Controls.Add(this.dtpVencimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtFicha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmContasaReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Contas a Receber";
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.frmContasaReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContasReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFicha;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.DataGridView dtgContasReceber;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpaTela;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpCadastro;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbBaixado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbEspecie;
        private System.Windows.Forms.TextBox txtIntervalo;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button1;
    }
}