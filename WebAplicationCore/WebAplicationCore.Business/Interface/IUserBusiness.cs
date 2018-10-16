using System;
using System.Collections.Generic;
using System.Text;
using WebAplicationCore.Models.Models;
using WebAplicationCore.Repository.Repository;

namespace WebAplicationCore.Business.Interface
{
    public interface IUserBusiness : IRepository<User, long>
    {
    }
}
