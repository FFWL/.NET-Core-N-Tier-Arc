using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int commentID { get; set; }
        public string commentUserName { get; set; }
        public string commentTitle { get; set; }
        public string commentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }


        public int blogID { get; set; }
        public Blog Blog { get; set; }
    }
}
