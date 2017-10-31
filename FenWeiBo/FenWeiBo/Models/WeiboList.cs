using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FenWeiBo.Models
{
    public class WeiboList
    {
        public int? uid { get; set; }
        public int? wid { get; set; }
        public bool isconcern { get; set; }
        public string content { get; set; }
        public List<WeiComment>  commentList{ get; set; }
    }
}