using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsService.Controller
{
    public class RestController
    {

        public RestResponse GetResponse(string URL, Method method)
        {
            try
            {
                var client = new RestClient(URL);
                client.Options.MaxTimeout = -1;
                RestRequest request = new RestRequest();
                request.Method = method;
                request.AddHeader("x-api-key", ConfigurationManager.AppSettings[Program.selectedApi]);
                RestResponse response = client.Execute(request);
                return response;
            }
            catch
            {
                throw new Exception("Erro ao executar a requisição");
            }
        }

        public RestResponse GetResponse(string URL, Method method, string body)
        {
            try
            {
                var client = new RestClient(URL);
                client.Options.MaxTimeout = -1;
                RestRequest request = new RestRequest();
                request.Method = method;
                request.AddHeader("x-api-key", ConfigurationManager.AppSettings[Program.selectedApi]);
                if (body != null)
                {
                    request.AddStringBody(body, DataFormat.Json);
                }
                RestResponse response = client.Execute(request);
                return response;
            }
            catch
            {
                throw new Exception("Erro ao executar a requisição");
            }
        }
    }
}
