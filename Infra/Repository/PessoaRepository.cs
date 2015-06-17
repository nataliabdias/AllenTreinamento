using Sample.Infra.Data;
using Sample.Infra.Repository.Interfaces;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using WebMatrix.WebData;
using System.Web.Security;
using System.Transactions;

namespace Sample.Infra.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        Context context = new Context();

        public IEnumerable<Pessoa> GetAll()
        {
            return (from x in context.Pessoas
                    select x);
        }

        public Pessoa GetById(int id)
        {
            return (from x in context.Pessoas
                    where x.Id == id
                    select x).FirstOrDefault();
        }

        public void Update(Pessoa pessoa)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                context.Pessoas.Attach(pessoa);
                this.ChangeState(pessoa, EntityState.Modified);
                this.context.SaveChanges();

                scope.Complete();

            }
        }

        public void ChangeState(Pessoa pessoa, EntityState state)
        {
            ((IObjectContextAdapter)this.context)
               .ObjectContext
               .ObjectStateManager
               .ChangeObjectState(pessoa, state);
        }

        public void Insert(Pessoa obj)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                this.context.Pessoas.Attach(obj);
                this.ChangeState(obj, EntityState.Added);
                this.context.SaveChanges();

                scope.Complete();
            }

        }

        public void Delete(Pessoa obj)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                this.context.Pessoas.Remove(obj);
                this.ChangeState(obj, EntityState.Deleted);
                this.context.SaveChanges();

                scope.Complete();
            }
        }

    }
}