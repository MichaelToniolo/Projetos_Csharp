namespace FF
{
    partial class frmpesquisafornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnretornar = new System.Windows.Forms.Button();
            this.lbldigitenome = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.dtgPesquisaFornecedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnretornar
            // 
            this.btnretornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretornar.Location = new System.Drawing.Point(430, 48);
            this.btnretornar.Name = "btnretornar";
            this.btnretornar.Size = new System.Drawing.Size(75, 23);
            this.btnretornar.TabIndex = 78;
            this.btnretornar.Text = "Retornar";
            this.btnretornar.UseVisualStyleBackColor = true;
            this.btnretornar.Click += new System.EventHandler(this.btnretornar_Click);
            // 
            // lbldigitenome
            // 
            this.lbldigitenome.AutoSize = true;
            this.lbldigitenome.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldigitenome.Location = new System.Drawing.Point(366, 54);
            this.lbldigitenome.Name = "lbldigitenome";
            this.lbldigitenome.Size = new System.Drawing.Size(44, 14);
            this.lbldigitenome.TabIndex = 77;
            this.lbldigitenome.Text = "Busca";
            // 
            // txtfiltro
            // 
            this.txtfiltro.BackColor = System.Drawing.Color.DarkGray;
            this.txtfiltro.Location = new System.Drawing.Point(65, 51);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(295, 20);
            this.txtfiltro.TabIndex = 76;
            // 
            // dtgPesquisaFornecedor
            // 
            this.dtgPesquisaFornecedor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgPesquisaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPesquisaFornecedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPesquisaFornecedor.Location = new System.Drawing.Point(74, 99);
            this.dtgPesquisaFornecedor.Name = "dtgPesquisaFornecedor";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPesquisaFornecedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgPesquisaFornecedor.Size = new System.Drawing.Size(746, 258);
            this.dtgPesquisaFornecedor.TabIndex = 75;
            this.dtgPesquisaFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPesquisaFornecedor_CellClick);
            // 
            // frmpesquisafornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 404);
            this.ControlBox = false;
            this.Controls.Add(this.btnretornar);
            this.Controls.Add(this.lbldigitenome);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.dtgPesquisaFornecedor);
            this.Name = "frmpesquisafornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmpesquisafornecedor";
            this.Load += new System.EventHandler(this.frmpesquisafornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnretornar;
        private System.Windows.Forms.Label lbldigitenome;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.DataGridView dtgPesquisaFornecedor;

    }
}