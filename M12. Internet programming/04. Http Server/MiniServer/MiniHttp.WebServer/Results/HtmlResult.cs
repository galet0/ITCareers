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
    public class HtmlResult : HttpResponse
    {
        public HtmlResult(string content, HttpResponseStatusCode responseStatusCode)
            : base(responseStatusCode)
        {
            base.Headers.AddHeader(new HttpHeader("Content-Type", "text/html; charset=utf-8"));
            base.Content = Encoding.UTF8.GetBytes(content);
        }
    }
}
