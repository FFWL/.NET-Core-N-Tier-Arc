using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message2
    {
        [Key]
        public int messageID { get; set; }
        public int? senderID { get; set; }
        public int? receiverID { get; set; }
        public string subject { get; set; }
        public string messageDetails { get; set; }
        public DateTime messageDate { get; set; }
        public bool messageStatus { get; set; }
        public Writer SenderUser { get; set; }
        public Writer ReceiverUser { get; set; }
    }
}
