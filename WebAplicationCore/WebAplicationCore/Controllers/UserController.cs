using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAplicationCore.Business.Interface;
using WebAplicationCore.Models.Models;
using WebAplicationCore.Repository.Repository;

namespace WebAplicationCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserBusiness Business;

        public UserController(IUserBusiness business)
        {
            Business = business;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Business.GetAll();
        }

        // GET api/values/5  
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return Business.Get(id);
        }

        // POST api/values  
        [HttpPost]
        public void Post([FromBody]User student)
        {
            Business.Add(student);
        }

        // POST api/values  
        [HttpPut]
        public void Put([FromBody]User user)
        {
            Business.Update(user.Id, user);
        }

        // DELETE api/values/5  
        [HttpDelete("{id}")]
        public long Delete(int id)
        {
            return Business.Delete(id);
        }
    }
}