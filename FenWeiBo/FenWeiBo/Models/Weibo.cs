using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FenWeiBo.Models
{
    public class Weibo
    {
        public int? weid { get; set; }
        public int? userid { get; set; }
        public string cont { get; set; }
        public DateTime creattime { get; set; }
    }
}