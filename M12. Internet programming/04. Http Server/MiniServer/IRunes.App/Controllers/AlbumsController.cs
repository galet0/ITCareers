﻿using MiniHttp.HTTP.Requests;
using MiniHttp.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRunes.App.Controllers
{
    public class AlbumsController : BaseController
    {
        public IHttpResponse Create(IHttpRequest httpRequest)
        {
            return this.View();
        }

        public IHttpResponse CreateConfirm(IHttpRequest httpRequest)
        {
            return this.View();
        }
    }
}
