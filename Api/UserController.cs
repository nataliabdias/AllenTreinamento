using Sample.Infra.Repository;
using Sample.Infra.Repository.Interfaces;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace Sample.Api
{
    public class UserController : ApiController
    {
        IUserRepository userRepository;

        public UserController()
        {
            userRepository = new UserRepository();
        }

        // GET api/<controller>
        public IEnumerable<User> Get()
        {
            return userRepository.GetAll();
        }

        // GET api/<controller>/5
        public User Get(int id)
        {
            return userRepository.GetById(id);
        }

        // POST api/<controller>
        public void Post(User user)
        {
            userRepository.Insert(user);
        }

        // PUT api/<controller>/5
        public void Put(int id, User model)
        {
            var userTemp = userRepository.GetById(id);
            userTemp = model;
            userRepository.Update(userTemp);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var userTemp = userRepository.GetById(id);

            if (Roles.GetRolesForUser(userTemp.UserName).Length > 0)
            {
                Roles.RemoveUserFromRoles(userTemp.UserName, Roles.GetRolesForUser(userTemp.UserName));
            }

            userRepository.Delete(userTemp);
        }
    }
}