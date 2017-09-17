using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrox.PublicClass;

namespace Wrox.chaptor6
{
    public class People
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public People(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", FirstName,LastName);
        }

    }

    public class PeopleCompare : IComparer<People>
    {
        private CompareType type;

        public PeopleCompare(CompareType type)
        {
            this.type = type;
        }

        public int Compare(People x, People y)
        {
            int result = 0; ;
            switch(type)
            {
                case CompareType.FirstName:
                    result = x.FirstName.CompareTo(y.LastName);
                    break;
                case CompareType.LastName:
                    result = x.LastName.CompareTo(y.LastName);
                    break;
            }
            return result;
        }
    }



}
