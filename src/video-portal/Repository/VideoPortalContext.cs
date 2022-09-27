using Microsoft.EntityFrameworkCore;
using video_portal.Models;

namespace video_portal.Repository;

public class VideoPortalContext : DbContext, IVideoPortalContext
{
    public VideoPortalContext(DbContextOptions<VideoPortalContext> options) : base(options) { }
    public VideoPortalContext() { }
}
