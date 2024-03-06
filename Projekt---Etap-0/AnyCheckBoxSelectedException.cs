using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generator_hasel
{
    public class AnyCheckBoxSelectedException : Exception
    {
        public AnyCheckBoxSelectedException(string message) : base(message) { }
    }
}
