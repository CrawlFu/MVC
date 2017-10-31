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

            WeiboList weibo = null;
            //if (Session["UID"].ToString() == null || Session["UID"].ToString() == "")
            //{
            //    return View();
            //}
            //int uid =Convert.ToInt32(Session["UID"].ToString());
            //string sql = "select * from weib where userid=" + uid;

            //SqlHelper sqlhelper = new SqlHelper();
            ////DataSet ds = sqlhelper.Query(sql);

            List<WeiboList> weibolist = new List<WeiboList>();
            weibo = new WeiboList();
            weibo.uid= 1;
            weibo.content = "今天天气好";
            weibo.isconcern = false;
            List<WeiComment> commentlist = new List<WeiComment>();
            WeiComment com = new WeiComment();
            com.comid = 1;
            com.comment = "hahah";
            com.userid = 1;
            com.weid = 1;
            commentlist.Add(com);
            weibo.commentList = commentlist;
            weibolist.Add(weibo); 
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
       
        [HttpPost]
        public ActionResult Index(string uid)
        {
            return View();
        }

        public ActionResult Love(string fid)
        {
            //int userid = Convert.ToInt32(Session["UID"]);
            //string sql = "insert into Userelation values('" + userid + "','" + fid + "')";
            //SqlHelper sqlhelper = new SqlHelper();
            //int i = sqlhelper.ExecuteSql(sql);
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Comment(string id,string uid)
        {
            //int userid = Convert.ToInt32(Session["UID"]);
            //string sql = "insert into Userelation values('" + userid + "','" + fid + "')";
            //SqlHelper sqlhelper = new SqlHelper();
            //int i = sqlhelper.ExecuteSql(sql);
            if (Request.IsAjaxRequest())
            {
                return PartialView(id);
            }
            else
            {
                return View(id);
            }
        }
    }
}
