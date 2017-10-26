using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5FuLuA.Areas.LX04.Controllers
{
    public class Lx4Controller : Controller
    {
        public ActionResult Lx4Index()
        {
            return PartialView();
        }
    }
}