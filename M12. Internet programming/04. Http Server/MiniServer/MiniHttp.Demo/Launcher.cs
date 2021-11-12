using MiniHttp.HTTP.Enums;
using MiniHttp.WebServer;
using MiniHttp.WebServer.Routing;
using System;

namespace MiniHttp.Demo
{
    class Launcher
    {
        static void Main(string[] args)
        {
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            serverRoutingTable.Add
                (
                    HttpRequestMethod.Get,
                    "/",
                    request => new HomeController().Index(request)
                );

            serverRoutingTable.Add
                (
                    HttpRequestMethod.Get,
                    "/contact",
                    request => new HomeController().Contact(request)
                );

            Server server = new Server(8000, serverRoutingTable);
            server.Run();
        }
    }
}
