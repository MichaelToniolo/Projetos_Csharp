namespace FF
{
    partial class baixa
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
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.listaentrada = new System.Windows.Forms.ListView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtfornecedor = new System.Windows.Forms.TextBox();
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
            this.txtrecebedor = new System.Windows.Forms.TextBox();
            this.lblrecebedor = new System.Windows.Forms.Label();
            this.txtmotorista = new System.Windows.Forms.TextBox();
            this.lblmotorista = new System.Windows.Forms.Label();
            this.txtcaminhao = new System.Windows.Forms.TextBox();
            this.lblcaminhao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(173, 93);
            this.txtvalor.MaxLength = 20;
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(82, 20);
            this.txtvalor.TabIndex = 161;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(94, 96);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(73, 14);
            this.lblvalor.TabIndex = 162;
            this.lblvalor.Text = "Valor Nfe:";
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.Location = new System.Drawing.Point(535, 325);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(78, 27);
            this.btnfinalizar.TabIndex = 160;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // listaentrada
            // 
            this.listaentrada.BackColor = System.Drawing.Color.Gainsboro;
            this.listaentrada.FullRowSelect = true;
            this.listaentrada.Location = new System.Drawing.Point(82, 180);
            this.listaentrada.Name = "listaentrada";
            this.listaentrada.Size = new System.Drawing.Size(708, 130);
            this.listaentrada.TabIndex = 159;
            this.listaentrada.UseCompatibleStateImageBehavior = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.LightGray;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Red;
            this.btnPesquisar.Location = new System.Drawing.Point(326, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 26);
            this.btnPesquisar.TabIndex = 158;
            this.btnPesquisar.Text = "Expedição";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtfornecedor
            // 
            this.txtfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfornecedor.Location = new System.Drawing.Point(173, 41);
            this.txtfornecedor.Name = "txtfornecedor";
            this.txtfornecedor.Size = new System.Drawing.Size(138, 20);
            this.txtfornecedor.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 157;
            this.label1.Text = "Fornecedor:";
            // 
            // datacadastro
            // 
            this.datacadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datacadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datacadastro.Location = new System.Drawing.Point(748, 17);
            this.datacadastro.Name = "datacadastro";
            this.datacadastro.Size = new System.Drawing.Size(108, 20);
            this.datacadastro.TabIndex = 156;
            // 
            // txtcidade
            // 
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidade.Location = new System.Drawing.Point(173, 67);
            this.txtcidade.MaxLength = 1000;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(138, 20);
            this.txtcidade.TabIndex = 146;
            // 
            // lblestoque
            // 
            this.lblestoque.AutoSize = true;
            this.lblestoque.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestoque.Location = new System.Drawing.Point(79, 70);
            this.lblestoque.Name = "lblestoque";
            this.lblestoque.Size = new System.Drawing.Size(55, 14);
            this.lblestoque.TabIndex = 155;
            this.lblestoque.Text = "Cidade:";
            // 
            // lbldatacadastro
            // 
            this.lbldatacadastro.AutoSize = true;
            this.lbldatacadastro.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatacadastro.Location = new System.Drawing.Point(639, 20);
            this.lbldatacadastro.Name = "lbldatacadastro";
            this.lbldatacadastro.Size = new System.Drawing.Size(103, 14);
            this.lbldatacadastro.TabIndex = 154;
            this.lbldatacadastro.Text = "Data Cadastro:";
            // 
            // txtvolume
            // 
            this.txtvolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvolume.Location = new System.Drawing.Point(340, 90);
            this.txtvolume.MaxLength = 20;
            this.txtvolume.Name = "txtvolume";
            this.txtvolume.Size = new System.Drawing.Size(118, 20);
            this.txtvolume.TabIndex = 145;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.Location = new System.Drawing.Point(272, 93);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(62, 14);
            this.lblmarca.TabIndex = 153;
            this.lblmarca.Text = "Volume:";
            // 
            // txtnf
            // 
            this.txtnf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnf.Location = new System.Drawing.Point(173, 15);
            this.txtnf.Name = "txtnf";
            this.txtnf.Size = new System.Drawing.Size(138, 20);
            this.txtnf.TabIndex = 144;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(79, 15);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(42, 14);
            this.lblnome.TabIndex = 152;
            this.lblnome.Text = "Nota:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(195, -33);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(62, 20);
            this.txtcodigo.TabIndex = 142;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(79, -33);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(110, 14);
            this.lblcodigo.TabIndex = 151;
            this.lblcodigo.Text = "Código Entrada:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.Control;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(715, 370);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(78, 27);
            this.btnvoltar.TabIndex = 150;
            this.btnvoltar.Text = "Menu";
            this.btnvoltar.UseVisualStyleBackColor = false;
            // 
            // btnlimpatela
            // 
            this.btnlimpatela.BackColor = System.Drawing.SystemColors.Control;
            this.btnlimpatela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpatela.Location = new System.Drawing.Point(715, 325);
            this.btnlimpatela.Name = "btnlimpatela";
            this.btnlimpatela.Size = new System.Drawing.Size(78, 27);
            this.btnlimpatela.TabIndex = 149;
            this.btnlimpatela.Text = "Limpa Tela";
            this.btnlimpatela.UseVisualStyleBackColor = false;
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(314, 326);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(78, 27);
            this.btnexcluir.TabIndex = 148;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btninserir
            // 
            this.btninserir.BackColor = System.Drawing.SystemColors.Control;
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Location = new System.Drawing.Point(124, 325);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(78, 27);
            this.btninserir.TabIndex = 147;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = false;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // txtrecebedor
            // 
            this.txtrecebedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecebedor.Location = new System.Drawing.Point(173, 122);
            this.txtrecebedor.MaxLength = 1000;
            this.txtrecebedor.Name = "txtrecebedor";
            this.txtrecebedor.Size = new System.Drawing.Size(138, 20);
            this.txtrecebedor.TabIndex = 163;
            // 
            // lblrecebedor
            // 
            this.lblrecebedor.AutoSize = true;
            this.lblrecebedor.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecebedor.Location = new System.Drawing.Point(79, 125);
            this.lblrecebedor.Name = "lblrecebedor";
            this.lblrecebedor.Size = new System.Drawing.Size(77, 14);
            this.lblrecebedor.TabIndex = 164;
            this.lblrecebedor.Text = "Recebedor:";
            // 
            // txtmotorista
            // 
            this.txtmotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmotorista.Location = new System.Drawing.Point(433, 148);
            this.txtmotorista.MaxLength = 1000;
            this.txtmotorista.Name = "txtmotorista";
            this.txtmotorista.Size = new System.Drawing.Size(138, 20);
            this.txtmotorista.TabIndex = 165;
            // 
            // lblmotorista
            // 
            this.lblmotorista.AutoSize = true;
            this.lblmotorista.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmotorista.Location = new System.Drawing.Point(339, 151);
            this.lblmotorista.Name = "lblmotorista";
            this.lblmotorista.Size = new System.Drawing.Size(74, 14);
            this.lblmotorista.TabIndex = 166;
            this.lblmotorista.Text = "Motorista:";
            // 
            // txtcaminhao
            // 
            this.txtcaminhao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaminhao.Location = new System.Drawing.Point(173, 151);
            this.txtcaminhao.MaxLength = 1000;
            this.txtcaminhao.Name = "txtcaminhao";
            this.txtcaminhao.Size = new System.Drawing.Size(138, 20);
            this.txtcaminhao.TabIndex = 167;
            // 
            // lblcaminhao
            // 
            this.lblcaminhao.AutoSize = true;
            this.lblcaminhao.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaminhao.Location = new System.Drawing.Point(79, 154);
            this.lblcaminhao.Name = "lblcaminhao";
            this.lblcaminhao.Size = new System.Drawing.Size(78, 14);
            this.lblcaminhao.TabIndex = 168;
            this.lblcaminhao.Text = "Caminhão:";
            // 
            // baixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 404);
            this.ControlBox = false;
            this.Controls.Add(this.txtcaminhao);
            this.Controls.Add(this.lblcaminhao);
            this.Controls.Add(this.txtmotorista);
            this.Controls.Add(this.lblmotorista);
            this.Controls.Add(this.txtrecebedor);
            this.Controls.Add(this.lblrecebedor);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.listaentrada);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtfornecedor);
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
            this.Name = "baixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "baixa";
            this.Load += new System.EventHandler(this.baixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.ListView listaentrada;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtfornecedor;
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
        private System.Windows.Forms.TextBox txtrecebedor;
        private System.Windows.Forms.Label lblrecebedor;
        private System.Windows.Forms.TextBox txtmotorista;
        private System.Windows.Forms.Label lblmotorista;
        private System.Windows.Forms.TextBox txtcaminhao;
        private System.Windows.Forms.Label lblcaminhao;
    }
}