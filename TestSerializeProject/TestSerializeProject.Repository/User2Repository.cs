using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestSerializeProject.Models;

namespace TestSerializeProject.Repository
{
   public  class User2Repository
    {
       public string GetUser2Serialize(User2 user)
       {
           return JsonConvert.SerializeObject(user);
       }

       public User2 GetUser2Deserialize(string user2Json)
       {
           return JsonConvert.DeserializeObject<User2>(user2Json);
       }
    }
}
