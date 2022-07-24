using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapApi
{
    public class Information
    {
        private int episodes = 0;

        public string Name { get; set; }
        public string Url { get; set; }
        public int Episodes { get => episodes; set => episodes = value; }
    }
}
