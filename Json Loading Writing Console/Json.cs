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
        
        public void loadJson()
        {
            
            string strResult = File.ReadAllText(filePath);
            var list = JsonConvert.DeserializeObject<User>(strResult);
            User user = JsonConvert.DeserializeObject<User>(strResult);

            if(user != null)
            {
                Console.WriteLine(user.id);
            }   
        }
        public void writeJson(User user)
        {
            string jsonString = JsonConvert.SerializeObject(user);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine(jsonString);

        }


    }
}
