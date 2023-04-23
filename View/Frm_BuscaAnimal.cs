using PetAsService.Controller;
using PetAsService.Model;
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
    public partial class Frm_BuscaAnimal : Form
    {
        public Frm_BuscaAnimal()
        {
            InitializeComponent();
            this.Icon = Program.getIcon();
            preencheTexto();
            preencheComboBox();
            dc = new DogController();
            cc = new CatController();
        }
        private DogController dc;
        private CatController cc;
        private void preencheTexto()
        {
            this.Text = $"Meu {Program.selectedApi} Favorito - Busca";
            TextoPrincipalText.Text = "Busca de raças";
            InformacaoLabel.Text = $"Utilize a caixa de diálogo abaixo para obter mais informações sobre o {Program.selectedApi} desejado";
            RacaLabel.Text = "Raça";
            PrimeiraInfoLabel.Text = "Temperamento";
            SegundaInfoLabel.Text = "Média de tempo de vida";
            switch (Program.selectedApi)
            {
                case "Dog":
                    TerceiraInfoLabel.Text = "Finalidade";
                    break;
                case "Gato":
                    TerceiraInfoLabel.Text = "Origem";
                    break;
            }
            PrimeiroTextoLabel.Text = "";
            SegundoTextoLabel.Text = "";
            TerceiroTextoLabel.Text = "";
            GrpBusca.Text = "";
            FavoritarButton.Text = "Favoritar";
            VerFavoritosButton.Text = "Meus favoritos";
        }

        private void preencheComboBox()
        {
            try
            {
                RacaComboBox.Items.Clear();
                RacaComboBox.Items.Add("----Selecione uma raça----");
                RacaComboBox.SelectedIndex = 0;
                switch (Program.selectedApi)
                {
                    case "Dog":
                        DogController dc = new DogController();
                        List<Dog> dogList = dc.LoadDogs();
                        for (int i = 0; i < dogList.Count; i++)
                        {
                            ComboItem ci = new ComboItem();
                            ci.id = dogList[i].id.ToString();
                            ci.name = dogList[i].name;
                            RacaComboBox.Items.Add(ci);
                        }
                        break;
                    case "Gato":
                        CatController cc = new CatController();
                        List<Cat> catList = cc.LoadCats();
                        for (int i = 0; i < catList.Count; i++)
                        {
                            ComboItem ci = new ComboItem();
                            ci.id = catList[i].id;
                            ci.name = catList[i].name;
                            RacaComboBox.Items.Add(ci);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public class ComboItem
        {
            public string id { get; set; }
            public string name { get; set; }

            public override string ToString()
            {
                return name;
            }
        }

        private void FavoritarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RacaComboBox.SelectedIndex != 0)
                {
                    ComboItem selecao = (ComboItem)RacaComboBox.SelectedItem;
                    string mensagem = "";
                    switch (Program.selectedApi)
                    {
                        case "Dog":
                            Dog dog = dc.findById(Int32.Parse(selecao.id));
                            dc.AddFavorite(dog.reference_image_id);
                            mensagem = $"Raça {dog.name} favoritada com sucesso!";
                            break;
                        case "Gato":
                            Cat cat = cc.findById(selecao.id);
                            cc.AddFavorite(cat.reference_image_id);
                            mensagem = $"Raça {cat.name} favoritada com sucesso!";
                            break;
                    }
                    MessageBox.Show(mensagem, $"Meu {Program.selectedApi} favorito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparInformacoes();
                }
                else
                {
                    throw new Exception("Selecione uma raça!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Meu {Program.selectedApi} favorito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RacaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (RacaComboBox.SelectedIndex == 0)
                {
                    limparInformacoes();
                }
                else
                {
                    preencheInformacoes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limparInformacoes()
        {
            RacaComboBox.SelectedIndex = 0;
            PrimeiroTextoLabel.Text = "";
            SegundoTextoLabel.Text = "";
            TerceiroTextoLabel.Text = "";
            FavoritarButton.Enabled = false;
            PetPicture.Image = null;
        }

        private void preencheInformacoes()
        {
            PetPicture.Image = null;
            ComboItem selecao = (ComboItem)RacaComboBox.SelectedItem;
            switch (Program.selectedApi)
            {
                case "Dog":
                    DogController dc = new DogController();
                    Dog dog = dc.findById(Int32.Parse(selecao.id));
                    if (dog.temperament == null)
                    {
                        PrimeiroTextoLabel.Text = "Sem informações disponiveis";
                    }
                    else
                    {
                        PrimeiroTextoLabel.Text = dog.temperament;
                    }
                    if (dog.life_span == null)
                    {
                        SegundoTextoLabel.Text = "Sem informações disponiveis";
                    }
                    else
                    {
                        SegundoTextoLabel.Text = dog.life_span;
                    }
                    if (dog.bred_for == null)
                    {
                        TerceiroTextoLabel.Text = "Sem informações disponiveis";
                    }
                    else
                    {
                        TerceiroTextoLabel.Text = dog.bred_for;
                    }
                    PetPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    PetPicture.LoadAsync(dc.GetImageURL(dog.reference_image_id));
                    break;
                case "Gato":
                    CatController cc = new CatController();
                    Cat cat = cc.findById(selecao.id);
                    if (cat.temperament == null)
                    {
                        PrimeiroTextoLabel.Text = "Sem informações disponiveis";
                    }
                    else
                    {
                        PrimeiroTextoLabel.Text = cat.temperament;
                    }
                    if (cat.life_span == null)
                    {
                        SegundoTextoLabel.Text = "Sem informações disponiveis";
                    }
                    else
                    {
                        SegundoTextoLabel.Text = cat.life_span + " years";
                    }
                    if (cat.origin == null)
                    {
                        TerceiroTextoLabel.Text = "Sem informações disponiveis";
                    }
                    else
                    {
                        TerceiroTextoLabel.Text = cat.origin;
                    }
                    PetPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    PetPicture.LoadAsync(cc.GetImageURL(cat.reference_image_id));
                    break;
            }

            FavoritarButton.Enabled = true;
        }

        private void VerFavoritosButton_Click(object sender, EventArgs e)
        {
            Frm_Favorito form = new Frm_Favorito();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
