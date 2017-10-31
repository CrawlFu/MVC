using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FenWeiBo.Models
{
    public class WeiComment
    {
        public int? comid { get; set; }
        public int? weid { get; set; }
        public int? userid { get; set; }
        public string comment { get; set; }
    }
}