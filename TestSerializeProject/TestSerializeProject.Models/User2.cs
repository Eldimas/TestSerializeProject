using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestSerializeProject.Models
{
    [JsonObject]
    public class User2
    {
        [JsonProperty("id")]
        public int Id;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("photo_album")]
        public List<Photo> PhotoAlbum;
    }
}
