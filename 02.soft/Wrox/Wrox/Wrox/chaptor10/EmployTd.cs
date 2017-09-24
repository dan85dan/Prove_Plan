using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrox.chaptor10
{
    public class EmployeeIdException : Exception
    {
        public EmployeeIdException(string msg) : base(msg) { }
    }
    public struct EmployTd
    {
        public readonly char Prefix;
        public readonly int number;

        public EmployTd(string id)
        {
            if (id == null) throw new ArgumentNullException("id");

            Prefix = (id.ToUpper())[0];
        }
    }
}
