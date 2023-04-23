using PetAsService.Controller;
using PetAsService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetAsService.Forms
{
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()
        {
            InitializeComponent();
            preencheTexto();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void preencheTexto() {
            BemVindoButton.Text = "Entrar";
            BemVindoLabel.Text = "Qual o seu nome?";
            PerguntaLabel.Text = "Qual PET deseja pesquisar?";
            CachorroRadioButton.Text = "Cachorro";
            GatoRadioButton.Text = "Gato";
            UsuarioTextBox.Text = Program.nomeUsuario;
            if (Program.selectedApi == "Gato")
            {
                GatoRadioButton.Checked = true;
            }
        }

        private void BemVindoButton_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text.Trim()!="") {
                Program.nomeUsuario = UsuarioTextBox.Text;
                if (CachorroRadioButton.Checked)
                {
                    Program.selectedApi = "Dog";
                }
                else
                {
                    Program.selectedApi = "Gato";
                }
                this.Dispose();

            } else
            {
                MessageBox.Show("Por favor, informe seu nome");
            }
        }

    }
}
