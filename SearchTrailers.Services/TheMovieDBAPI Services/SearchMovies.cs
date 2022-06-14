using Google.Apis.Util;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;

namespace SearchTrailers.Services.TheMovieDBAPI_Services;

public class SearchMovies
{
    public static Movie getMovieByName(string name)
    {

        TMDbClient client = new TMDbClient("e3ee20ffae9a754919178f512fddaf30");

        Movie movie = client.GetMovieAsync(name).Result;

        return movie;
    }
    
        
}