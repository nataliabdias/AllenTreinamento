using Sample.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace Sample.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return Index();

            if (WebSecurity.Login(model.UserName, model.Password))
                return RedirectToAction("Index", "Home");

            ModelState.AddModelError("", "User Name ou senha invalidos");

            return View("Index", model);
        }

        public ActionResult SignOut()
        {
            WebSecurity.Logout();
            return RedirectToAction("Index", "Login");
        }
    }
}
