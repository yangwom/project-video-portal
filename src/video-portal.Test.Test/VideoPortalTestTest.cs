using video_portal.Models;
namespace video_portal.Test.Test;

[Collection("sequential")]
public class VideoPortalTestTestVideoList
{
    [Trait("Category", "4 - Teste a listagem de vídeo")]
    [Theory(DisplayName = "ShouldReturnAVideoList deve ser executado com sucesso com o input de sucesso")]
    [MemberData(nameof(ShouldReturnAVideoListData))]
    public async Task ShouldReturnAVideoList(List<Video> videosExpected, bool isCorrect)
    {
        VideoPortalTest instance = TestHelpers.GetIntegrationTestInstance("ShouldReturnAVideoList");
        Func<Task> task = async () => await instance.ShouldReturnAVideoList(videosExpected);
        if (isCorrect)
        {
            await task.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
        }
        else
        {
            await task.Should().ThrowAsync<Xunit.Sdk.XunitException>();
        }
        await task.Should().NotThrowAsync<NotImplementedException>();
    }

    public static readonly TheoryData<List<Video>, bool> ShouldReturnAVideoListData = new()
    {
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
            },
            true
        },
        {
            new()
            {
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
                }
            },
            false
        }
    };
}

[Collection("sequential")]
public class VideoPortalTestTestChannelList
{
    [Trait("Category", "5 - Teste a listagem do canal")]
    [Theory(DisplayName = "ShouldReturnAChannelWithVideos deve ser executado com sucesso com o input de sucesso")]
    [MemberData(nameof(ShouldReturnVideosFromChannelData))]
    public async Task TestShouldReturnAChannelWithVideos(Channel channelEntry, List<Video> expectedVideos, bool isCorrect)
    {
        VideoPortalTest instance = TestHelpers.GetIntegrationTestInstance("TestShouldReturnAChannelWithVideos");
        Func<Task> task = async () => await instance.ShouldReturnAChannelWithVideos(channelEntry, expectedVideos);
        if (isCorrect)
        {
            await task.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
        }
        else
        {
            await task.Should().ThrowAsync<Xunit.Sdk.XunitException>();
        }
        await task.Should().NotThrowAsync<NotImplementedException>();
    }

    public static readonly TheoryData<Channel, List<Video>, bool> ShouldReturnVideosFromChannelData = new()
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
            },
            true
        },
        {
            new Channel { ChannelId = 3, ChannelName = "Channel With multiple videos", ChannelDescription = "Test", Url = "Test" },
            new List<Video>() {
                new Video {
                    VideoId = 4,
                    Title = "Video 4",
                    Url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",
                    ChannelId = 3
                }
            },
            false
        }
    };
}
