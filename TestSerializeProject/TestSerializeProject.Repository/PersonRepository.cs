using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestSerializeProject.Models;

namespace TestSerializeProject.Repository
{
    public class PersonRepository
    {
        public string GetPersonSerialize(Person person)
        {
            return JsonConvert.SerializeObject(person);
        }

        public Person GetDeserializePerson(string personJson)
        {
            return JsonConvert.DeserializeObject<Person>(personJson);
        }
    }
}
