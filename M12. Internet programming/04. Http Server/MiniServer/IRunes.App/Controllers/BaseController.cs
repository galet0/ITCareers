using MiniHttp.HTTP.Enums;
using MiniHttp.HTTP.Responses;
using MiniHttp.WebServer.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IRunes.App.Controllers
{
    public abstract class BaseController
    {
        protected Dictionary<string, object> ViewData;

        protected BaseController()
        {
            this.ViewData = new Dictionary<string, object>();
        }

        private string ParseTemplate(string viewContent)
        {
            foreach (var param in this.ViewData)
            {
                viewContent = viewContent.Replace($"@Model.{param.Key}", param.Value.ToString());
            }

            return viewContent;
        }

        protected IHttpResponse View([CallerMemberName] string view=null)
        {
            string controllerName = this.GetType().Name.Replace("Controller", string.Empty);
            string viewName = view;
            //C:\Users\weeew\source\repos\MiniServer\IRunes.App\Views\Home\Index.html
            string viewContent = File.ReadAllText("../../../Views/" + controllerName + "/" + viewName + ".html");
            viewContent = this.ParseTemplate(viewContent);

            HtmlResult htmlResult = new HtmlResult(viewContent, HttpResponseStatusCode.Ok);

            return htmlResult;
        }

        protected IHttpResponse Redirect(string url)
        {
            return new RedirectResult(url);
        }
     }
}
