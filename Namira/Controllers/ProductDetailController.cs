using Models.EF;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Namira.Controllers
{
    public class ProductDetailController : Controller
    {
        NamiraDbContext context = new NamiraDbContext();

        public ActionResult Index(float productID)
        {
            var iplProduct = new ProductModel();
            var data = iplProduct.getDetail(productID).Take(1);
            ViewBag.DataItem = data;

            var iplReview = new ReviewsModel();
            var reviews = iplReview.getReview(productID);
            ViewBag.Reviews = reviews;

            return View();
        }

    }
}