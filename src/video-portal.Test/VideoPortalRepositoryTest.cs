using Microsoft.EntityFrameworkCore;
using video_portal.Models;
using video_portal.Repository;

namespace video_portal.Test;

public class VideoPortalRepositoryTest
{
    [Theory]
    [MemberData(nameof(ShouldGetVideoByIdData))]
    public void ShouldGetVideoById(VideoPortalContext context, int videoId, Video videoExpected)
    {
        throw new NotImplementedException();
    }
    public readonly static TheoryData<VideoPortalContext, int, Video> ShouldGetVideoByIdData =
      new()
      {
      {
        Helpers.GetContextInstanceForTests("ShouldGetVideoById"),
        1,
        new Video {
            VideoId = 1,
            Title = "Video 1",
            ChannelId = 1,
            Description = "Test",
            Url = "Test"
        }
      },
      };


    [Theory]
    [MemberData(nameof(ShouldGetVideosData))]
    public void ShouldGetVideos(VideoPortalContext context, int[] videoIdsExpected)
    {
        throw new NotImplementedException();
    }
    public readonly static TheoryData<VideoPortalContext, int[]> ShouldGetVideosData =
      new()
      {
      {
        Helpers.GetContextInstanceForTests("ShouldGetVideos"),
        new int[] { 1, 2, 3, 4 }
      }
      };

    [Theory]
    [MemberData(nameof(ShouldGetChannelByIdData))]
    public void ShouldGetChannelById(VideoPortalContext context, int channelId, Channel channelExpected)
    {
        throw new NotImplementedException();
    }
    public readonly static TheoryData<VideoPortalContext, int, Channel> ShouldGetChannelByIdData =
      new()
      {
      {
        Helpers.GetContextInstanceForTests("ShouldGetChannelById"),
        1,
        new Channel { ChannelId = 1, ChannelName = "Channel With Videos", ChannelDescription = "Test", Url = "Test" }
      },
      };


    [Theory]
    [MemberData(nameof(ShouldGetChannelsData))]
    public void ShouldGetChannels(VideoPortalContext context, int[] channelIdsExpected)
    {
        throw new NotImplementedException();
    }
    public readonly static TheoryData<VideoPortalContext, int[]> ShouldGetChannelsData =
      new()
      {
      {
        Helpers.GetContextInstanceForTests("ShouldGetChannels"),
        new int[] { 1, 2, 3 }
      }
      };

    [Theory]
    [MemberData(nameof(ShouldGetVideosByChannelIdData))]
    public void ShouldGetVideosByChannelId(VideoPortalContext context, int channelId, int[] expectedVideosIds)
    {
        throw new NotImplementedException();
    }
    public readonly static TheoryData<VideoPortalContext, int, int[]> ShouldGetVideosByChannelIdData =
      new()
      {
      {
        Helpers.GetContextInstanceForTests("ShouldGetVideosByChannelId"),
        3,
        new int[] { 3, 4 }
      }
      };

    [Theory]
    [MemberData(nameof(ShouldGetCommentsByVideoIdData))]
    public void ShouldGetCommentsByVideoId(VideoPortalContext context, int videoId, int[] expectedCommentIds)
    {
        throw new NotImplementedException();
    }
    public readonly static TheoryData<VideoPortalContext, int, int[]> ShouldGetCommentsByVideoIdData =
      new()
      {
      {
        Helpers.GetContextInstanceForTests("ShouldGetCommentsByVideoId"),
        1,
        new int[] { 1, 2 }
      }
      };
    [Theory]
    [MemberData(nameof(ShouldDeleteChannelData))]
    public void ShouldDeleteChannel(VideoPortalContext context, Channel channel, int[] expectedChannels)
    {
        throw new NotImplementedException();
    }
    public readonly static TheoryData<VideoPortalContext, Channel, int[]> ShouldDeleteChannelData = new()
  {
    {
      Helpers.GetContextInstanceForTests("ShouldDeleteChannel"),
      new Channel { ChannelId = 2, ChannelName = "Channel Without Videos", ChannelDescription = "Test", Url = "Test" },
      new int[] { 1, 3 }
    }
  };

    [Theory]
    [MemberData(nameof(ShouldAddVideoToChannelData))]
    public void ShouldAddVideoToChannel(VideoPortalContext context, Video videoToAdd, Channel channel, Video expectedVideo)
    {
        // Arrange
        var repository = new VideoPortalRepository(context);

        // Act
        repository.AddVideoToChannel(channel, videoToAdd);

        // Assert
        var actual = context.Videos.FirstOrDefault(v => v.VideoId == videoToAdd.VideoId);
        actual.ChannelId.Should().Be(expectedVideo.ChannelId);
    }
    public readonly static TheoryData<VideoPortalContext, Video, Channel, Video> ShouldAddVideoToChannelData = new()
  {
    {
      Helpers.GetContextInstanceForTests("ShouldAddVideoToChannel"),
      new Video{ VideoId = 2, Title = "Video 2", Description = "Test", Url = "Test" },
      new Channel{ ChannelId = 1, ChannelName = "Channel 1", ChannelDescription = "Test", Url = "Test" },
      new Video{ VideoId = 2, Title = "Video 2", Description = "Test", Url = "Test", ChannelId = 1 }
    }
  };
};
