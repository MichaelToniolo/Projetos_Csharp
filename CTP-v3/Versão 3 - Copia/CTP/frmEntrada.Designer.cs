namespace CTP
{
    partial class frmEntrada
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
            this.txtcodigopro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datacadastro = new System.Windows.Forms.DateTimePicker();
            this.txtestoque = new System.Windows.Forms.TextBox();
            this.lblestoque = new System.Windows.Forms.Label();
            this.lbldatacadastro = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpatela = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.Location = new System.Drawing.Point(316, 455);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(86, 38);
            this.btnfinalizar.TabIndex = 120;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // listaentrada
            // 
            this.listaentrada.BackColor = System.Drawing.Color.White;
            this.listaentrada.FullRowSelect = true;
            this.listaentrada.Location = new System.Drawing.Point(36, 216);
            this.listaentrada.Name = "listaentrada";
            this.listaentrada.Size = new System.Drawing.Size(708, 221);
            this.listaentrada.TabIndex = 119;
            this.listaentrada.UseCompatibleStateImageBehavior = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Crimson;
            this.btnPesquisar.Location = new System.Drawing.Point(288, 65);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(131, 26);
            this.btnPesquisar.TabIndex = 118;
            this.btnPesquisar.Text = "Pesquisar Produtos";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtcodigopro
            // 
            this.txtcodigopro.Enabled = false;
            this.txtcodigopro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigopro.Location = new System.Drawing.Point(149, 69);
            this.txtcodigopro.Name = "txtcodigopro";
            this.txtcodigopro.Size = new System.Drawing.Size(113, 20);
            this.txtcodigopro.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 14);
            this.label1.TabIndex = 117;
            this.label1.Text = "Código Produto:";
            // 
            // datacadastro
            // 
            this.datacadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datacadastro.Enabled = false;
            this.datacadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datacadastro.Location = new System.Drawing.Point(403, 162);
            this.datacadastro.Name = "datacadastro";
            this.datacadastro.Size = new System.Drawing.Size(108, 20);
            this.datacadastro.TabIndex = 116;
            // 
            // txtestoque
            // 
            this.txtestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestoque.Location = new System.Drawing.Point(124, 162);
            this.txtestoque.MaxLength = 1000000;
            this.txtestoque.Name = "txtestoque";
            this.txtestoque.Size = new System.Drawing.Size(138, 20);
            this.txtestoque.TabIndex = 106;
            // 
            // lblestoque
            // 
            this.lblestoque.AutoSize = true;
            this.lblestoque.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestoque.Location = new System.Drawing.Point(33, 165);
            this.lblestoque.Name = "lblestoque";
            this.lblestoque.Size = new System.Drawing.Size(88, 14);
            this.lblestoque.TabIndex = 115;
            this.lblestoque.Text = "Quantidade:";
            // 
            // lbldatacadastro
            // 
            this.lbldatacadastro.AutoSize = true;
            this.lbldatacadastro.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatacadastro.Location = new System.Drawing.Point(285, 165);
            this.lbldatacadastro.Name = "lbldatacadastro";
            this.lbldatacadastro.Size = new System.Drawing.Size(103, 14);
            this.lbldatacadastro.TabIndex = 114;
            this.lbldatacadastro.Text = "Data Cadastro:";
            // 
            // txtmarca
            // 
            this.txtmarca.Enabled = false;
            this.txtmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.Location = new System.Drawing.Point(457, 105);
            this.txtmarca.MaxLength = 49;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(194, 20);
            this.txtmarca.TabIndex = 105;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.Location = new System.Drawing.Point(400, 108);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(51, 14);
            this.lblmarca.TabIndex = 113;
            this.lblmarca.Text = "Marca:";
            // 
            // txtnome
            // 
            this.txtnome.Enabled = false;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(111, 108);
            this.txtnome.MaxLength = 29;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(268, 20);
            this.txtnome.TabIndex = 104;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(33, 108);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(72, 14);
            this.lblnome.TabIndex = 112;
            this.lblnome.Text = "Descrição:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(149, 26);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(113, 20);
            this.txtcodigo.TabIndex = 102;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(33, 26);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(110, 14);
            this.lblcodigo.TabIndex = 111;
            this.lblcodigo.Text = "Código Entrada:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.Control;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ForeColor = System.Drawing.Color.Crimson;
            this.btnvoltar.Location = new System.Drawing.Point(656, 455);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(88, 67);
            this.btnvoltar.TabIndex = 110;
            this.btnvoltar.Text = "Menu";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpatela
            // 
            this.btnlimpatela.BackColor = System.Drawing.SystemColors.Control;
            this.btnlimpatela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpatela.Location = new System.Drawing.Point(457, 455);
            this.btnlimpatela.Name = "btnlimpatela";
            this.btnlimpatela.Size = new System.Drawing.Size(78, 38);
            this.btnlimpatela.TabIndex = 109;
            this.btnlimpatela.Text = "Limpar Tela";
            this.btnlimpatela.UseVisualStyleBackColor = false;
            this.btnlimpatela.Click += new System.EventHandler(this.btnlimpatela_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(177, 455);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(85, 38);
            this.btnexcluir.TabIndex = 108;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btninserir
            // 
            this.btninserir.BackColor = System.Drawing.SystemColors.Control;
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Location = new System.Drawing.Point(40, 455);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(81, 38);
            this.btninserir.TabIndex = 107;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = false;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 534);
            this.ControlBox = false;
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.listaentrada);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtcodigopro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datacadastro);
            this.Controls.Add(this.txtestoque);
            this.Controls.Add(this.lblestoque);
            this.Controls.Add(this.lbldatacadastro);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpatela);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btninserir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Produtos";
            this.Load += new System.EventHandler(this.frmEntrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.ListView listaentrada;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtcodigopro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datacadastro;
        private System.Windows.Forms.TextBox txtestoque;
        private System.Windows.Forms.Label lblestoque;
        private System.Windows.Forms.Label lbldatacadastro;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpatela;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btninserir;
    }
}