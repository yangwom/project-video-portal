using Microsoft.EntityFrameworkCore;
using video_portal.Models;
using video_portal.Repository;

namespace video_portal.Test;

public class VideoPortalTestContext : DbContext, IVideoPortalContext
{
    public VideoPortalTestContext(DbContextOptions<VideoPortalTestContext> options)
            : base(options)
    { }
    public virtual DbSet<Channel> Channels { get; set; }
    public virtual DbSet<Video> Videos { get; set; }
    public virtual DbSet<Comment> Comments { get; set; }
    public virtual DbSet<User> Users { get; set; }
}
