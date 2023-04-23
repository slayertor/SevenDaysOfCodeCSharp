using PetAsService.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetAsService
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            abrirJanelaInicial();
        }

        private void preencheTexto()
        {
            this.Text = $"Meu {Program.selectedApi} favorito";
            BuscarAnimalToolStripMenuItem.Text = "Buscar animais";
            FavoritosToolStripMenuItem.Text = "Meus favoritos";
            TextoInicialLabel.Text = $"Bem vindo ao Meu {Program.selectedApi} favorito!";
            TrocarPetUsuarioToolStripMenuItem.Text = "Trocar usuário/PET";
        }

        private void BuscarAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BuscaAnimal form = new Frm_BuscaAnimal();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

        }

        private void FavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Favorito form = new Frm_Favorito();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void TrocarPetUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirJanelaInicial();
        }

        private void abrirJanelaInicial()
        {
            Frm_Inicio form = new Frm_Inicio();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            this.Icon = Program.getIcon();
            preencheTexto();
        }
    }
}
