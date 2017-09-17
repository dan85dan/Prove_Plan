using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrox.chaptor6
{
    class Person : IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(Person other)
        {
            int result = this.LastName.CompareTo(other.LastName);
            if(result == 0)
            {
                result = this.FirstName.CompareTo(other.FirstName);
            }
            return result;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
