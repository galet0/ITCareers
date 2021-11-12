using MiniHttp.HTTP.Common;
using MiniHttp.HTTP.Enums;
using MiniHttp.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHttp.HTTP.Responses
{
    public class HttpResponse : IHttpResponse
    {
        public HttpResponse()
        {
            this.Headers = new HttpHeaderCollection();
            this.Content = new byte[0];
        }
        public HttpResponse(HttpResponseStatusCode statusCode)
            : this()
        {
            CoreValidator.ThrowIfNull(statusCode, nameof(statusCode));
            this.StatusCode = statusCode;
        }
        public HttpResponseStatusCode StatusCode { get; private set; }

        public IHttpHeaderCollection Headers { get; private set; }

        public byte[] Content { get; protected set; }

        public void AddHeader(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, nameof(header));
            this.Headers.AddHeader(header);
        }

        public byte[] GetBytes()
        {
            byte[] header = Encoding.UTF8.GetBytes(this.ToString());
            byte[] response = new byte[header.Length + Content.Length];
            Array.Copy(header, 0, response, 0, header.Length);
            Array.Copy(Content, 0, response, header.Length, Content.Length);

            return response;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result
                .Append($"{GlobalConstants.HttpOneProtocolFragment} {(int)this.StatusCode} {this.StatusCode}")
                .Append($"{GlobalConstants.HttpNewLine}")
                .Append($"{this.Headers}")
                .Append($"{GlobalConstants.HttpNewLine}");
            result.Append($"{GlobalConstants.HttpNewLine}");

            return result.ToString();
        }
    }
}
