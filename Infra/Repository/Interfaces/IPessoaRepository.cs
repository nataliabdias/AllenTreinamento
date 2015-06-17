using Sample.Infra.Interfaces;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Infra.Repository.Interfaces
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
    }
}