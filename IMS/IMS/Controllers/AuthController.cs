using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace IMS.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            ViewBag.msg = "";
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fm)
        {   
            string username = fm.Get("username");
            string password = fm.Get("password");
            if (username == "admin" && password == "admin")
            {
                Session["username"] = username;
                return RedirectToAction("Index", "DashBoard");
            }
            else
            {
                ViewBag.msg = "Login Failed!!";
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}