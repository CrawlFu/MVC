using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5FuLuA.Areas.LX03.Controllers
{
    public class Lx3Controller : Controller
    {
        public ActionResult Lx3Index()
        {
            return PartialView();
        }
    }
}