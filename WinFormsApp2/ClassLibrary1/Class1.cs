using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ClassLibrary1 {
    

    public class Blog {
        public int BlogId { get; set; }
        public string Url { get; set; }
    }

    public class RssBlog : Blog {
        public string RssUrl { get; set; }
    }

    
}