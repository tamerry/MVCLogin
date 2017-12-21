using MVCLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Authorize(MVCLogin.Models.User userModel)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var userDetails = db.Users.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
                if(userDetails==null)
                {
                    userModel.LoginErrorMessage = "Kullanıcı adı veya şifre yanlış";
                    return View("Index", userModel);
                }
                else
                {
                    Session["UserID"] = userDetails.UserID;
                    Session["UserName"] = userDetails.UserName;
                  return  RedirectToAction("Index", "Home");
                }
            }

         
        }
        public ActionResult Logout()
        {
            int userId = (int)Session["UserID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}