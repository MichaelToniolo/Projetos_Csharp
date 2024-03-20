namespace CTP
{
    partial class frmPesquisaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaProduto));
            this.btnretornar = new System.Windows.Forms.Button();
            this.lbldigitenome = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.dtgPesquisaProduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnretornar
            // 
            this.btnretornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretornar.Location = new System.Drawing.Point(391, 42);
            this.btnretornar.Name = "btnretornar";
            this.btnretornar.Size = new System.Drawing.Size(75, 23);
            this.btnretornar.TabIndex = 74;
            this.btnretornar.Text = "Retornar";
            this.btnretornar.UseVisualStyleBackColor = true;
            this.btnretornar.Click += new System.EventHandler(this.btnretornar_Click);
            // 
            // lbldigitenome
            // 
            this.lbldigitenome.AutoSize = true;
            this.lbldigitenome.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldigitenome.Location = new System.Drawing.Point(312, 47);
            this.lbldigitenome.Name = "lbldigitenome";
            this.lbldigitenome.Size = new System.Drawing.Size(44, 14);
            this.lbldigitenome.TabIndex = 73;
            this.lbldigitenome.Text = "Busca";
            // 
            // txtfiltro
            // 
            this.txtfiltro.BackColor = System.Drawing.Color.White;
            this.txtfiltro.Location = new System.Drawing.Point(11, 44);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(295, 20);
            this.txtfiltro.TabIndex = 72;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // dtgPesquisaProduto
            // 
            this.dtgPesquisaProduto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgPesquisaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPesquisaProduto.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPesquisaProduto.Location = new System.Drawing.Point(12, 84);
            this.dtgPesquisaProduto.Name = "dtgPesquisaProduto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPesquisaProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPesquisaProduto.Size = new System.Drawing.Size(802, 258);
            this.dtgPesquisaProduto.TabIndex = 71;
            this.dtgPesquisaProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPesquisaProduto_CellClick);
            // 
            // frmPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 384);
            this.Controls.Add(this.btnretornar);
            this.Controls.Add(this.lbldigitenome);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.dtgPesquisaProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisaProduto";
            this.Text = "Pesquisa Produto";
            this.Load += new System.EventHandler(this.frmPesquisaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnretornar;
        private System.Windows.Forms.Label lbldigitenome;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.DataGridView dtgPesquisaProduto;
    }
}