using Microsoft.EntityFrameworkCore;
using video_portal.Models;
using video_portal.Repository;

namespace video_portal.Test
{
    public class TestContext
    {
        [Trait("Category", "2 - Implemente o contexto de banco de dados")]
        [Fact(DisplayName = "VideoPortalContext deve ser uma implementação de IVideoPortalContext")]
        public void ShouldImplementContext()
        {
            var contextType = typeof(VideoPortalContext);
            contextType.Should().NotBeNull();
            contextType.Should().BeAssignableTo(typeof(IVideoPortalContext));
        }

        [Trait("Category", "2 - Implemente o contexto de banco de dados")]
        [Fact(DisplayName = "VideoPortalContext deve implementado a tabela Channel")]
        public void ShouldImplementTableChannel()
        {
            var propertyToCheck = typeof(VideoPortalContext).GetProperty("Channels");
            propertyToCheck.Should().NotBeNull();
            var propertyTypeName = propertyToCheck.PropertyType;
            propertyTypeName.Should().BeAssignableTo(typeof(DbSet<Channel>));
        }

        [Trait("Category", "2 - Implemente o contexto de banco de dados")]
        [Fact(DisplayName = "VideoPortalContext deve implementado a tabela Videos")]
        public void ShouldImplementTableVideos()
        {
            var propertyToCheck = typeof(VideoPortalContext).GetProperty("Videos");
            propertyToCheck.Should().NotBeNull();
            var propertyTypeName = propertyToCheck.PropertyType;
            propertyTypeName.Should().BeAssignableTo(typeof(DbSet<Video>));
        }

        [Trait("Category", "2 - Implemente o contexto de banco de dados")]
        [Fact(DisplayName = "VideoPortalContext deve implementado a tabela Users")]
        public void ShouldImplementTableUsers()
        {
            var propertyToCheck = typeof(VideoPortalContext).GetProperty("Users");
            propertyToCheck.Should().NotBeNull();
            var propertyTypeName = propertyToCheck.PropertyType;
            propertyTypeName.Should().BeAssignableTo(typeof(DbSet<User>));
        }

        [Trait("Category", "2 - Implemente o contexto de banco de dados")]
        [Fact(DisplayName = "VideoPortalContext deve implementado a tabela Comments")]
        public void ShouldImplementTableComments()
        {
            var propertyToCheck = typeof(VideoPortalContext).GetProperty("Comments");
            propertyToCheck.Should().NotBeNull();
            var propertyTypeName = propertyToCheck.PropertyType;
            propertyTypeName.Should().BeAssignableTo(typeof(DbSet<Comment>));
        }

        [Trait("Category", "2 - Implemente o contexto de banco de dados")]
        [Fact(DisplayName = "VideoPortalContext deve herdar de DbContext e implementar IVideoPortalContext")]
        public void ShouldImplementDatabase()
        {
            var contextType = typeof(VideoPortalContext);
            contextType.Should().NotBeNull();
            contextType.Should().BeAssignableTo(typeof(IVideoPortalContext));
            contextType.Should().BeAssignableTo(typeof(DbContext));
        }

        [Trait("Category", "2 - Implemente o contexto de banco de dados")]
        [Fact(DisplayName = "VideoPortalContext deve implementar o método OnConfiguring")]
        public void ShouldImplementOnConfigureing()
        {
            var _context = new VideoPortalContext();
            _context.Should().NotBeNull();
            _context.Should().BeAssignableTo(typeof(IVideoPortalContext));
            _context.Database.ProviderName.Should().NotBeNull();
        }
    }
}
