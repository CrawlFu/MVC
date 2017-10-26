using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5FuLuA.Areas.LX06.Controllers
{
    public class Lx6Controller : Controller
    {
        // GET: LX06/Lx6
        public ActionResult Lx6Index()
        {
            return PartialView();
        }
    }
}