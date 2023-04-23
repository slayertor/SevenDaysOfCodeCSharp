using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsService.Model
{
    public class PostRequest
    {
        public string image_id { get; set; }
        public string sub_id { get; set; }

        public static string SerializeUnit(PostRequest unit)
        {
            return JsonConvert.SerializeObject(unit);
        }

        public static PostRequest DeserializeUnit(string json)
        {
            return JsonConvert.DeserializeObject<PostRequest>(json);
        }
    }
}
