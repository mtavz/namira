using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Namira.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Admin/Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult loadProducts()
        {

            var iplProduct = new ProductModel();
            var productsList = iplProduct.getLatest();
            return Json(
                new {data = productsList},
                JsonRequestBehavior.AllowGet
                );
        }

        public ActionResult AddOrEdit(float productID)
        {
            var iplProduct = new ProductModel();
            var productDetail = iplProduct.getProduct(productID);
            ViewBag.productDetail = productDetail;
            return PartialView("AddOrEdit");
        }
    }   

}