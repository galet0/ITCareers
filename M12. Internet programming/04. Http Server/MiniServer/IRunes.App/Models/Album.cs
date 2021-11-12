using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRunes.App.Models
{
    public class Album
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }

        public decimal Price { get; set; }
    }
}
