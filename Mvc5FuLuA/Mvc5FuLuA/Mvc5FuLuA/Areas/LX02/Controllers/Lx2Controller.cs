using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5FuLuA.Areas.LX02.Models;

namespace Mvc5FuLuA.Areas.LX02.Controllers
{
    public class Lx2Controller : Controller
    {
        UserInfo user = new UserInfo()
        {
            UserName = "张三",
            UserPwd = "123456",
            MobilePhone = 12345678901,
            Email = "12345@qq.com",
            BirthDate = new DateTime(1995, 01, 01)
        };

        public ActionResult Index(string id)
        {
            switch (id)
            {
                case "1": return View("p1", user);
                case "2": return PartialView("p2", user);
                case "3": return Redirect(Url.Action("p3", "Lx2"));
            }
            return Content("未找到网页！");
        }

        public ActionResult p3()
        {
            return PartialView(user);
        }
    }
}