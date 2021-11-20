﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Blog
    {
        [Key]
        public int blogID { get; set; }
        public string blogTitle { get; set; }
        public string blogContent { get; set; }
        public string blogThumbnailImage { get; set; }
        public string blogImage { get; set; }
        public DateTime blogCreateDate { get; set; }
        public bool blogStatus { get; set; }

        public int categoryID { get; set; }
        public Category Category { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
