namespace FF
{
    partial class frmPendentes
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
            this.dtgPesquisaNfe = new System.Windows.Forms.DataGridView();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaNfe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPesquisaNfe
            // 
            this.dtgPesquisaNfe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgPesquisaNfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPesquisaNfe.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPesquisaNfe.Location = new System.Drawing.Point(12, 48);
            this.dtgPesquisaNfe.Name = "dtgPesquisaNfe";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPesquisaNfe.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPesquisaNfe.Size = new System.Drawing.Size(843, 258);
            this.dtgPesquisaNfe.TabIndex = 76;
            this.dtgPesquisaNfe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPesquisaNfe_CellClick);
            // 
            // txtfiltro
            // 
            this.txtfiltro.BackColor = System.Drawing.Color.DarkGray;
            this.txtfiltro.Location = new System.Drawing.Point(12, 12);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(295, 20);
            this.txtfiltro.TabIndex = 77;
            this.txtfiltro.Visible = false;
            // 
            // frmPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 319);
            this.ControlBox = false;
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.dtgPesquisaNfe);
            this.Name = "frmPendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPendentes";
            this.Load += new System.EventHandler(this.frmPendentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaNfe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPesquisaNfe;
        private System.Windows.Forms.TextBox txtfiltro;
    }
}