using NewSite24.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSite.EF
{
    public class Comment
    {
        public int Id;
        public int Station;
        public DateTime DateTime;
        public string Nick;
        public string Text;
    }
}
