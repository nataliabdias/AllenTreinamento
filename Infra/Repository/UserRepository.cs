using Sample.Infra.Data;
using Sample.Infra.Repository.Interfaces;
using Sample.Models;
using System;
//using System.Transactions;
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
    public class UserRepository : IUserRepository
    {
        Context context = new Context();

        public IEnumerable<User> GetAll()
        {
            return (from x in context.Users
                    select x);
        }

        public User GetById(int id)
        {
            return (from x in context.Users
                    where x.Id == id
                    select x).FirstOrDefault();
        }

        public void Update(User user)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                context.Users.Attach(user);
                this.ChangeState(user, EntityState.Modified);
                this.context.SaveChanges();

                ((SimpleMembershipProvider)Membership.Provider).DeleteAccount(user.UserName);
                WebSecurity.CreateAccount(user.UserName, user.Password);

                scope.Complete();

            }
        }

        public void ChangeState(User user, EntityState state)
        {
            ((IObjectContextAdapter)this.context)
               .ObjectContext
               .ObjectStateManager
               .ChangeObjectState(user, state);
        }

        public void Insert(User obj)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                this.context.Users.Attach(obj);
                this.ChangeState(obj, EntityState.Added);
                this.context.SaveChanges();

                WebSecurity.CreateAccount(obj.UserName, obj.Password);

                scope.Complete();
            }

        }

        public void Delete(User obj)
        {
            using (TransactionScope scope = new TransactionScope())
            {
            this.context.Users.Remove(obj);
            this.ChangeState(obj, EntityState.Deleted);
            this.context.SaveChanges();

            ((SimpleMembershipProvider)Membership.Provider).DeleteAccount(obj.UserName);

            scope.Complete();
            }
        }

    }
}