namespace CTP
{
    partial class PesquisaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaCliente));
            this.btnretornar = new System.Windows.Forms.Button();
            this.lbldigitenome = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.dtgPesquisaCliente = new System.Windows.Forms.DataGridView();
            this.txtFiltroNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtFiltroCidade = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnretornar
            // 
            this.btnretornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretornar.Location = new System.Drawing.Point(12, 84);
            this.btnretornar.Name = "btnretornar";
            this.btnretornar.Size = new System.Drawing.Size(75, 23);
            this.btnretornar.TabIndex = 70;
            this.btnretornar.Text = "Retornar";
            this.btnretornar.UseVisualStyleBackColor = true;
            this.btnretornar.Click += new System.EventHandler(this.btnretornar_Click);
            // 
            // lbldigitenome
            // 
            this.lbldigitenome.AutoSize = true;
            this.lbldigitenome.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldigitenome.Location = new System.Drawing.Point(12, 9);
            this.lbldigitenome.Name = "lbldigitenome";
            this.lbldigitenome.Size = new System.Drawing.Size(53, 14);
            this.lbldigitenome.TabIndex = 69;
            this.lbldigitenome.Text = "Código:";
            // 
            // txtfiltro
            // 
            this.txtfiltro.BackColor = System.Drawing.Color.White;
            this.txtfiltro.Location = new System.Drawing.Point(71, 6);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(295, 20);
            this.txtfiltro.TabIndex = 68;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // dtgPesquisaCliente
            // 
            this.dtgPesquisaCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgPesquisaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPesquisaCliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPesquisaCliente.Location = new System.Drawing.Point(12, 113);
            this.dtgPesquisaCliente.Name = "dtgPesquisaCliente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPesquisaCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPesquisaCliente.Size = new System.Drawing.Size(680, 436);
            this.dtgPesquisaCliente.TabIndex = 67;
            this.dtgPesquisaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPesquisaCliente_CellClick);
            // 
            // txtFiltroNome
            // 
            this.txtFiltroNome.BackColor = System.Drawing.Color.White;
            this.txtFiltroNome.Location = new System.Drawing.Point(71, 32);
            this.txtFiltroNome.Name = "txtFiltroNome";
            this.txtFiltroNome.Size = new System.Drawing.Size(295, 20);
            this.txtFiltroNome.TabIndex = 71;
            this.txtFiltroNome.TextChanged += new System.EventHandler(this.txtFiltroNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(17, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 14);
            this.lblNome.TabIndex = 72;
            this.lblNome.Text = "Nome:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(372, 9);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(55, 14);
            this.lblCidade.TabIndex = 74;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtFiltroCidade
            // 
            this.txtFiltroCidade.BackColor = System.Drawing.Color.White;
            this.txtFiltroCidade.Location = new System.Drawing.Point(433, 6);
            this.txtFiltroCidade.Name = "txtFiltroCidade";
            this.txtFiltroCidade.Size = new System.Drawing.Size(259, 20);
            this.txtFiltroCidade.TabIndex = 73;
            this.txtFiltroCidade.TextChanged += new System.EventHandler(this.txtFiltroCidade_TextChanged);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(392, 35);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(35, 14);
            this.lblCPF.TabIndex = 76;
            this.lblCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.White;
            this.txtCPF.Location = new System.Drawing.Point(433, 32);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(259, 20);
            this.txtCPF.TabIndex = 75;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // PesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtFiltroCidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtFiltroNome);
            this.Controls.Add(this.btnretornar);
            this.Controls.Add(this.lbldigitenome);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.dtgPesquisaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.PesquisaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnretornar;
        private System.Windows.Forms.Label lbldigitenome;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.DataGridView dtgPesquisaCliente;
        private System.Windows.Forms.TextBox txtFiltroNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtFiltroCidade;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
    }
}