using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CaseStudyZico.Models
{
    class AtomJsonFields
    {
        public int atomicNumber { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string atomicMass { get; set; }
        public string electronicConfiguration { get; set; }
        public string standardState { get; set; }
        public int meltingPoint { get; set; }
        public int boilingPoint { get; set; }
        

    }
}
