using Chat.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Data
{
    public class ChatDbContext : IdentityDbContext<User>, IChatDbContext 
    {
        public ChatDbContext()
            : base("ChatDb", throwIfV1Schema: false)
        {
        }

        public IDbSet<Message> Messages { get; set; }

        public IDbSet<Group> Groups { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public static ChatDbContext Create()
        {
            return new ChatDbContext();
        }
    }
}
