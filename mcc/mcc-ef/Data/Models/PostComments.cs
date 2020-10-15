using System;
using System.ComponentModel.DataAnnotations;

namespace ef
{
    public class PostComments
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? PostId { get; set; }
        public virtual  Post Post { get; set; }
    }
}
