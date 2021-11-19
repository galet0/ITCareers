using IRunes.App.Controllers;
using MiniHttp.HTTP.Enums;
using MiniHttp.WebServer;
using MiniHttp.WebServer.Results;
using MiniHttp.WebServer.Routing;
using System;
using System.IO;

namespace IRunes.App
{
    class Launcher
    {
        static void Main(string[] args)
        {
            ServerRoutingTable serverRoutingTable = new ServerRoutingTable();
            //Home/Index
            serverRoutingTable.Add(HttpRequestMethod.Get, "/", request => new RedirectResult("/Home/Index"));
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Home/Index", request => new HomeController().Index(request));

            //Albums
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/All", request => new AlbumsController().All(request));
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/Details", request => new AlbumsController().Details(request));
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/Create", request => new AlbumsController().Create(request));
            serverRoutingTable.Add(HttpRequestMethod.Post, "/Albums/Create", request => new AlbumsController().CreateConfirm(request));


            serverRoutingTable.Add(HttpRequestMethod.Get, "/Home/css/bootstrap.min.css", request =>
            {
                string content = File.ReadAllText("Resources/css/bootstrap.min.css"); //чета съдържанието в низа
                var result = new TextResult(content, HttpResponseStatusCode.Ok, "text/css; charset=utf-8"); //създавам result обекта, като тука се уверявам, че задавам mime тип на text/css и charset-a, явно също. Отделно, мисля, че метода, който приемаше byte[] нещо не е ок или всъщност си е :) Не знам защо не е станало по-рано, но ся вече работи, по същия начин се оправя и за другите там js-и, само че те са с text/javascript :)
                return result;
            });

            serverRoutingTable.Add(HttpRequestMethod.Get, "/Home/js/bootstrap.min.js", request =>
            {
                string content = File.ReadAllText("Resources/js/bootstrap.min.js"); 
                var result = new TextResult(content, HttpResponseStatusCode.Ok, "text/javascript; charset=utf-8"); 
                return result;
            });
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Home/js/jquery-3.4.1.min.js", request =>
            {
                string content = File.ReadAllText("Resources/js/jquery-3.4.1.min.js"); 
                var result = new TextResult(content, HttpResponseStatusCode.Ok, "text/javascript; charset=utf-8"); 
                return result;
            });
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Home/js/popper.min.js", request =>
            {
                string content = File.ReadAllText("Resources/js/popper.min.js");
                var result = new TextResult(content, HttpResponseStatusCode.Ok, "text/javascript; charset=utf-8"); 
                return result;
            });


            serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/All/css/bootstrap.min.css", request =>
            {
                string content = File.ReadAllText("Resources/css/bootstrap.min.css");
                var result = new TextResult(content, HttpResponseStatusCode.Ok, "text/css; charset=utf-8"); 
                return result;
            });

            serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/All/js/bootstrap.min.js", request =>
            {
                string content = File.ReadAllText("Resources/js/bootstrap.min.js");
                var result = new TextResult(content, HttpResponseStatusCode.Ok, "text/javascript; charset=utf-8");
                return result;
            });
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/All/js/jquery-3.4.1.min.js", request =>
            {
                string content = File.ReadAllText("Resources/js/jquery-3.4.1.min.js");
                var result = new TextResult(content, HttpResponseStatusCode.Ok, "text/javascript; charset=utf-8");
                return result;
            });
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/All/js/popper.min.js", request =>
            {
                string content = File.ReadAllText("Resources/js/popper.min.js");
                var result = new TextResult(content, HttpResponseStatusCode.Ok, "text/javascript; charset=utf-8");
                return result;
            });
            Server server = new Server(8000, serverRoutingTable);
            server.Run();
        }
    }
}
