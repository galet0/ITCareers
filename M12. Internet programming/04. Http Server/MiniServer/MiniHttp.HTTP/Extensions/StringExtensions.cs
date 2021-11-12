using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHttp.HTTP.Extensions
{
    class StringExtensions
    {
        public string Capitalize(string text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(text[0].ToString().ToUpper() + text.Substring(1).ToLower());
            return sb.ToString();
        }
    }
}
