using MiniHttp.HTTP.Common;
using MiniHttp.HTTP.Enums;
using MiniHttp.HTTP.Exceptions;
using MiniHttp.HTTP.Requests;
using MiniHttp.HTTP.Responses;
using MiniHttp.WebServer.Results;
using MiniHttp.WebServer.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MiniHttp.WebServer
{
    public class ConnectionHandler
    {
        private readonly Socket client;
        private readonly IServerRoutingTable serverRoutingTable;

        public ConnectionHandler(Socket client, IServerRoutingTable serverRoutingTable)
        {
            CoreValidator.ThrowIfNull(client, nameof(client));
            CoreValidator.ThrowIfNull(serverRoutingTable, nameof(serverRoutingTable));
            this.client = client;
            this.serverRoutingTable = serverRoutingTable;
        }

        public async Task ProcessRequestAsync()
        {
            //IHttpResponse httpResponse = null;

            try
            {
                IHttpRequest httpRequest = await ReadRequest();

                if(httpRequest != null)
                {
                    Console.WriteLine($"Processing {httpRequest.RequestMethod} {httpRequest.Path}");

                    IHttpResponse httpResponse = this.HandleRequest(httpRequest);
                    await this.PrepareResponse(httpResponse);
                }
            }
            catch (BadRequestException ex)
            {
                await this.PrepareResponse(new TextResult(ex.ToString(), HttpResponseStatusCode.BadRequest));
            }
            catch (Exception ex)
            {
                await this.PrepareResponse(new TextResult(ex.ToString(), HttpResponseStatusCode.InternalServerError));
            }

            //await PrepareResponse(httpResponse);
            this.client.Shutdown(SocketShutdown.Both);
        }

        private async Task<IHttpRequest> ReadRequest() 
        {
            var result = new StringBuilder();
            var data = new ArraySegment<byte>(new byte[1024]);
            while (true)
            {
                int numberOfBytesRead = await this.client.ReceiveAsync(data.Array, SocketFlags.None);

                if(numberOfBytesRead == 0)
                {
                    break;
                }

                var bytesAsString = Encoding.UTF8.GetString(data.Array, 0, numberOfBytesRead);
                result.Append(bytesAsString);

                if(numberOfBytesRead < 1023)
                {
                    break;
                }
            }

            if (result.Length == 0)
            {
                return null;
            }

            return new HttpRequest(result.ToString());
        }

        private IHttpResponse HandleRequest(IHttpRequest httpRequest) 
        {
            if(!this.serverRoutingTable.Contains(httpRequest.RequestMethod, httpRequest.Path))
            {
                return new TextResult($"Route with method {httpRequest.RequestMethod} and path \"{httpRequest.Path}\" not found.", HttpResponseStatusCode.NotFound);
            }

            return this.serverRoutingTable.Get(httpRequest.RequestMethod, httpRequest.Path).Invoke(httpRequest);
        }

        private async Task PrepareResponse(IHttpResponse httpResponse) 
        {
            byte[] byteSegments = httpResponse.GetBytes();
            await this.client.SendAsync(byteSegments, SocketFlags.None);
        }
    }
}
