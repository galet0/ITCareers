using MiniHttp.HTTP.Requests;
using MiniHttp.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRunes.App.Controllers
{
    class HomeController : BaseController
    {
        public IHttpResponse Index(IHttpRequest httpRequest)
        {
            return this.View();
        }
    }
}
