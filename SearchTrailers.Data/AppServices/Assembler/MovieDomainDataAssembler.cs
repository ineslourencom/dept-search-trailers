using SearchTrailers.Data.Domain.Aggregates.Movie;


namespace SearchTrailers.Services.TheMovieDBAPI_Services;

public class MovieDomainDataAssembler
{
    public Movie toDomain(TMDbLib.Objects.Movies.Movie movie)
    {
        MovieId newMovieID = new MovieId(movie.Id);
        Movie movieDomain = new Movie(newMovieID, movie.OriginalTitle, movie.Title);

        return movieDomain;
    }
}