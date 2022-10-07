using Microsoft.EntityFrameworkCore;
using video_portal.Models;

namespace video_portal.Repository;

public class VideoPortalContext : DbContext, IVideoPortalContext
{
    public DbSet<Channel> Channels { get; set; }
    public DbSet<Video> Videos { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<User> Users { get; set; }
    public VideoPortalContext(DbContextOptions<VideoPortalContext> options) : base(options) { }
    public VideoPortalContext() { }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=sql_server_db;User=SA;Password=Password12;");
        }
    }

 protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Channel>().HasKey(c => c.ChannelId);
        mb.Entity<Comment>().HasKey(c => c.CommentId);
        mb.Entity<User>().HasKey(c => c.UserId);
        mb.Entity<Video>().HasKey(c => c.VideoId);
    }
    

}
