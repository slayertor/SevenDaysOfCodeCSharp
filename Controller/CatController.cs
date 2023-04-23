using Newtonsoft.Json;
using PetAsService.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace PetAsService.Controller
{
    public class CatController
    {

        public CatController()
        {
            restController = new RestController();
        }
        private RestController restController;

        public Cat findById(string id)
        {
            try
            {
                string request = $"https://api.thecatapi.com/v1/breeds/{id}";
                RestResponse response = restController.GetResponse(request, Method.Get);
                Cat cat = System.Text.Json.JsonSerializer.Deserialize<Cat>(response.Content);
                return cat;
            }
            catch
            {
                throw new Exception("Erro ao buscar o gato pelo ID");
            }
        }

        public Cat findByImageId(string imageId)
        {
            try
            {
                string request = $"https://api.thecatapi.com/v1/images/{imageId}";
                RestResponse response = restController.GetResponse(request, Method.Get);
                dynamic obj = JsonConvert.DeserializeObject<dynamic>(response.Content);
                var breedId = (string)obj.breeds[0].id;
                Cat cat = findById(breedId);
                return cat;
            }
            catch
            {
                throw new Exception("Erro ao buscar a raça selecionada");
            }
        }

        public void AddFavorite(string imageId)
        {
            try
            {
                if(!IsFavorite(imageId)) {
                    string request = $"https://api.thecatapi.com/v1/favourites";
                    var json = new JObject();
                    json.Add("image_id", imageId);
                    json.Add("sub_id", Program.nomeUsuario);
                    RestResponse response = restController.GetResponse(request, Method.Post, json.ToString());
                }
                else
                {
                    throw new Exception("Essa raça já é a sua favorita!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<List<string>> GetFavorites(string username)
        {
            try
            {
                string request = $"https://api.thecatapi.com/v1/favourites?sub_id={username}";
                RestResponse response = restController.GetResponse(request, Method.Get);
                dynamic obj = JsonConvert.DeserializeObject<dynamic>(response.Content);
                List<List<string>> favoritesList = new List<List<string>>();
                for (int i = 0; i < obj.Count; i++)
                {
                    var favorite = (string)obj.SelectToken($"[{i}].image_id");
                    var favoriteId = (string)obj.SelectToken($"[{i}].id");
                    favoritesList.Add(new List<string> { favorite, favoriteId });
                }
                return favoritesList;
            }
            catch
            {
                throw new Exception("Erro ao buscar os favoritos");
            }
        }


        public void DeleteFavorite(int id)
        {
            try
            {
                string request = $"https://api.thecatapi.com/v1/favourites/{id}";
                RestResponse response = restController.GetResponse(request, Method.Delete);
            }
            catch
            {
                throw new Exception("Erro ao deletar o favorito");
            }
        }

        public List<Cat> LoadCats()
        {
            try
            {
                string request = "https://api.thecatapi.com/v1/breeds";
                RestResponse response = restController.GetResponse(request, Method.Get);
                List<Cat> lista = System.Text.Json.JsonSerializer.Deserialize<List<Cat>>(response.Content);
                return lista;
            }
            catch
            {
                throw new Exception("Erro ao buscar a lista de raças.");
            }
        }

        public string GetImageURL(string reference)
        {
            try
            {
                string request = $"https://api.thecatapi.com/v1/images/{reference}";
                RestResponse response = restController.GetResponse(request, Method.Get);
                dynamic obj = JsonConvert.DeserializeObject<dynamic>(response.Content);
                return obj.url;
            }
            catch
            {
                throw new Exception("Erro ao buscar a URL da imagem");
            }
        }

        public Boolean IsFavorite(string imageId) 
        {
            try
            {
                List<List<string>> favoritesList = GetFavorites(Program.nomeUsuario);
                for(int i = 0; i < favoritesList.Count; i++)
                {
                    if (favoritesList[i][0].Equals(imageId))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                throw new Exception("Erro na requisição!");
            }
        }

    }
}
