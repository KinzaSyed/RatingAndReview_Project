using RatingAndReview_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RatingAndReview_Project.Controllers
{
    public class ProductController : Controller
    {
        private RatingAndReviewEntities db = new RatingAndReviewEntities();
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.products = db.Products.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Details(int id)
        {


            var product = db.Products.Find(id);
            ViewBag.product = product;
            var review = new Review()
            {
                ProductId = product.id
        };
            return View("Details", review);
        }
        [HttpPost]
        public ActionResult SendReview(Review review, double rating)
        {
            string username = Session["username"].ToString();
            review.DatePost = DateTime.Now;
            review.AccountId = db.Accounts.Single(a => a.Username.Equals(username)).id;
            review.Rating = rating;
            db.Reviews.Add(review);
            db.SaveChanges();
            return RedirectToAction("Details", "Product", new { id = review.ProductId });

        }

        

    }
}