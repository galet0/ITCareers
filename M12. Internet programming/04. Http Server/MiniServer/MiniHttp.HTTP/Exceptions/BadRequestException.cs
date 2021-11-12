using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHttp.HTTP.Exceptions
{
    public class BadRequestException : Exception
    {
        private const string exceptionDefaultMessage = "The Request was malformed or contains unsupported elements.";

        public BadRequestException(): base(exceptionDefaultMessage){}
        public BadRequestException(string message) : base(message) { }
    }
}
