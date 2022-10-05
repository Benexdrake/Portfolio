using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_Loading_Writing_Console
{
    public class Json
    {
        string filePath = "Config";
        
        public User[] loadJson()
        {
            string strResult = File.ReadAllText(filePath);
            User[] users = JsonConvert.DeserializeObject<User[]>(strResult);
            return users;
        }
        public void writeJson(User[] users)
        {
            string jsonString = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
