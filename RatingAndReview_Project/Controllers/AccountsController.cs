using RatingAndReview_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RatingAndReview_Project.Controllers
{
    public class AccountsController : Controller
    {
        private RatingAndReviewEntities db = new RatingAndReviewEntities();

        // GET: Accounts
        
        public ActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var count = db.Accounts.Count(a => a.Username.Equals(username) && a.APassword.Equals(password));
            if (count > 0)
            {
                Session["username"] = username;
                return RedirectToAction("Index", "Product");
            }

            else
            {
                ViewBag.error = "Invalid Account";
                return View("Login");
            }
            
        }

        
        [HttpGet]
        public ActionResult SignUp()
        {
            return View("SignUp");
        }
        [HttpPost]
        public ActionResult SignUp(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();

            return RedirectToAction("Login","Accounts");
        }



    }
}