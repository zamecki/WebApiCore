using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAplicationCore.Business.Interface;
using WebAplicationCore.Models.Models;
using WebAplicationCore.Repository;
using WebAplicationCore.Repository.Repository;

namespace WebAplicationCore.Business
{
    public class UserBusiness : IUserBusiness
    {
        WebApplicationCoreContext ctx;
        public UserBusiness(WebApplicationCoreContext c)
        {
            ctx = c;
        }

        public User Get(long id)
        {
            var user = ctx.TbUser.FirstOrDefault(b => b.Id == id);
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            var users = ctx.TbUser.ToList();
            return users;
        }

        public long Add(User user)
        {
            ctx.TbUser.Add(user);
            long userID = ctx.SaveChanges();
            return userID;
        }

        public long Delete(long id)
        {
            int userID = 0;
            var user = ctx.TbUser.FirstOrDefault(b => b.Id == id);
            if (user != null)
            {
                ctx.TbUser.Remove(user);
                userID = ctx.SaveChanges();
            }
            return userID;
        }

        public long Update(long id, User item)
        {
            long userID = 0;
            var user = ctx.TbUser.Find(id);
            if (user != null)
            {
                user.LastName = item.LastName;
                user.Name = item.Name;
                user.Password = item.Password;
                user.Posts = item.Posts;
                user.Email = item.Email;
                user.Active = item.Active;

                userID = ctx.SaveChanges();
            }
            return userID;
        }
    }
}
