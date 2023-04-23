namespace PetAsService.Forms
{
    partial class Frm_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inicio));
            this.BemVindoLabel = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.BemVindoButton = new System.Windows.Forms.Button();
            this.PerguntaLabel = new System.Windows.Forms.Label();
            this.CachorroRadioButton = new System.Windows.Forms.RadioButton();
            this.GatoRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BemVindoLabel
            // 
            this.BemVindoLabel.Location = new System.Drawing.Point(12, 9);
            this.BemVindoLabel.Name = "BemVindoLabel";
            this.BemVindoLabel.Size = new System.Drawing.Size(254, 36);
            this.BemVindoLabel.TabIndex = 0;
            this.BemVindoLabel.Text = "label1";
            this.BemVindoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(15, 48);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(251, 20);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // BemVindoButton
            // 
            this.BemVindoButton.Location = new System.Drawing.Point(15, 135);
            this.BemVindoButton.Name = "BemVindoButton";
            this.BemVindoButton.Size = new System.Drawing.Size(251, 40);
            this.BemVindoButton.TabIndex = 2;
            this.BemVindoButton.Text = "button1";
            this.BemVindoButton.UseVisualStyleBackColor = true;
            this.BemVindoButton.Click += new System.EventHandler(this.BemVindoButton_Click);
            // 
            // PerguntaLabel
            // 
            this.PerguntaLabel.AutoSize = true;
            this.PerguntaLabel.Location = new System.Drawing.Point(12, 81);
            this.PerguntaLabel.Name = "PerguntaLabel";
            this.PerguntaLabel.Size = new System.Drawing.Size(35, 13);
            this.PerguntaLabel.TabIndex = 3;
            this.PerguntaLabel.Text = "label1";
            // 
            // CachorroRadioButton
            // 
            this.CachorroRadioButton.Checked = true;
            this.CachorroRadioButton.Location = new System.Drawing.Point(15, 103);
            this.CachorroRadioButton.Name = "CachorroRadioButton";
            this.CachorroRadioButton.Size = new System.Drawing.Size(123, 17);
            this.CachorroRadioButton.TabIndex = 4;
            this.CachorroRadioButton.TabStop = true;
            this.CachorroRadioButton.Text = "radioButton1";
            this.CachorroRadioButton.UseVisualStyleBackColor = true;
            // 
            // GatoRadioButton
            // 
            this.GatoRadioButton.Location = new System.Drawing.Point(140, 103);
            this.GatoRadioButton.Name = "GatoRadioButton";
            this.GatoRadioButton.Size = new System.Drawing.Size(123, 17);
            this.GatoRadioButton.TabIndex = 5;
            this.GatoRadioButton.Text = "radioButton2";
            this.GatoRadioButton.UseVisualStyleBackColor = true;
            // 
            // Frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 187);
            this.Controls.Add(this.GatoRadioButton);
            this.Controls.Add(this.CachorroRadioButton);
            this.Controls.Add(this.PerguntaLabel);
            this.Controls.Add(this.BemVindoButton);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.BemVindoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Inicio";
            this.Text = "Frm_Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BemVindoLabel;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Button BemVindoButton;
        private System.Windows.Forms.Label PerguntaLabel;
        private System.Windows.Forms.RadioButton CachorroRadioButton;
        private System.Windows.Forms.RadioButton GatoRadioButton;
    }
}