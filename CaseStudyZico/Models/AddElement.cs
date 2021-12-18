using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyZico.Models
{
    class AddElement : IEquatable<AddElement>, IComparable<AddElement>
    {
        public string ElementName { get; set; }
        public AddElement()
        {
        }
        public AddElement(string name)
        {
            //ElementNumber = number;
            ElementName = name;
        }

        public override int GetHashCode()
        {
            return ElementName.GetHashCode();
        }

        public bool Equals(AddElement other)
        {
            return ElementName == other.ElementName;
        }

        public int CompareTo(AddElement other)
        {
            return ElementName.CompareTo(other.ElementName);
        }
    }
    
}
