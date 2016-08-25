using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestSerializeProject.Models;

namespace TestSerializeProject.Repository
{
    public class UserRepository
    {
        public string GetSerializeUser(User user)
        {
            return JsonConvert.SerializeObject(user);
        }

        public User GetDeSerializeUser(string userJson)
        {
            return JsonConvert.DeserializeObject<User>(userJson);
        }
    }
}
