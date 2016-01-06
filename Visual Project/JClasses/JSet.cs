using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGCM.JClasses
{
    public class JSet
    {
        public string name {get; set;}
        public string code {get; set;}
        public string releaseDate {get; set;}
        public JCard[] cards { get; set; }
    }
}
