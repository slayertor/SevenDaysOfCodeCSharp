namespace PetAsService
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.MenuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.BuscarAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FavoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextoInicialLabel = new System.Windows.Forms.Label();
            this.TrocarPetUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripPrincipal
            // 
            this.MenuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuscarAnimalToolStripMenuItem,
            this.FavoritosToolStripMenuItem,
            this.TrocarPetUsuarioToolStripMenuItem});
            this.MenuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuStripPrincipal.Name = "MenuStripPrincipal";
            this.MenuStripPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStripPrincipal.Size = new System.Drawing.Size(933, 25);
            this.MenuStripPrincipal.TabIndex = 0;
            this.MenuStripPrincipal.Text = "menuStrip1";
            // 
            // BuscarAnimalToolStripMenuItem
            // 
            this.BuscarAnimalToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarAnimalToolStripMenuItem.Name = "BuscarAnimalToolStripMenuItem";
            this.BuscarAnimalToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.BuscarAnimalToolStripMenuItem.Text = "txt1";
            this.BuscarAnimalToolStripMenuItem.Click += new System.EventHandler(this.BuscarAnimalToolStripMenuItem_Click);
            // 
            // FavoritosToolStripMenuItem
            // 
            this.FavoritosToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavoritosToolStripMenuItem.Name = "FavoritosToolStripMenuItem";
            this.FavoritosToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.FavoritosToolStripMenuItem.Text = "txt2";
            this.FavoritosToolStripMenuItem.Click += new System.EventHandler(this.FavoritosToolStripMenuItem_Click);
            // 
            // TextoInicialLabel
            // 
            this.TextoInicialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextoInicialLabel.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoInicialLabel.Image = global::PetAsService.Properties.Resources.dog3;
            this.TextoInicialLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextoInicialLabel.Location = new System.Drawing.Point(14, 223);
            this.TextoInicialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoInicialLabel.Name = "TextoInicialLabel";
            this.TextoInicialLabel.Size = new System.Drawing.Size(905, 187);
            this.TextoInicialLabel.TabIndex = 1;
            this.TextoInicialLabel.Text = "label1";
            this.TextoInicialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrocarPetUsuarioToolStripMenuItem
            // 
            this.TrocarPetUsuarioToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrocarPetUsuarioToolStripMenuItem.Name = "TrocarPetUsuarioToolStripMenuItem";
            this.TrocarPetUsuarioToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.TrocarPetUsuarioToolStripMenuItem.Text = "txt3";
            this.TrocarPetUsuarioToolStripMenuItem.Click += new System.EventHandler(this.TrocarPetUsuarioToolStripMenuItem_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.TextoInicialLabel);
            this.Controls.Add(this.MenuStripPrincipal);
            this.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuStripPrincipal.ResumeLayout(false);
            this.MenuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem BuscarAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FavoritosToolStripMenuItem;
        private System.Windows.Forms.Label TextoInicialLabel;
        private System.Windows.Forms.ToolStripMenuItem TrocarPetUsuarioToolStripMenuItem;
    }
}

