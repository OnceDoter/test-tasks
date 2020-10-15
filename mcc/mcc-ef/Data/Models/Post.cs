using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ef
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string? PostText { get; set; }
        public DateTime CreateDateTime { get; set; }
        public virtual ICollection<PostComments> Comments { get; set; }
    }
}
