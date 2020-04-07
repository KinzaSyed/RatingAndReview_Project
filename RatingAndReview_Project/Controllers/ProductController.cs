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
            ViewBag.product = db.Products.Find(id);
            return View();
        }
    }
}