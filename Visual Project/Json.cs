using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGCM
{
    public class ForeignName
    {
        public string language { get; set; }
        public string name { get; set; }
        public string multiverseid { get; set; }
    }

    public class Legality
    {
        public string format { get; set; }
        public string legality { get; set; }
    }

    public class Ruling
    {
        public string date { get; set; }
        public string text { get; set; }
    }

    public class Card
    {
        public int multiverseid { get; set; }
        public string number { get; set; }
        public string artist { get; set; }
        public int cmc { get; set; }
        public List<string> colorIdentity { get; set; }
        public List<string> colors { get; set; }
        public string flavor { get; set; }
        public List<ForeignName> foreignNames { get; set; }
        public string id { get; set; }
        public string imageName { get; set; }
        public string layout { get; set; }
        public List<Legality> legalities { get; set; }
        public string manaCost { get; set; }
        public string name { get; set; }
        public string power { get; set; }
        public List<string> printings { get; set; }
        public string rarity { get; set; }
        public string source { get; set; }
        public List<string> subtypes { get; set; }
        public string text { get; set; }
        public string toughness { get; set; }
        public string type { get; set; }
        public List<string> types { get; set; }
        public bool? reserved { get; set; }
        public List<Ruling> rulings { get; set; }
        public List<string> supertypes { get; set; }
    }

    public class Json
    {
        public string name { get; set; }
        public string gathererCode { get; set; }
        public string code { get; set; }
        public string magicCardsInfoCode { get; set; }
        public string releaseDate { get; set; }
        public string border { get; set; }
        public string type { get; set; }
        public string block { get; set; }

        public List<Card> cards { get; set; }
    }
}
