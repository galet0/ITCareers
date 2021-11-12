using MiniHttp.HTTP.Enums;
using MiniHttp.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHttp.HTTP.Responses
{
    public interface IHttpResponse
    {
        HttpResponseStatusCode StatusCode { get; }
        IHttpHeaderCollection Headers { get; }
        byte[] Content { get; }
        void AddHeader(HttpHeader header);
        byte[] GetBytes();
    }
}
