using Microsoft.EntityFrameworkCore;
using video_portal.Models;
using video_portal.Repository;

namespace video_portal.Test.Test;

public class VideoPortalTestContextTest : DbContext, IVideoPortalContext
{
    public VideoPortalTestContextTest(DbContextOptions<VideoPortalTestContextTest> options)
            : base(options)
    { }
    public virtual DbSet<Channel> Channels { get; set; }
    public virtual DbSet<Video> Videos { get; set; }
    public virtual DbSet<Comment> Comments { get; set; }
    public virtual DbSet<User> Users { get; set; }
}
