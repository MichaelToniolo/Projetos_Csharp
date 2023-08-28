namespace Locadora
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tsbUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbFilme = new System.Windows.Forms.ToolStripButton();
            this.tsbLocacao = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.lblhorario = new System.Windows.Forms.Label();
            this.tmRelogio = new System.Windows.Forms.Timer(this.components);
            this.tspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tspMenu
            // 
            this.tspMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsuario,
            this.tsbFilme,
            this.tsbLocacao,
            this.tsbSair});
            this.tspMenu.Location = new System.Drawing.Point(0, 0);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Size = new System.Drawing.Size(637, 47);
            this.tspMenu.TabIndex = 1;
            this.tspMenu.Text = "toolStrip1";
            // 
            // tsbUsuario
            // 
            this.tsbUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUsuario.Image = global::Locadora.Properties.Resources.personal;
            this.tsbUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuario.Name = "tsbUsuario";
            this.tsbUsuario.Size = new System.Drawing.Size(44, 44);
            this.tsbUsuario.Text = "Cadastro de Usuários";
            this.tsbUsuario.Click += new System.EventHandler(this.tsbUsuario_Click);
            // 
            // tsbFilme
            // 
            this.tsbFilme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFilme.Image = global::Locadora.Properties.Resources.ranking;
            this.tsbFilme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFilme.Name = "tsbFilme";
            this.tsbFilme.Size = new System.Drawing.Size(44, 44);
            this.tsbFilme.Text = "Cadastro de Filmes";
            this.tsbFilme.Click += new System.EventHandler(this.tsbFilme_Click);
            // 
            // tsbLocacao
            // 
            this.tsbLocacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLocacao.Image = global::Locadora.Properties.Resources.highlight;
            this.tsbLocacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLocacao.Name = "tsbLocacao";
            this.tsbLocacao.Size = new System.Drawing.Size(44, 44);
            this.tsbLocacao.Text = "Cadastro de Locação";
            // 
            // tsbSair
            // 
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = global::Locadora.Properties.Resources.close;
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(44, 44);
            this.tsbSair.Text = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // pcbImage
            // 
            this.pcbImage.BackgroundImage = global::Locadora.Properties.Resources.sonic_correndo_a5f4e53fb05515027a6f3b0cdc197983_games__60_;
            this.pcbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbImage.Location = new System.Drawing.Point(0, 0);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(637, 437);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.BackColor = System.Drawing.Color.White;
            this.lblRelogio.Location = new System.Drawing.Point(22, 64);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(0, 13);
            this.lblRelogio.TabIndex = 2;
            // 
            // lblhorario
            // 
            this.lblhorario.AutoSize = true;
            this.lblhorario.BackColor = System.Drawing.Color.White;
            this.lblhorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorario.Location = new System.Drawing.Point(35, 65);
            this.lblhorario.Name = "lblhorario";
            this.lblhorario.Size = new System.Drawing.Size(0, 31);
            this.lblhorario.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(637, 437);
            this.ControlBox = false;
            this.Controls.Add(this.lblhorario);
            this.Controls.Add(this.lblRelogio);
            this.Controls.Add(this.tspMenu);
            this.Controls.Add(this.pcbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Locadora";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripButton tsbUsuario;
        private System.Windows.Forms.ToolStripButton tsbFilme;
        private System.Windows.Forms.ToolStripButton tsbLocacao;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Label lblhorario;
        private System.Windows.Forms.Timer tmRelogio;
    }
}