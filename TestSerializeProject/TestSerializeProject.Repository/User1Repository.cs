using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestSerializeProject.Models;

namespace TestSerializeProject.Repository
{
    public class User1Repository
    {
        public string GetSerialize(User1 user)
        {
            return JsonConvert.SerializeObject(user);
        }

        public User1 GetDeserialize(string user1Json)
        {
            return JsonConvert.DeserializeObject<User1>(user1Json);
        }
    }
}
