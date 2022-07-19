using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewSite.EF;
using NewSite24.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSite.Controllers
{
    public class ChatController : Controller
    {
        public List<ChatMessage> Messages()
        {
            var db = new norContext();
            return db.Chat.OrderByDescending(x => x.Date).ToList();
        }

        public void AddMessage(string message)
        {
            var db = new norContext();
            db.Chat.Add(new ChatMessage { Date = DateTime.Now, Message = message });
            // db.SaveChanges();
        }
    }
}
