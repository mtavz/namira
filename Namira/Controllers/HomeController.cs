using Models.Code;
using Models.EF;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Namira.Controllers
{
    public class HomeController : Controller
    {

        NamiraDbContext context = new NamiraDbContext();



        public ActionResult Index()
        {
            var iplProduct = new ProductModel();
            var data = iplProduct.getLatest();
            ViewBag.DataItem = data;
            return View();
        }




        public PartialViewResult ShowDetailProduct(float productID)
        {
            var iplProduct = new ProductModel();
            var data = iplProduct.getDetail(productID).Take(1);
            ViewBag.ItemDetail = data;
            return PartialView("~/Views/Shared/_QuickView.cshtml", data);
        }


        public void AddItem(float productID)
        {
            var addcart = new ProductModel();
            addcart.AddCart(productID , 3 , 4);
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {

            if (ModelState.IsValid)
            {
                var result = new AccountModel().Login(model.UserName, model.PassWord);

                if (result == true)
                {
                    var userSession = new UserSession();
                    userSession.UserName = model.UserName;

                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "đăng nhập không đúng.");
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session[CommonConstants.USER_SESSION] = null;
            return RedirectToAction("Index", "Home");

        }
    }
}