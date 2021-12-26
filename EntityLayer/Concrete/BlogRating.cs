using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogRating
    {
        public int blogRatingID { get; set; }
        public int blogID { get; set; }
        public int blogTotalScore { get; set; }
        public int blogRatingCount { get; set; }
    }
}
