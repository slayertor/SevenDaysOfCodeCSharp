using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetAsService.View
{
    public partial class Frm_FotoPet : Form
    {
        public Frm_FotoPet(string url)
        {
            InitializeComponent();
            this.Icon = Program.getIcon();
            this.Text = "";
            PetPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PetPictureBox.LoadAsync(url);
        }
    }
}
