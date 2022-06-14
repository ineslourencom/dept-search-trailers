using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.TvShows;

namespace SearchTrailers.Services.TheMovieDBAPI_Services;

public class SearchSeries
{
    public static SearchTv getTvShowByName(string name)
    {
        TMDbClient client = new TMDbClient("e3ee20ffae9a754919178f512fddaf30");

        SearchContainer<SearchTv> allTvShow = client.SearchTvShowAsync(name).Result;

        List<SearchTv> list = allTvShow.Results;

        SearchTv tvToStore = new SearchTv();
        foreach (SearchTv searchTv in list)
        {
            if (searchTv.Name.Equals(name))
            {
                tvToStore = searchTv;
            }
        }
        
        return tvToStore;
    }
    
    
    public TvShow getTvShowById(int id)
    {
        TMDbClient client = new TMDbClient("e3ee20ffae9a754919178f512fddaf30");

        TvShow tvShow = client.GetTvShowAsync(id).Result;

        return tvShow;
    }
}