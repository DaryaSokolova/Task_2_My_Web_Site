using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSite.EF
{
    public class ChatMessage
    {
        public DateTime Date { get; set; }
        public string Nick { get; set; }
        public string Message { get; set; }
    }
}
