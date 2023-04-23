namespace PetAsService.Forms
{
    partial class Frm_Favorito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Favorito));
            this.TextoPrincipalText = new System.Windows.Forms.Label();
            this.InformacaoLabel = new System.Windows.Forms.Label();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.GrpBusca = new System.Windows.Forms.GroupBox();
            this.FavoritosListBox = new System.Windows.Forms.ListBox();
            this.VerFotoButton = new System.Windows.Forms.Button();
            this.GrpBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextoPrincipalText
            // 
            this.TextoPrincipalText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextoPrincipalText.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoPrincipalText.Location = new System.Drawing.Point(13, 13);
            this.TextoPrincipalText.Name = "TextoPrincipalText";
            this.TextoPrincipalText.Size = new System.Drawing.Size(292, 39);
            this.TextoPrincipalText.TabIndex = 0;
            this.TextoPrincipalText.Text = "label1";
            this.TextoPrincipalText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InformacaoLabel
            // 
            this.InformacaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InformacaoLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformacaoLabel.Location = new System.Drawing.Point(20, 56);
            this.InformacaoLabel.Name = "InformacaoLabel";
            this.InformacaoLabel.Size = new System.Drawing.Size(285, 41);
            this.InformacaoLabel.TabIndex = 1;
            this.InformacaoLabel.Text = "label1";
            this.InformacaoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcluirButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirButton.Location = new System.Drawing.Point(191, 397);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(114, 43);
            this.ExcluirButton.TabIndex = 3;
            this.ExcluirButton.Text = "button1";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // GrpBusca
            // 
            this.GrpBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBusca.Controls.Add(this.FavoritosListBox);
            this.GrpBusca.Location = new System.Drawing.Point(20, 100);
            this.GrpBusca.Name = "GrpBusca";
            this.GrpBusca.Size = new System.Drawing.Size(285, 289);
            this.GrpBusca.TabIndex = 2;
            this.GrpBusca.TabStop = false;
            this.GrpBusca.Text = "groupBox1";
            // 
            // FavoritosListBox
            // 
            this.FavoritosListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FavoritosListBox.FormattingEnabled = true;
            this.FavoritosListBox.Location = new System.Drawing.Point(22, 19);
            this.FavoritosListBox.Name = "FavoritosListBox";
            this.FavoritosListBox.Size = new System.Drawing.Size(248, 251);
            this.FavoritosListBox.TabIndex = 0;
            this.FavoritosListBox.DoubleClick += new System.EventHandler(this.FavoritosListBox_DoubleClick);
            // 
            // VerFotoButton
            // 
            this.VerFotoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VerFotoButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerFotoButton.Location = new System.Drawing.Point(23, 397);
            this.VerFotoButton.Name = "VerFotoButton";
            this.VerFotoButton.Size = new System.Drawing.Size(114, 43);
            this.VerFotoButton.TabIndex = 4;
            this.VerFotoButton.Text = "button1";
            this.VerFotoButton.UseVisualStyleBackColor = true;
            this.VerFotoButton.Click += new System.EventHandler(this.VerFotoButton_Click);
            // 
            // Frm_Favorito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(317, 452);
            this.Controls.Add(this.VerFotoButton);
            this.Controls.Add(this.ExcluirButton);
            this.Controls.Add(this.GrpBusca);
            this.Controls.Add(this.InformacaoLabel);
            this.Controls.Add(this.TextoPrincipalText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Favorito";
            this.Text = "Frm_BuscaAnimal";
            this.GrpBusca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TextoPrincipalText;
        private System.Windows.Forms.Label InformacaoLabel;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.GroupBox GrpBusca;
        private System.Windows.Forms.ListBox FavoritosListBox;
        private System.Windows.Forms.Button VerFotoButton;
    }
}