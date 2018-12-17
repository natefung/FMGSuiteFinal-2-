/*Group 2-3
 * Nathan Fung
 * Eric Lee
 * Anson Huang
 * Katrina Peterson
 * 
 * This program is an mvc web app that will allow FMG Suite to enter in data and statistics into their database instead of
 * having to slack messages back and forth about their reports. 
 * It allows people to login and enter their statistics for that hour. Also has a tableau dashboard that updates live with 
 * the database. 
 * 
 * */


using FMGSuiteFinal.DAL;
using FMGSuiteFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FMGSuiteFinal.Controllers
{
    public class HomeController : Controller
    {
        private FMGSuiteContext db = new FMGSuiteContext();

        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();

            var currentUser = db.Database.SqlQuery<Users>(
            "Select * " +
            "FROM Users " +
            "WHERE email = '" + email + "' AND " +
            "password = '" + password + "'");

            if (currentUser.Count() > 0)
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);
                return RedirectToAction("Index", "Home", new { userlogin = email });
            }
            else
            {
                return View();
            }
        }
    }
}