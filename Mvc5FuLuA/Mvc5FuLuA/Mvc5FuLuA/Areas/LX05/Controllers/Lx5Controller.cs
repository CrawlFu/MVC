using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5FuLuA.Areas.LX05.Models;

namespace Mvc5FuLuA.Areas.LX05.Controllers
{
    public class Lx5Controller : Controller
    {
        UserInfo user = new UserInfo()
        {
            UserName = "d1",
            UserPwd = "12345",
            MobilePhone = 123456,
            Email = "123",
            BirthDate = new DateTime(1995, 01, 01)
        };

        public ActionResult Lx5Index()
        {
            return PartialView(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Lx5Index(string userName)
        {
            ViewBag.Result = "验证失败。";
            if (this.ModelState.IsValid)
            {
                ViewBag.Result = "验证成功。";
            }
            return PartialView(user);
        }
    }
}