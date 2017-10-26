using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5FuLuA.Areas.LX02.Models
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string Email { get; set; }
        public long MobilePhone { get; set; }
        public DateTime BirthDate { get; set; }
    }
}