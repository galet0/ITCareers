using MiniHttp.HTTP.Enums;
using MiniHttp.HTTP.Requests;
using MiniHttp.HTTP.Responses;
using MiniHttp.WebServer.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHttp.Demo
{
    class HomeController
    {
        public HttpResponse Index(IHttpRequest httpRequest)
        {
            string content = "<h1>Hello, World!</h1>";

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public HttpResponse Contact(IHttpRequest httpRequest)
        {
            string content = "<h1>This is from Contact action.</h1>";

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }
    }
}
