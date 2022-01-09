using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Admin
    {
        [Key]
        public int adminID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string shortDescription { get; set; }
        public string imageUrl { get; set; }
        public string role { get; set; }

    }
}
