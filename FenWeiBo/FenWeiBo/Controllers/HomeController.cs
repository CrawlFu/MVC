using FenWeiBo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FenWeiBo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "每天发现新世界";

            Weibo weibo = new Weibo();
            if (Session["UID"].ToString() == null || Session["UID"].ToString() == "")
            {
                return View();
            }
            int uid =Convert.ToInt32(Session["UID"].ToString());
            string sql = "select * from weib where userid=" + uid;

            SqlHelper sqlhelper = new SqlHelper();
            //DataSet ds = sqlhelper.Query(sql);

            List<Weibo> weibolist = new List<Weibo>();
            weibo.userid = 1;
            weibo.userid = 1;
            weibo.cont = "sssfasdfasdfasdfasdfad";
            weibolist.Add(weibo);

            ViewBag.WeiboList = weibolist;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            List<string> asa = new List<string>();
            asa.Add("sss");
            asa.Add("sdfa");
            ViewBag.List = asa;
            return View();
        }
    }
}
