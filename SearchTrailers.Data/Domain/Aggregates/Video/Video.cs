using SearchTrailers.Data.Domain.Shared;

namespace SearchTrailers.Data.Domain.Aggregates.Video;

public class Video : Entity<VideoId>, IAggregateRoot
{
    public Video( VideoId videoId, string title, string description, string channelTitle, string link)
    {
        this.title = title;
        this.videoId = videoId;
        this.description = description;
        this.channelTitle = channelTitle;
        this.link = link;
    }

    public string title { get; set; }
    public VideoId videoId { get; set; }
    
    public string description { get; set; }
    
    public string channelTitle { get; set; }

    public string link { get; set; }

    public string getTitle()
    {
        return string.Copy(title);
    }
}