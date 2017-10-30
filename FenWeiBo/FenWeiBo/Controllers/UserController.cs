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
            string sql = "insert into Userr values('"+user.userid+"','"+user.uname+"','"+user.pwd+"',null,null,null) ";

            int i = sqlhelper.ExecuteSql(sql);
            Session["Name"] = user.uname;
            Session["Uid"] = user.userid;
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            SqlHelper sqlhelper = new SqlHelper();
            string sql = "select * from Userr where userid="+user.userid+" and pwd="+user.pwd;

            //int i = sqlhelper.ExecuteSql(sql);
            Session["Name"] = user.uname;
            Session["Uid"] = user.userid;
            return View();
        }
    }

}