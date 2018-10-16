using System;
using System.Collections.Generic;

namespace WebAplicationCore.Models.Models
{
    public partial class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
