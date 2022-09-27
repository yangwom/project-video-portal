using Microsoft.EntityFrameworkCore;
using video_portal.Models;

namespace video_portal.Repository
{
    public interface IVideoPortalContext
    {
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public int SaveChanges();
    }
}

