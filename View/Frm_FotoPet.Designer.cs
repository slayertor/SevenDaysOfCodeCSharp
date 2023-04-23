namespace PetAsService.View
{
    partial class Frm_FotoPet
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
            this.PetPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PetPictureBox
            // 
            this.PetPictureBox.Location = new System.Drawing.Point(12, 12);
            this.PetPictureBox.Name = "PetPictureBox";
            this.PetPictureBox.Size = new System.Drawing.Size(315, 223);
            this.PetPictureBox.TabIndex = 0;
            this.PetPictureBox.TabStop = false;
            // 
            // Frm_FotoPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 247);
            this.Controls.Add(this.PetPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_FotoPet";
            this.Text = "Frm_FotoPet";
            ((System.ComponentModel.ISupportInitialize)(this.PetPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PetPictureBox;
    }
}