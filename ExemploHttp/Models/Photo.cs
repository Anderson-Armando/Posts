using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHttp.Models
{
    public class Photo
    {
        public int albumId { get; set; }
        public string title { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
    }
}
