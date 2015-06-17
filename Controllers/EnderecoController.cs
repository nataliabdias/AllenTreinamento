using Sample.Infra.Repository;
using Sample.Infra.Repository.Interfaces;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Controllers
{
    public class EnderecoController : Controller
    {
        IPessoaRepository pessoaRepository;

        public EnderecoController()
        {
            pessoaRepository = new PessoaRepository();
        }

        public EnderecoController(IPessoaRepository repository)
        {
            this.pessoaRepository = repository;
        }
        //
        // GET: /Endereco/

        public ActionResult Index(int idPessoa)
        {
            Pessoa pessoa = pessoaRepository.GetById(idPessoa);

            return View(pessoa);
        }
        public ActionResult New(int idPessoa)
        {
            ViewBag.IdPessoa = idPessoa;
            return View();
        }

        [HttpPost]
        public ActionResult New(Endereco endereco, int idPessoa)
        {

            Pessoa pessoa = pessoaRepository.GetById(idPessoa);

            pessoa.Endereco.Add(endereco);

            this.pessoaRepository.Update(pessoa);

            ViewBag.Success = "Operacao Realizada com Sucesso";

            return View("Index", pessoa);

        }


    }
}
