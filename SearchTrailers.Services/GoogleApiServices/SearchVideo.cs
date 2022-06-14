using Google.Apis.Services;
using Google.Apis.Util;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace SearchTrailers.Services.GoogleApiServices;

public class SearchVideo
{
    

    public async Task<YouTubeVideoDetails> getVideo(string title)
    {
        
        var youtubeService = new YouTubeService(new BaseClientService.Initializer
        {
            ApiKey = "AIzaSyCavKmUGv-85-KRwLw7y2iE1ELSW_9yKrg",
            ApplicationName = GetType().ToString()
        });

        var searchRequest = youtubeService.Search.List("snippet");
        searchRequest.Q = title + "official trailer"; // Replace with your search term.
        searchRequest.MaxResults = 1;

        // Call the search.list method to retrieve results matching the specified query term.
        var searchResponse = await searchRequest.ExecuteAsync();

        var youTubeVideo = searchResponse.Items.FirstOrDefault();
        YouTubeVideoDetails video = new YouTubeVideoDetails();

        if(youTubeVideo!=null) {
            
                video.VideoId = youTubeVideo.Snippet.ChannelId;
                video.Description = youTubeVideo.Snippet.Description;
                video.Title = youTubeVideo.Snippet.Title;
                video.ChannelTitle = youTubeVideo.Snippet.ChannelTitle;
                video.Link = searchRequest.HttpMethod;
        }
        else
        {
            video.ThrowIfNull("Video Not Found");
        }

        return video;
    }
    public class YouTubeVideoDetails
    {
        public string VideoId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string ChannelTitle { get; set; }
        public String Link { get; set; }
    }
}