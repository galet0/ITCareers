using MiniHttp.HTTP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHttp.HTTP.Headers
{
    class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }
        public void AddHeader(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, nameof(header));
            if (!ContainsHeader(header.Key))
            {
                this.headers.Add(header.Key, null);
            }

            this.headers[header.Key] = header;
        }

        public bool ContainsHeader(string key)
        {
            CoreValidator.ThrowIfNullOrEmpty(key, nameof(key));
            return this.headers.ContainsKey(key);
        }

        public HttpHeader GetHeader(string key)
        {
            if (!ContainsHeader(key))
            {
                return null;
            }

            return this.headers[key];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var kvp in this.headers)
            {
                sb.AppendLine($"{kvp.Value}");
            }

            return sb.ToString();
        }
    }
}
