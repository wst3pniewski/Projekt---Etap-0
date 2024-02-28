using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generator_hasel
{
    public class WrongPasswordLengthException : Exception
    {
        public WrongPasswordLengthException(string message) : base(message) { }
    }
}
