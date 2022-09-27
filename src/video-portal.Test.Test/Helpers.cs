using Microsoft.EntityFrameworkCore;
using video_portal.Models;
using video_portal.Repository;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace video_portal.Test.Test
{
    public static class TestHelpers
    {
        public static VideoPortalContext GetContextInstanceForTests(string inMemoryDbName)
        {
            var contextOptions = new DbContextOptionsBuilder<VideoPortalContext>()
                .UseInMemoryDatabase(inMemoryDbName)
                .Options;
            var context = new VideoPortalContext(contextOptions);
            context.Channels.AddRange(
                GetChannelListForTests()
            );
            context.Videos.AddRange(
                GetVideoListForTests()
            );
            context.Users.Add(new User { UserId = 1, Username = "Test", Email = "Test" });
            context.Comments.AddRange(
                GetCommentListForTests()
            );
            context.SaveChanges();
            return context;
        }

        public static List<Comment> GetCommentListForTests() =>
            new() {
                new Comment{
                    CommentId = 1,
                    CommentText = "Comment 1",
                    VideoId = 1,
                    UserId = 1
                },
                new Comment
                {
                    CommentId = 2,
                    CommentText = "Comment 2",
                    VideoId = 1,
                    UserId = 1
                }
            };

        public static List<Video> GetVideoListForTests() =>
            new() {
                new Video {
                    VideoId = 1,
                    Title = "Video 1",
                    ChannelId = 1,
                    Description = "Test",
                    Url = "Test"
                },
                new Video {
                    VideoId = 2,
                    Title = "Video Without Channel",
                    Description = "Test",
                    Url = "Test"
                },
                new Video {
                    VideoId = 3,
                    Title = "Video 3",
                    Url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",
                    ChannelId = 3
                },
                new Video {
                    VideoId = 4,
                    Title = "Video 4",
                    Url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",
                    ChannelId = 3
                }
            };

        public static List<Channel> GetChannelListForTests() =>
            new() {
                new Channel { ChannelId = 1, ChannelName = "Channel With Videos", ChannelDescription = "Test", Url = "Test" },
                new Channel { ChannelId = 2, ChannelName = "Channel Without Videos", ChannelDescription = "Test", Url = "Test" },
                new Channel { ChannelId = 3, ChannelName = "Channel With multiple videos", ChannelDescription = "Test", Url = "Test" }
            };

        public static VideoPortalTest GetIntegrationTestInstance(string inMemoryDbName)
        {
            var factory = new WebApplicationFactory<Program>();
            VideoPortalTest instance = new(factory);
            instance.client = factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<VideoPortalContext>));
                    if (descriptor != null)
                    {
                        services.Remove(descriptor);
                    }
                    services.AddDbContext<VideoPortalTestContextTest>(options =>
                    {
                        options.UseInMemoryDatabase(inMemoryDbName);
                    });
                    services.AddScoped<IVideoPortalContext, VideoPortalTestContextTest>();
                    services.AddScoped<IVideoPortalRepository, VideoPortalRepository>();
                    var sp = services.BuildServiceProvider();
                    using (var scope = sp.CreateScope())
                    using (var appContext = scope.ServiceProvider.GetRequiredService<VideoPortalTestContextTest>())
                    {
                        appContext.Database.EnsureCreated();
                        appContext.Database.EnsureDeleted();
                        appContext.Database.EnsureCreated();
                        appContext.Channels.AddRange(
                            GetChannelListForTests()
                        );
                        appContext.Videos.AddRange(
                            GetVideoListForTests()
                        );
                        appContext.Users.Add(new User { UserId = 1, Username = "Test", Email = "Test" });
                        appContext.Comments.AddRange(
                            GetCommentListForTests()
                        );
                        appContext.SaveChanges();
                    }
                });
            }).CreateClient();

            return instance;
        }
    }
}