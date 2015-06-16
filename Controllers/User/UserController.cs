using Sample.Controllers.Base;
using Sample.Filters;
//using Sample.Infra.Data;
//using Sample.Infra.Repository;
//using Sample.Infra.Repository.Interfaces;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Sample.Controllers
{
    //[Authorize(Roles = "Administrador")]
    //public class UserController : BaseController
    //{
    //    IUserRepository userRepository;

    //    public UserController()
    //    {
    //        userRepository = new UserRepository();
    //    }

    //    public UserController(IUserRepository repository)
    //    {
    //        this.userRepository = repository;
    //    }

    //    public ActionResult Index()
    //    {
    //        IEnumerable<User> result = userRepository.GetAll();
    //        return View(result);
    //    }

    //    [LogAction]
    //    public ActionResult Edit(int id)
    //    {
    //        User user = userRepository.GetById(id);

    //        var perfil = Roles.GetRolesForUser(user.UserName).FirstOrDefault();

    //        user.Perfil = perfil;

    //        if (user == null)
    //            return HttpNotFound();
    //        return View(user);

    //    }

    //    [LogAction]
    //    [HttpPost]
    //    public ActionResult Edit(User model)
    //    {
    //        if (!ModelState.IsValid)
    //            return Edit(model.Id);

    //        this.userRepository.Update(model);

    //        if (Roles.GetRolesForUser(model.UserName).Length > 0)
    //        {
    //            Roles.RemoveUserFromRoles(model.UserName, Roles.GetRolesForUser(model.UserName));
    //        }
    //        Roles.AddUserToRole(model.UserName, model.Perfil);

    //        ViewBag.Success = "Operacao Realizada com Sucesso";

    //        IEnumerable<User> result = this.userRepository.GetAll();

    //        return View("Index", result);
    //    }

    //    [HttpDelete]
    //    public ActionResult Remove(int id)
    //    {
    //        var user = this.userRepository.GetById(id);

    //        if (user == null)
    //            return HttpNotFound();

    //        if (Roles.GetRolesForUser(user.UserName).Length > 0)
    //        {
    //            Roles.RemoveUserFromRoles(user.UserName, Roles.GetRolesForUser(user.UserName));
    //        }

    //        this.userRepository.Delete(user);

    //        return Json("OK");
    //    }

    //    public ActionResult New()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    public ActionResult New(User model)
    //    {
    //        if (!ModelState.IsValid)
    //            return New();

    //        this.userRepository.Insert(model);

    //        Roles.AddUserToRole(model.UserName, model.Perfil);

    //        ViewBag.Success = "Operacao Realizada com Sucesso";

    //        IEnumerable<User> result = this.userRepository.GetAll();

    //        return View("Index", result);
    //    }

    //}
}
