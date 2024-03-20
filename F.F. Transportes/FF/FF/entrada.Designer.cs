namespace FF
{
    partial class entrada
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
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.listaentrada = new System.Windows.Forms.ListView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datacadastro = new System.Windows.Forms.DateTimePicker();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblestoque = new System.Windows.Forms.Label();
            this.lbldatacadastro = new System.Windows.Forms.Label();
            this.txtvolume = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtnf = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpatela = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtfornecedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.Location = new System.Drawing.Point(506, 394);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(78, 27);
            this.btnfinalizar.TabIndex = 139;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // listaentrada
            // 
            this.listaentrada.BackColor = System.Drawing.Color.Gainsboro;
            this.listaentrada.FullRowSelect = true;
            this.listaentrada.Location = new System.Drawing.Point(56, 153);
            this.listaentrada.Name = "listaentrada";
            this.listaentrada.Size = new System.Drawing.Size(708, 213);
            this.listaentrada.TabIndex = 138;
            this.listaentrada.UseCompatibleStateImageBehavior = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.LightGray;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Red;
            this.btnPesquisar.Location = new System.Drawing.Point(606, 40);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 26);
            this.btnPesquisar.TabIndex = 137;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 136;
            this.label1.Text = "Fornecedor:";
            // 
            // datacadastro
            // 
            this.datacadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datacadastro.Enabled = false;
            this.datacadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datacadastro.Location = new System.Drawing.Point(428, 124);
            this.datacadastro.Name = "datacadastro";
            this.datacadastro.Size = new System.Drawing.Size(108, 20);
            this.datacadastro.TabIndex = 135;
            // 
            // txtcidade
            // 
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidade.Location = new System.Drawing.Point(147, 127);
            this.txtcidade.MaxLength = 1000;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(138, 20);
            this.txtcidade.TabIndex = 125;
            // 
            // lblestoque
            // 
            this.lblestoque.AutoSize = true;
            this.lblestoque.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestoque.Location = new System.Drawing.Point(53, 130);
            this.lblestoque.Name = "lblestoque";
            this.lblestoque.Size = new System.Drawing.Size(55, 14);
            this.lblestoque.TabIndex = 134;
            this.lblestoque.Text = "Cidade:";
            // 
            // lbldatacadastro
            // 
            this.lbldatacadastro.AutoSize = true;
            this.lbldatacadastro.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatacadastro.Location = new System.Drawing.Point(319, 127);
            this.lbldatacadastro.Name = "lbldatacadastro";
            this.lbldatacadastro.Size = new System.Drawing.Size(103, 14);
            this.lbldatacadastro.TabIndex = 133;
            this.lbldatacadastro.Text = "Data Cadastro:";
            // 
            // txtvolume
            // 
            this.txtvolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvolume.Location = new System.Drawing.Point(390, 83);
            this.txtvolume.MaxLength = 20;
            this.txtvolume.Name = "txtvolume";
            this.txtvolume.Size = new System.Drawing.Size(194, 20);
            this.txtvolume.TabIndex = 124;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.Location = new System.Drawing.Point(322, 86);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(62, 14);
            this.lblmarca.TabIndex = 132;
            this.lblmarca.Text = "Volume:";
            // 
            // txtnf
            // 
            this.txtnf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnf.Location = new System.Drawing.Point(147, 83);
            this.txtnf.Name = "txtnf";
            this.txtnf.Size = new System.Drawing.Size(138, 20);
            this.txtnf.TabIndex = 123;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(53, 83);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(42, 14);
            this.lblnome.TabIndex = 131;
            this.lblnome.Text = "Nota:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(169, 13);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(62, 20);
            this.txtcodigo.TabIndex = 121;
            this.txtcodigo.Visible = false;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(53, 13);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(110, 14);
            this.lblcodigo.TabIndex = 130;
            this.lblcodigo.Text = "Código Entrada:";
            this.lblcodigo.Visible = false;
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.Control;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(686, 439);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(78, 27);
            this.btnvoltar.TabIndex = 129;
            this.btnvoltar.Text = "Menu";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpatela
            // 
            this.btnlimpatela.BackColor = System.Drawing.SystemColors.Control;
            this.btnlimpatela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpatela.Location = new System.Drawing.Point(686, 394);
            this.btnlimpatela.Name = "btnlimpatela";
            this.btnlimpatela.Size = new System.Drawing.Size(78, 27);
            this.btnlimpatela.TabIndex = 128;
            this.btnlimpatela.Text = "Limpa Tela";
            this.btnlimpatela.UseVisualStyleBackColor = false;
            this.btnlimpatela.Click += new System.EventHandler(this.btnlimpatela_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(285, 395);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(78, 27);
            this.btnexcluir.TabIndex = 127;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btninserir
            // 
            this.btninserir.BackColor = System.Drawing.SystemColors.Control;
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Location = new System.Drawing.Point(95, 394);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(78, 27);
            this.btninserir.TabIndex = 126;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = false;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(621, 121);
            this.txtvalor.MaxLength = 20;
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(82, 20);
            this.txtvalor.TabIndex = 140;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(542, 124);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(73, 14);
            this.lblvalor.TabIndex = 141;
            this.lblvalor.Text = "Valor Nfe:";
            // 
            // txtfornecedor
            // 
            this.txtfornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtfornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtfornecedor.FormattingEnabled = true;
            this.txtfornecedor.Items.AddRange(new object[] {
            "."});
            this.txtfornecedor.Location = new System.Drawing.Point(147, 40);
            this.txtfornecedor.Name = "txtfornecedor";
            this.txtfornecedor.Size = new System.Drawing.Size(437, 21);
            this.txtfornecedor.TabIndex = 142;
            // 
            // entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 479);
            this.ControlBox = false;
            this.Controls.Add(this.txtfornecedor);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.listaentrada);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datacadastro);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.lblestoque);
            this.Controls.Add(this.lbldatacadastro);
            this.Controls.Add(this.txtvolume);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.txtnf);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpatela);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btninserir);
            this.Name = "entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "entrada";
            this.Load += new System.EventHandler(this.entrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.ListView listaentrada;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datacadastro;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label lblestoque;
        private System.Windows.Forms.Label lbldatacadastro;
        private System.Windows.Forms.TextBox txtvolume;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txtnf;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpatela;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.ComboBox txtfornecedor;
    }
}