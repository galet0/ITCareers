using MiniHttp.HTTP.Enums;
using MiniHttp.HTTP.Headers;
using MiniHttp.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHttp.WebServer.Results
{
    public class TextResult : HttpResponse
    {
        public TextResult(string content, 
            HttpResponseStatusCode responseStatusCode,
            string contentType = "text/plain; charset=utf-8") : base(responseStatusCode)
        {
            base.Headers.AddHeader(new HttpHeader("Content-type", contentType));
            base.Content = Encoding.UTF8.GetBytes(content);
        }

        public TextResult(byte[] content,
            HttpResponseStatusCode responseStatusCode,
            string contentType = "text/plain; charset=utf-8") : base(responseStatusCode)
        {
            base.Content = content;
            base.Headers.AddHeader(new HttpHeader("Content-type", contentType));
        }
    }
}
