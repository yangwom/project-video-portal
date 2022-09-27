using video_portal.Models;
using video_portal.Repository;
using video_portal.Test;

namespace video_portal.Test.Test
{
    public class TestTestRepository
    {
        [Trait("Category", "3 - Implemente o repositório")]
        [Theory(DisplayName = "Deve implementar o teste ShouldGetVideoById corretamente")]
        [MemberData(nameof(ShouldGetVideoByIdData))]
        public void ShouldGetVideoByIdTest(VideoPortalContext context, int videoId, Video videoExpected, bool isCorrect)
        {
            var instance = new VideoPortalRepositoryTest();
            Action act = () => instance.ShouldGetVideoById(context, videoId, videoExpected);
            if (isCorrect)
            {
                act.Should().NotThrow<Xunit.Sdk.XunitException>();
            }
            else
            {
                act.Should().Throw<Xunit.Sdk.XunitException>();
            }

            act.Should().NotThrow<NotImplementedException>();
        }
        public readonly static TheoryData<VideoPortalContext, int, Video, bool> ShouldGetVideoByIdData =
          new()
          {
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetVideoById1"),
          1,
          new Video {
              VideoId = 1,
              Title = "Video 1",
              ChannelId = 1,
              Description = "Test",
              Url = "Test"
          },
          true
        },
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetVideoById2"),
          2,
          new Video {
              VideoId = 1,
              Title = "Video 1",
              ChannelId = 1,
              Description = "Test",
              Url = "Test"
          },
          false
        },
          };

        [Trait("Category", "3 - Implemente o repositório")]
        [Theory(DisplayName = "Deve implementar o teste ShouldGetVideos corretamente")]
        [MemberData(nameof(ShouldGetVideosData))]
        public void ShouldGetVideosTest(VideoPortalContext context, int[] videoIdsExpected, bool isCorrect)
        {
            var instance = new VideoPortalRepositoryTest();
            Action act = () => instance.ShouldGetVideos(context, videoIdsExpected);
            if (isCorrect)
            {
                act.Should().NotThrow<Xunit.Sdk.XunitException>();
            }
            else
            {
                act.Should().Throw<Xunit.Sdk.XunitException>();
            }

            act.Should().NotThrow<NotImplementedException>();
        }
        public readonly static TheoryData<VideoPortalContext, int[], bool> ShouldGetVideosData =
          new()
          {
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetVideos1"),
          new int[] { 1, 2, 3, 4 },
          true
        },
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetVideos2"),
          new int[] { 1, 3, 4 },
          false
        },
          };

        [Trait("Category", "3 - Implemente o repositório")]
        [Theory(DisplayName = "Deve implementar o teste ShouldGetChannelById corretamente")]
        [MemberData(nameof(ShouldGetChannelByIdData))]
        public void ShouldGetChannelByIdTest(VideoPortalContext context, int channelId, Channel channelExpected, bool isCorrect)
        {
            var instance = new VideoPortalRepositoryTest();
            Action act = () => instance.ShouldGetChannelById(context, channelId, channelExpected);
            if (isCorrect)
            {
                act.Should().NotThrow<Xunit.Sdk.XunitException>();
            }
            else
            {
                act.Should().Throw<Xunit.Sdk.XunitException>();
            }

            act.Should().NotThrow<NotImplementedException>();
        }
        public readonly static TheoryData<VideoPortalContext, int, Channel, bool> ShouldGetChannelByIdData =
          new()
          {
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetChannelById1"),
          1,
          new Channel { ChannelId = 1, ChannelName = "Channel With Videos", ChannelDescription = "Test", Url = "Test" },
          true
        },
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetChannelById2"),
          2,
          new Channel { ChannelId = 1, ChannelName = "Channel With Videos", ChannelDescription = "Test", Url = "Test" },
          false
        },
          };

        [Trait("Category", "3 - Implemente o repositório")]
        [Theory(DisplayName = "Deve implementar o teste ShouldGetChannels corretamente")]
        [MemberData(nameof(ShouldGetChannelsData))]
        public void ShouldGetChannelsTest(VideoPortalContext context, int[] channelIdsExpected, bool isCorrect)
        {
            var instance = new VideoPortalRepositoryTest();
            Action act = () => instance.ShouldGetChannels(context, channelIdsExpected);
            if (isCorrect)
            {
                act.Should().NotThrow<Xunit.Sdk.XunitException>();
            }
            else
            {
                act.Should().Throw<Xunit.Sdk.XunitException>();
            }

            act.Should().NotThrow<NotImplementedException>();
        }
        public readonly static TheoryData<VideoPortalContext, int[], bool> ShouldGetChannelsData =
          new()
          {
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetChannels1"),
          new int[] { 1, 2, 3 },
          true
        },
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetChannels2"),
          new int[] { 2, 3 },
          false
        }
          };

        [Trait("Category", "3 - Implemente o repositório")]
        [Theory(DisplayName = "Deve implementar o teste ShouldGetVideosByChannelId corretamente")]
        [MemberData(nameof(ShouldGetVideosByChannelIdData))]
        public void ShouldGetVideosByChannelIdTest(VideoPortalContext context, int channelId, int[] expectedVideosIds, bool isCorrect)
        {
            var instance = new VideoPortalRepositoryTest();
            Action act = () => instance.ShouldGetVideosByChannelId(context, channelId, expectedVideosIds);
            if (isCorrect)
            {
                act.Should().NotThrow<Xunit.Sdk.XunitException>();
            }
            else
            {
                act.Should().Throw<Xunit.Sdk.XunitException>();
            }

            act.Should().NotThrow<NotImplementedException>();
        }
        public readonly static TheoryData<VideoPortalContext, int, int[], bool> ShouldGetVideosByChannelIdData =
          new()
          {
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetVideosByChannelId1"),
          3,
          new int[] { 3, 4 },
          true
        },
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetVideosByChannelId2"),
          3,
          new int[] { 4 },
          false
        }
          };

        [Trait("Category", "3 - Implemente o repositório")]
        [Theory(DisplayName = "Deve implementar o teste ShouldGetCommentsByVideoId corretamente")]
        [MemberData(nameof(ShouldGetCommentsByVideoIdData))]
        public void ShouldGetCommentsByVideoIdTest(VideoPortalContext context, int videoId, int[] expectedCommentIds, bool isCorrect)
        {
            var instance = new VideoPortalRepositoryTest();
            Action act = () => instance.ShouldGetCommentsByVideoId(context, videoId, expectedCommentIds);
            if (isCorrect)
            {
                act.Should().NotThrow<Xunit.Sdk.XunitException>();
            }
            else
            {
                act.Should().Throw<Xunit.Sdk.XunitException>();
            }

            act.Should().NotThrow<NotImplementedException>();
        }
        public readonly static TheoryData<VideoPortalContext, int, int[], bool> ShouldGetCommentsByVideoIdData =
          new()
          {
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetCommentsByVideoId1"),
          1,
          new int[] { 1, 2 },
          true
        },
        {
          TestHelpers.GetContextInstanceForTests("ShouldGetCommentsByVideoId2"),
          1,
          new int[] { 2 },
          false
        }
          };

        [Trait("Category", "3 - Implemente o repositório")]
        [Theory(DisplayName = "Deve implementar o teste ShouldDeleteChannel corretamente")]
        [MemberData(nameof(ShouldDeleteChannelData))]
        public void ShouldDeleteChannelTest(VideoPortalContext context, Channel channel, int[] expectedChannels, bool isCorrect)
        {
            var instance = new VideoPortalRepositoryTest();
            Action act = () => instance.ShouldDeleteChannel(context, channel, expectedChannels);
            if (isCorrect)
            {
                act.Should().NotThrow<Xunit.Sdk.XunitException>();
            }
            else
            {
                act.Should().Throw<Xunit.Sdk.XunitException>();
            }

            act.Should().NotThrow<NotImplementedException>();
        }
        public readonly static TheoryData<VideoPortalContext, Channel, int[], bool> ShouldDeleteChannelData = new()
    {
      {
        TestHelpers.GetContextInstanceForTests("ShouldDeleteChannel1"),
        new Channel { ChannelId = 2, ChannelName = "Channel Without Videos", ChannelDescription = "Test", Url = "Test" },
        new int[] { 1, 3 },
        true
      },
      {
        TestHelpers.GetContextInstanceForTests("ShouldDeleteChannel2"),
        new Channel { ChannelId = 2, ChannelName = "Channel Without Videos", ChannelDescription = "Test", Url = "Test" },
        new int[] { 1, 2 },
        false
      }
    };

        [Trait("Category", "3 - Implemente o repositório")]
        [Theory(DisplayName = "Deve implementar o teste ShouldAddVideoToChannel corretamente")]
        [MemberData(nameof(ShouldAddVideoToChannelData))]
        public void ShouldAddVideoToChannelTest(VideoPortalContext context, Video videoToAdd, Channel channel, Video expectedVideo, bool isCorrect)
        {
            var instance = new VideoPortalRepositoryTest();
            Action act = () => instance.ShouldAddVideoToChannel(context, videoToAdd, channel, expectedVideo);
            if (isCorrect)
            {
                act.Should().NotThrow<Xunit.Sdk.XunitException>();
            }
            else
            {
                act.Should().Throw<Xunit.Sdk.XunitException>();
            }

            act.Should().NotThrow<NotImplementedException>();
        }
        public readonly static TheoryData<VideoPortalContext, Video, Channel, Video, bool> ShouldAddVideoToChannelData = new()
    {
      {
        video_portal.Test.Helpers.GetContextInstanceForTests("ShouldAddVideoToChannel1"),
        new Video{ VideoId = 2, Title = "Video 2", Description = "Test", Url = "Test" },
        new Channel{ ChannelId = 1, ChannelName = "Channel 1", ChannelDescription = "Test", Url = "Test" },
        new Video{ VideoId = 2, Title = "Video 2", Description = "Test", Url = "Test", ChannelId = 1 },
        true
      },
      {
        video_portal.Test.Helpers.GetContextInstanceForTests("ShouldAddVideoToChannel2"),
        new Video{ VideoId = 2, Title = "Video 2", Description = "Test", Url = "Test" },
        new Channel{ ChannelId = 1, ChannelName = "Channel 1", ChannelDescription = "Test", Url = "Test" },
        new Video{ VideoId = 2, Title = "Video 2", Description = "Test", Url = "Test", ChannelId = 3 },
        false
      }
    };
    }
}
