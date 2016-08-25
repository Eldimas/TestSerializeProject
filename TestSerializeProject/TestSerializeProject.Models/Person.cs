using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TestSerializeProject.Models
{
    public class Person
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Gender
        {
            Male,
            Female
        }

        public int Id;
        public string Name;
        public Gender GenderEnum;

    }
}
