using Microsoft.EntityFrameworkCore;
using NewSite.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSite24.EF
{
    public class norContext : DbContext
    {
        public virtual DbSet<Direction> Direction { get; set; }
        public virtual DbSet<Station> Station { get; set; }

        private static List<ChatMessage> _chat = new List<ChatMessage> { new ChatMessage { Date = DateTime.Now, Message = "Приветствуем наших читателей!" } };
        private static List<Comment> _comments = new List<Comment>();
        public List<ChatMessage> Chat
        {
            get
            {
                return _chat;
            }
        }
        public List<Comment> Comment
        {
            get
            {
                return _comments;
            }
        }

        public norContext()
        {
        }

        public norContext(DbContextOptions<norContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HO5676A\\SQL_EXPRESS;Database=nor;Trusted_Connection=True;");
            }
        }

    }
}
