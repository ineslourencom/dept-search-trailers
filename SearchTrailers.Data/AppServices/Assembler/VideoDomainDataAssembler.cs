using SearchTrailers.Services.GoogleApiServices;
using VideoDomain = SearchTrailers.Data.Domain.Aggregates.Video.Video;
using VideoId = SearchTrailers.Data.Domain.Aggregates.Video.VideoId;

using Video = Google.Apis.YouTube.v3.Data.Video;

namespace SearchTrailers.Data.AppServices.Assembler;

public class VideoDomainDataAssembler
{
    public SearchTrailers.Data.Domain.Aggregates.Video.Video toDomain(SearchVideo.YouTubeVideoDetails video)
    {
        
            VideoId videoID = new VideoId(video.VideoId);

            VideoDomain youtubeVideo =
                new VideoDomain(videoID, video.Title, video.Description, video.ChannelTitle, video.Link);

        
        return youtubeVideo;
    }
}