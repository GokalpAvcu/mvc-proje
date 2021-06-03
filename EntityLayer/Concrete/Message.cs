using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Message
    {
        public int MessageID { get; set; }
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
