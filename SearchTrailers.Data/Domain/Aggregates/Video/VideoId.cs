using SearchTrailers.Data.Domain.Shared;

namespace SearchTrailers.Data.Domain.Aggregates.Video;

public class VideoId : EntityId
{
    public VideoId(string videoid)
    {
        videoId = videoid;
    }

    public string videoId { get; set; }

    protected override string AsString()
    {
        return Value;
    }
}