using FenWeiBo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FenWeiBo.Controllers
{
    public class UserController: Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            SqlHelper sqlhelper = new SqlHelper();
            string sql = "insert into Userr values(" + user.userid + ",'" + user.uname + "','" + user.pwd + "'," + user.tel + ",1,1,0)";
            int i = sqlhelper.ExecuteSql(sql);
            Session["Name"] = user.uname;
            Session["Uid"] = user.userid;
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            SqlHelper sqlhelper = new SqlHelper();
            string sql = "select count(*) from Userr where userid="+user.userid+" and pwd='"+user.pwd+"'";

            //int i = sqlhelper.ExecuteSql(sql);
            object i = sqlhelper.GetSingle(sql);

            if (Convert.ToInt32(i) > 0)
            {
                Session["Name"] = user.uname;
                Session["Uid"] = user.userid;
                return RedirectToAction("Index", "Home");
            }

            return Content("密码错误");
            
        }

        public ActionResult AddWeibo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWeibo(Weibo weibo,string uid)
        {
            weibo.userid = Convert.ToInt32(uid);
            weibo.creattime = DateTime.Now;

            string sql = " insert into weib values(" + weibo.userid + ",'" + weibo.cont + "','" + weibo.creattime + "')";
            SqlHelper sqlhelper = new SqlHelper();
            int i = sqlhelper.ExecuteSql(sql);
            return RedirectToAction("Index", "Home");
        }

    }

}