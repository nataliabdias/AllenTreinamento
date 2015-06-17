using Sample.Controllers.Base;
using Sample.Infra.Repository;
using Sample.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace Sample.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        IUserRepository userRepository;

        public HomeController()
        {
            userRepository = new UserRepository();
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult RenderMenu()
        {
            var id = WebSecurity.CurrentUserId;
            var user = userRepository.GetById(id);
            return PartialView("~/Views/Partial/_UserMenu.cshtml", user);
        }

    }
}
