using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHttp.HTTP.Exceptions
{
    public class InternalServerErrorException : Exception
    {
        private const string defaultMessageException = "The Server has encountered an error.";

        public InternalServerErrorException() : base(defaultMessageException)
        {

        }

        public InternalServerErrorException(string message) : base(message)
        {

        }
    }
}
