using Mvc5FuLuA.Areas.LX07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5FuLuA.Areas.LX07.Controllers
{
    public class Lx7Controller : Controller
    {
        private Movies db = new Movies();

        public ActionResult Lx7Index()
        {
            return PartialView(db.Movie.ToList());
        }
    }
}