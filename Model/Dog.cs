using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsService.Model
{
    public class Dog
    {
        public int id { get; set; }
        public string name { get; set; }
        public string reference_image_id { get; set; }
        public string life_span { get; set; }
        public Weight weight { get; set; }
        public Height height { get; set; }
        public string bred_for { get; set; }
        public string breed_group { get; set; }
        public string temperament { get; set; }
        public string origin { get; set; }
        public Image image { get; set; }
        public string country_code { get; set; }
        public string description { get; set; }
        public string history { get; set; }

    }

}
