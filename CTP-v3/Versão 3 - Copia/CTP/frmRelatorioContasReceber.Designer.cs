namespace LEVINNI
{
    partial class frmRelatorioContasReceber
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
            this.dataVendas2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.datavendas = new System.Windows.Forms.DateTimePicker();
            this.lbldata = new System.Windows.Forms.Label();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxReceita = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVendas2
            // 
            this.dataVendas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVendas2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVendas2.Location = new System.Drawing.Point(65, 32);
            this.dataVendas2.Name = "dataVendas2";
            this.dataVendas2.Size = new System.Drawing.Size(110, 20);
            this.dataVendas2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Data";
            // 
            // cbbCliente
            // 
            this.cbbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(65, 58);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(232, 21);
            this.cbbCliente.TabIndex = 31;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 61);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "&Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // datavendas
            // 
            this.datavendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datavendas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datavendas.Location = new System.Drawing.Point(65, 3);
            this.datavendas.Name = "datavendas";
            this.datavendas.Size = new System.Drawing.Size(110, 20);
            this.datavendas.TabIndex = 28;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(12, 9);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(34, 13);
            this.lbldata.TabIndex = 27;
            this.lbldata.Text = "Data";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(341, 144);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExportarExcel.TabIndex = 39;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(194, 144);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 23);
            this.btnLimpar.TabIndex = 38;
            this.btnLimpar.Text = "Limpar Tela";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(12, 177);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(680, 203);
            this.dgvconsulta.TabIndex = 36;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(19, 144);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(142, 23);
            this.btnPesquisar.TabIndex = 35;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Total:";
            // 
            // TbxReceita
            // 
            this.TbxReceita.Location = new System.Drawing.Point(592, 151);
            this.TbxReceita.Name = "TbxReceita";
            this.TbxReceita.ReadOnly = true;
            this.TbxReceita.Size = new System.Drawing.Size(100, 20);
            this.TbxReceita.TabIndex = 40;
            // 
            // frmRelatorioContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxReceita);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvconsulta);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataVendas2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datavendas);
            this.Controls.Add(this.lbldata);
            this.Name = "frmRelatorioContasReceber";
            this.Text = "frmRelatorioContasReceber";
            this.Load += new System.EventHandler(this.frmRelatorioContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataVendas2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker datavendas;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxReceita;
    }
}