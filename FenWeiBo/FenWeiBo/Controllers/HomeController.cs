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
            //if (Session["UID"]== null || Session["UID"] == "")
            //{
            //    return View();
            //}
            //int uid =Convert.ToInt32(Session["UID"].ToString());
            //string sql = "select * from weib where userid=" + uid;

            SqlHelper sqlhelper = new SqlHelper();
            ////DataSet ds = sqlhelper.Query(sql);
            
            
            List<WeiboList> weibolist = new List<WeiboList>();
            weibo = new WeiboList();
            weibo.uid= 1;
            weibo.wid = 1;
            weibo.content = "今天天气好";
            weibo.isconcern = true;
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

            //List<Weibo> tempWeibo = null;
            //foreach (Weibo item in tempWeibo)
            //{
            //    weibo = new WeiboList();
            //    weibo.uid = item.userid;
            //    weibo.content = item.cont;
            //    string sql = "select count(*) from Userelation where userid= "+ uid + " and fid = " + item.userid;
            //    object tem = sqlhelper.GetSingle(sql);
            //    if (Convert.ToInt32(tem) == 1)
            //    {
            //        weibo.isconcern = true;
            //    } else
            //    {
            //        weibo.isconcern = false;
            //    }

            //    string sql1 = "select * from weicomment where weid=" + item.weid;
            //    DataSet dt = sqlhelper.Query(sql1);

            //    List<WeiComment> com1 = new List<WeiComment>();
            //    WeiComment comment = new WeiComment();


            //    weibo.commentList = com1;
            //    weibolist.Add(weibo);
            //}
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
        public ActionResult Comment(string id,string uid,string wid)
        {
            //int userid = Convert.ToInt32(Session["UID"]);
            //string sql = "insert into Userelation values('" + userid + "','" + fid + "')";
            //SqlHelper sqlhelper = new SqlHelper();
            //int i = sqlhelper.ExecuteSql(sql);

            ViewBag.Uid = uid;
            ViewBag.Wid = wid;
            if (Request.IsAjaxRequest())
            {
                return PartialView(id);
            }
            else
            {
                return View(id);
            }
        }
        public ActionResult AddComment(string val1,string comment)
        {
            int userid = Convert.ToInt32(Session["UID"]);
            string sql = "insert into weicomment values('" + val1 + "','" + userid + "','" + comment + "')";
            SqlHelper sqlhelper = new SqlHelper();
            int i = sqlhelper.ExecuteSql(sql);
            return RedirectToAction("Index", "Home");
        }
       [HttpPost]
        public ActionResult AddComment(WeiComment comment)
        {
            //string sql = "insert into weicomment values('" + comment.weid + "','" + comment.userid + "','" + comment.comment + "')";
            //SqlHelper sqlhelper = new SqlHelper();
            //int i = sqlhelper.ExecuteSql(sql);
            return RedirectToAction("Index", "Home");
        }
    }
}
