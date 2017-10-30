using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FenWeiBo.Models
{
    public class User
    {

        public int? userid { get; set; }
        public string  uname { get; set; }
        public string pwd { get; set; }
        public int? tel { get; set; }
        public int? authority { get; set; }
        public int? stat { get; set; }
    }
}