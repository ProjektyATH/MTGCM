using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGCM.JClasses
{
    public class JCard
    {
        public string id { get; set; }
        public string name { get; set; }
        public string manacost { get; set; }
        public int cmc { get; set; }
        public string[] types { get; set; }
        public string[] subtypes { get; set; }
        public string rarity { get; set; }
        public string text { get; set; }
        public string flavor { get; set; }
        public string artist { get; set; }
        public string power { get; set; }
        public string toughness { get; set; }
        public string releaseDate { get; set; }
        public string imageName { get; set; }
        public string number { get; set; }
        public int multiverseid { get; set; }

    }
}
