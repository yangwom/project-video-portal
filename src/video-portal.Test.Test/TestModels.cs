
using Microsoft.EntityFrameworkCore;
using video_portal.Models;

namespace video_portal.Test.Test;

public class TestModels
{
    [Trait("Category", "1 - Implemente os Models da aplicação")]
    [Theory(DisplayName = "Channel deve conter chave primária")]
    [InlineData("ChannelId")]
    public void ChannelShouldContainProperPrimaryKey(string keyName)
    {
        var contextOptions = new DbContextOptionsBuilder<VideoPortalTestContextTest>()
            .UseInMemoryDatabase("VideoPortalContext")
            .Options;
        VideoPortalTestContextTest testContext = new(contextOptions);
        DbSet<Channel> set = testContext.Set<Channel>();
        var property = set.EntityType.FindProperty(keyName);
        property.IsKey().Should().BeTrue();
    }

    [Trait("Category", "1 - Implemente os Models da aplicação")]
    [Theory(DisplayName = "Channel deve conter as propriedades e tipos corretos")]
    [InlineData("ChannelId", typeof(int))]
    [InlineData("ChannelName", typeof(string))]
    [InlineData("ChannelDescription", typeof(string))]
    [InlineData("Url", typeof(string))]
    [InlineData("Videos", typeof(IEnumerable<Video>))]
    [InlineData("Owners", typeof(IEnumerable<User>))]
    public void ChannelShouldContainProperties(string propertyName, Type propertyType)
    {
        var propertyToCheck = typeof(Channel).GetProperty(propertyName);
        propertyToCheck.Should().NotBeNull();
        var propertyTypeName = propertyToCheck.PropertyType;
        propertyTypeName.Should().BeAssignableTo(propertyType);
    }

    [Trait("Category", "1 - Implemente os Models da aplicação")]
    [Theory(DisplayName = "Comment deve conter chave primária")]
    [InlineData("CommentId")]
    public void CommentShouldContainProperPrimaryKey(string keyName)
    {
        var contextOptions = new DbContextOptionsBuilder<VideoPortalTestContextTest>()
            .UseInMemoryDatabase("VideoPortalContext")
            .Options;
        VideoPortalTestContextTest testContext = new(contextOptions);
        DbSet<Comment> set = testContext.Set<Comment>();
        var property = set.EntityType.FindProperty(keyName);
        property.IsKey().Should().BeTrue();
    }

    [Trait("Category", "1 - Implemente os Models da aplicação")]
    [Theory(DisplayName = "Comment deve conter chave estrangeira")]
    [InlineData("VideoId")]
    [InlineData("UserId")]
    public void CommentShouldContainProperForeignKeys(string keyName)
    {
        var contextOptions = new DbContextOptionsBuilder<VideoPortalTestContextTest>()
            .UseInMemoryDatabase("VideoPortalContext")
            .Options;
        VideoPortalTestContextTest testContext = new(contextOptions);
        DbSet<Comment> set = testContext.Set<Comment>();
        var property = set.EntityType.FindProperty(keyName);
        property.IsForeignKey().Should().BeTrue();
    }

    [Trait("Category", "1 - Implemente os Models da aplicação")]
    [Theory(DisplayName = "Comment deve conter as propriedades e tipos corretos")]
    [InlineData("CommentId", typeof(int))]
    [InlineData("CommentText", typeof(string))]
    [InlineData("VideoId", typeof(int))]
    [InlineData("UserId", typeof(int))]
    public void CommentShouldContainProperties(string propertyName, Type propertyType)
    {
        var propertyToCheck = typeof(Comment).GetProperty(propertyName);
        propertyToCheck.Should().NotBeNull();
        var propertyTypeName = propertyToCheck.PropertyType;
        propertyTypeName.Should().BeAssignableTo(propertyType);
    }


    [Trait("Category", "1 - Implemente os Models da aplicação")]
    [Theory(DisplayName = "User deve conter chave primária")]
    [InlineData("UserId")]
    public void UserShouldContainProperPrimaryKey(string keyName)
    {
        var contextOptions = new DbContextOptionsBuilder<VideoPortalTestContextTest>()
            .UseInMemoryDatabase("VideoPortalContext")
            .Options;
        VideoPortalTestContextTest testContext = new(contextOptions);
        DbSet<User> set = testContext.Set<User>();
        var property = set.EntityType.FindProperty(keyName);
        property.IsKey().Should().BeTrue();
    }

    [Trait("Category", "1 - Implemente os Models da aplicação")]
    [Theory(DisplayName = "User deve conter as propriedades e tipos corretos")]
    [InlineData("UserId", typeof(int))]
    [InlineData("Username", typeof(string))]
    [InlineData("Email", typeof(string))]
    [InlineData("Channels", typeof(IEnumerable<Channel>))]
    [InlineData("Comments", typeof(IEnumerable<Comment>))]
    public void UserShouldContainProperties(string propertyName, Type propertyType)
    {
        var propertyToCheck = typeof(User).GetProperty(propertyName);
        propertyToCheck.Should().NotBeNull();
        var propertyTypeName = propertyToCheck.PropertyType;
        propertyTypeName.Should().BeAssignableTo(propertyType);
    }


    [Trait("Category", "1 - Implemente os Models da aplicação")]
    [Theory(DisplayName = "Video deve conter chave primária")]
    [InlineData("VideoId")]
    public void VideoShouldContainProperPrimaryKey(string keyName)
    {
        var contextOptions = new DbContextOptionsBuilder<VideoPortalTestContextTest>()
            .UseInMemoryDatabase("VideoPortalContext")
            .Options;
        VideoPortalTestContextTest testContext = new(contextOptions);
        DbSet<Video> set = testContext.Set<Video>();
        var property = set.EntityType.FindProperty(keyName);
        property.IsKey().Should().BeTrue();
    }

    [Trait("Category", "1 - Implemente os Models da aplicação")]
    [Theory(DisplayName = "Video deve conter chave estrangeira")]
    [InlineData("ChannelId")]
    public void VideoShouldContainProperForeignKeys(string keyName)
    {
        var contextOptions = new DbContextOptionsBuilder<VideoPortalTestContextTest>()
            .UseInMemoryDatabase("VideoPortalContext")
            .Options;
        VideoPortalTestContextTest testContext = new(contextOptions);
        DbSet<Video> set = testContext.Set<Video>();
        var property = set.EntityType.FindProperty(keyName);
        property.IsForeignKey().Should().BeTrue();
    }

    [Trait("Category", "1 - Implemente os Models da aplicação")]
    [Theory(DisplayName = "Video deve conter as propriedades e tipos corretos")]
    [InlineData("VideoId", typeof(int))]
    [InlineData("Title", typeof(string))]
    [InlineData("Description", typeof(string))]
    [InlineData("Description", typeof(string))]
    [InlineData("Url", typeof(string))]
    [InlineData("Comments", typeof(IEnumerable<Comment>))]
    public void VideoShouldContainProperties(string propertyName, Type propertyType)
    {
        var propertyToCheck = typeof(Video).GetProperty(propertyName);
        propertyToCheck.Should().NotBeNull();
        var propertyTypeName = propertyToCheck.PropertyType;
        propertyTypeName.Should().BeAssignableTo(propertyType);
    }
}
