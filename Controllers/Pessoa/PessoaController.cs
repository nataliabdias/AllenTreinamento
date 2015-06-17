using Sample.Controllers.Base;
using Sample.Filters;
using Sample.Infra.Repository.Interfaces;
using Sample.Infra.Data;
using Sample.Infra.Repository;
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
    [Authorize]//[Authorize(Roles = "Administrador")]
    public class PessoaController : BaseController
    {
        IPessoaRepository pessoaRepository;

        public PessoaController()
        {
            pessoaRepository = new PessoaRepository();
        }

        public PessoaController(IPessoaRepository repository)
        {
            this.pessoaRepository = repository;
        }

        public ActionResult Index()
        {
            IEnumerable<Pessoa> result = pessoaRepository.GetAll();
            return View(result);
        }

        [LogAction]
        public ActionResult Edit(int id)
        {
            Pessoa pessoa = pessoaRepository.GetById(id);

            //var perfil = Roles.GetRolesForUser(user.UserName).FirstOrDefault();

           // user.Perfil = perfil;

            if (pessoa == null)
                return HttpNotFound();
            return View(pessoa);

        }

        [LogAction]
        [HttpPost]
        public ActionResult Edit(Pessoa model)
        {
            if (!ModelState.IsValid)
                return Edit(model.Id);

            this.pessoaRepository.Update(model);
            
            ViewBag.Success = "Operacao Realizada com Sucesso";

            IEnumerable<Pessoa> result = this.pessoaRepository.GetAll();

            return View("Index", result);
        }

        [HttpDelete]
        public ActionResult Remove(int id)
        {
            var pessoa = this.pessoaRepository.GetById(id);

            if (pessoa == null)
                return HttpNotFound();
                     

            this.pessoaRepository.Delete(pessoa);

            return Json("OK");
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Pessoa model)
        {
            if (!ModelState.IsValid)
                return New();

            this.pessoaRepository.Insert(model);

            ViewBag.Success = "Operacao Realizada com Sucesso";

            IEnumerable<Pessoa> result = this.pessoaRepository.GetAll();

            return View("Index", result);
        }

    

    }
}
