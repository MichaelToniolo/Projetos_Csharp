namespace FF
{
    partial class frmRelatorio
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
            this.label2 = new System.Windows.Forms.Label();
            this.TbxReceita = new System.Windows.Forms.TextBox();
            this.cbbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.dataVendas2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.datavendas = new System.Windows.Forms.DateTimePicker();
            this.lbldata = new System.Windows.Forms.Label();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Total:";
            // 
            // TbxReceita
            // 
            this.TbxReceita.Location = new System.Drawing.Point(569, 325);
            this.TbxReceita.Name = "TbxReceita";
            this.TbxReceita.Size = new System.Drawing.Size(100, 20);
            this.TbxReceita.TabIndex = 45;
            // 
            // cbbProduto
            // 
            this.cbbProduto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbProduto.FormattingEnabled = true;
            this.cbbProduto.Location = new System.Drawing.Point(75, 36);
            this.cbbProduto.Name = "cbbProduto";
            this.cbbProduto.Size = new System.Drawing.Size(166, 21);
            this.cbbProduto.TabIndex = 44;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(8, 40);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(61, 13);
            this.lblProduto.TabIndex = 43;
            this.lblProduto.Text = "Fornecedor";
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(257, 36);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarProduto.TabIndex = 42;
            this.btnPesquisarProduto.Text = "&Buscar";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // dataVendas2
            // 
            this.dataVendas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVendas2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVendas2.Location = new System.Drawing.Point(399, 39);
            this.dataVendas2.Name = "dataVendas2";
            this.dataVendas2.Size = new System.Drawing.Size(110, 20);
            this.dataVendas2.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Data";
            // 
            // cbbCliente
            // 
            this.cbbCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(75, 9);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(166, 21);
            this.cbbCliente.TabIndex = 39;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(19, 12);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(50, 13);
            this.lblCliente.TabIndex = 38;
            this.lblCliente.Text = "Motorista";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "&Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // datavendas
            // 
            this.datavendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datavendas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datavendas.Location = new System.Drawing.Point(399, 10);
            this.datavendas.Name = "datavendas";
            this.datavendas.Size = new System.Drawing.Size(110, 20);
            this.datavendas.TabIndex = 36;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(348, 14);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(34, 13);
            this.lbldata.TabIndex = 35;
            this.lbldata.Text = "Data";
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(12, 116);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(1038, 203);
            this.dgvconsulta.TabIndex = 34;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(367, 65);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(142, 23);
            this.btnPesquisar.TabIndex = 33;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(536, 65);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(90, 23);
            this.btnExportarExcel.TabIndex = 47;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(797, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            //this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(568, 7);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(100, 20);
            this.txtNomeArquivo.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(762, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            //this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 384);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxReceita);
            this.Controls.Add(this.cbbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.dataVendas2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datavendas);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.dgvconsulta);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorio";
            //this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxReceita;
        private System.Windows.Forms.ComboBox cbbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.DateTimePicker dataVendas2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker datavendas;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Button button3;

    }
}