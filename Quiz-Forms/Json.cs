using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Forms
{
    internal class Json
    {
        string filePath = "quiz.json";
        Quiz[] a;
        Quiz quiz;
        
        public Quiz[] loadJson()
        {
            string jsonFile = File.ReadAllText(filePath);

            a = JsonConvert.DeserializeObject<Quiz[]>(jsonFile);
            Random random = new Random();
            Quiz[] shuffle = a.OrderBy(x => random.Next()).ToArray();

            return shuffle;
        }
    }
}
