using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using video_portal.Repository;
using video_portal.Models;
using Microsoft.Extensions.DependencyInjection;
namespace video_portal.Test;

public class VideoPortalTest : IClassFixture<WebApplicationFactory<Program>>
{
    public HttpClient client;

    public VideoPortalTest(WebApplicationFactory<Program> factory)
    {
        client = factory.WithWebHostBuilder(builder =>
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<VideoPortalContext>));
                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }
                services.AddDbContext<VideoPortalTestContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryTest");
                });
                services.AddScoped<IVideoPortalContext, VideoPortalTestContext>();
                services.AddScoped<IVideoPortalRepository, VideoPortalRepository>();
                var sp = services.BuildServiceProvider();
                using (var scope = sp.CreateScope())
                using (var appContext = scope.ServiceProvider.GetRequiredService<VideoPortalTestContext>())
                {
                    appContext.Database.EnsureCreated();
                    appContext.Database.EnsureDeleted();
                    appContext.Database.EnsureCreated();
                    appContext.Channels.AddRange(
                        Helpers.GetChannelListForTests()
                    );
                    appContext.Videos.AddRange(
                        Helpers.GetVideoListForTests()
                    );
                    appContext.Users.Add(new User { UserId = 1, Username = "Test", Email = "Test" });
                    appContext.Comments.AddRange(
                        Helpers.GetCommentListForTests()
                    );
                    appContext.SaveChanges();
                }
            });
        }).CreateClient();
    }

    [Theory(DisplayName = "GET api/video Deve retornar uma lista de vídeos")]
    [MemberData(nameof(ShouldReturnAVideoListData))]
    public async Task ShouldReturnAVideoList(List<Video> videosExpected)
    {
        var response = 
        await client.GetAsync("/api/video");
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<Video>>(json);
        result.Should().BeEquivalentTo(videosExpected);
    }

    public static readonly TheoryData<List<Video>> ShouldReturnAVideoListData = new()
    {
        new()
        {
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
        }
    };

    [Theory(DisplayName = "GET channel/{id}/video Deve retornar os videos do canal")]
    [MemberData(nameof(ShouldReturnVideosFromChannelData))]
    public async Task ShouldReturnAChannelWithVideos(Channel channelEntry, List<Video> expectedVideos)
    {
        var response =  await client.GetAsync($"/api/channel/{channelEntry.ChannelId}/video");
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<Video>>(json);
        result.Should().BeEquivalentTo(expectedVideos);
    }

    public static readonly TheoryData<Channel, List<Video>> ShouldReturnVideosFromChannelData = new()
    {
        {
            new Channel { ChannelId = 3, ChannelName = "Channel With multiple videos", ChannelDescription = "Test", Url = "Test" },
            new List<Video>() {
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
            }
        }
    };
}