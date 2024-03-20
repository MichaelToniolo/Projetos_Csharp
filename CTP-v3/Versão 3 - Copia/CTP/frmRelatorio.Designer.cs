namespace CTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.datavendas = new System.Windows.Forms.DateTimePicker();
            this.lbldata = new System.Windows.Forms.Label();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataVendas2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.TbxReceita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(19, 161);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(142, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(12, 194);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(680, 203);
            this.dgvconsulta.TabIndex = 5;
            // 
            // datavendas
            // 
            this.datavendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datavendas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datavendas.Location = new System.Drawing.Point(61, 12);
            this.datavendas.Name = "datavendas";
            this.datavendas.Size = new System.Drawing.Size(110, 20);
            this.datavendas.TabIndex = 7;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(8, 18);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(34, 13);
            this.lbldata.TabIndex = 6;
            this.lbldata.Text = "Data";
            // 
            // cbbCliente
            // 
            this.cbbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(61, 67);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(232, 21);
            this.cbbCliente.TabIndex = 23;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(16, 70);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "&Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataVendas2
            // 
            this.dataVendas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVendas2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVendas2.Location = new System.Drawing.Point(61, 41);
            this.dataVendas2.Name = "dataVendas2";
            this.dataVendas2.Size = new System.Drawing.Size(110, 20);
            this.dataVendas2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Data";
            // 
            // cbbProduto
            // 
            this.cbbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbProduto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbProduto.FormattingEnabled = true;
            this.cbbProduto.Location = new System.Drawing.Point(61, 95);
            this.cbbProduto.Name = "cbbProduto";
            this.cbbProduto.Size = new System.Drawing.Size(232, 21);
            this.cbbProduto.TabIndex = 29;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(16, 98);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 28;
            this.lblProduto.Text = "Produto";
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(308, 93);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarProduto.TabIndex = 27;
            this.btnPesquisarProduto.Text = "&Buscar";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // TbxReceita
            // 
            this.TbxReceita.Location = new System.Drawing.Point(419, 164);
            this.TbxReceita.Name = "TbxReceita";
            this.TbxReceita.Size = new System.Drawing.Size(100, 20);
            this.TbxReceita.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Total:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(194, 161);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 23);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar Tela";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(308, 123);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExportarExcel.TabIndex = 34;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 409);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnLimpar);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.DateTimePicker datavendas;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dataVendas2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.TextBox TbxReceita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExportarExcel;
    }
}