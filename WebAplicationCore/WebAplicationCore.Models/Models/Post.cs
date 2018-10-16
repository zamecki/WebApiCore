using System;
using System.Collections.Generic;

namespace WebAplicationCore.Models.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public DateTime Createtime { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public string Imageapiid { get; set; }

        //TODO add DTO to prevent json loop loading 
        //public virtual User User { get; set; }
    }
}
