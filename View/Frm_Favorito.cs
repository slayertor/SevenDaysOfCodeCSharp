using PetAsService.Controller;
using PetAsService.Model;
using PetAsService.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PetAsService.Forms
{
    public partial class Frm_Favorito : Form
    {
        public Frm_Favorito()
        {
            InitializeComponent();
            this.Icon = Program.getIcon();
            dc = new DogController();
            cc = new CatController();
            preencheTexto();
            buscarFavoritos();
            favoritesList = new List<List<string>>();
        }

        private DogController dc;
        private CatController cc;
        List<List<string>> favoritesList;

        private void buscarFavoritos()
        {
            try
            {
                FavoritosListBox.Items.Clear();

                switch (Program.selectedApi)
                {
                    case "Dog":
                        favoritesList = dc.GetFavorites(Program.nomeUsuario);
                        break;
                    case "Gato":
                        favoritesList = cc.GetFavorites(Program.nomeUsuario);
                        break;
                }
                if (favoritesList.Count > 0)
                {
                    for (int i = 0; i < favoritesList.Count; i++)
                    {
                        ListItem li = new ListItem();
                        switch (Program.selectedApi)
                        {
                            case "Dog":
                                Dog dog = dc.findByImageId(favoritesList[i][0]);
                                li.id = dog.id.ToString();
                                li.name = dog.name;
                                li.favoriteId = Int32.Parse(favoritesList[i][1]);
                                li.referenceImageId = dog.reference_image_id;
                                break;
                            case "Gato":
                                Cat cat = cc.findByImageId(favoritesList[i][0]);
                                li.id = cat.id;
                                li.name = cat.name;
                                li.favoriteId = Int32.Parse(favoritesList[i][1]);
                                li.referenceImageId = cat.reference_image_id;
                                break;
                        }
                        FavoritosListBox.Items.Add(li);
                    }
                    FavoritosListBox.Sorted = true;
                }
                else
                {
                    ExcluirButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void preencheTexto()
        {
            this.Text = $"Meu {Program.selectedApi} Favorito - Favoritos";
            TextoPrincipalText.Text = "Meus Favoritos";
            InformacaoLabel.Text = "Veja suas raças favoritas nessa lista abaixo!";
            GrpBusca.Text = "";
            ExcluirButton.Text = "Excluir favorito";
            VerFotoButton.Text = "Ver foto";
        }

        public class ListItem
        {
            public string id { get; set; }
            public string name { get; set; }

            public int favoriteId { get; set; }

            public string referenceImageId { get; set; }

            public override string ToString()
            {
                return name;
            }
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FavoritosListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Nenhum favorito selecionado", $"Meu {Program.selectedApi} Favorito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Você deseja excluir este favorito?", $"Meu {Program.selectedApi} favorito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        ListItem li = (ListItem)FavoritosListBox.SelectedItem;
                        switch (Program.selectedApi)
                        {
                            case "Dog":
                                dc.DeleteFavorite(li.favoriteId);
                                break;
                            case "Gato":
                                cc.DeleteFavorite(li.favoriteId);
                                break;
                        }
                        MessageBox.Show($"{Program.selectedApi} excluido com sucesso!", $"Meu {Program.selectedApi} favorito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FavoritosListBox.Items.Remove(FavoritosListBox.SelectedItem);
                        if (FavoritosListBox.Items.Count == 0)
                        {
                            ExcluirButton.Enabled = false;
                        }
                        else
                        {
                            FavoritosListBox.Sorted = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir" + ex.Message);
            }
        }

        private void VerFotoButton_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFotoPet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AbrirFotoPet()
        {
            if (FavoritosListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum favorito selecionado",$"Meu {Program.selectedApi} Favorito",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                ListItem li = (ListItem)FavoritosListBox.SelectedItem;
                string url = "";
                switch (Program.selectedApi)
                {
                    case "Dog":
                        url = dc.GetImageURL(li.referenceImageId);
                        break;
                    case "Gato":
                        url = cc.GetImageURL(li.referenceImageId);
                        break;
                }
                Frm_FotoPet form = new Frm_FotoPet(url);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void FavoritosListBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                AbrirFotoPet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
