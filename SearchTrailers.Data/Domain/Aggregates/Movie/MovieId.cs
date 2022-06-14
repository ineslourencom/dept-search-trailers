using SearchTrailers.Data.Domain.Shared;

namespace SearchTrailers.Data.Domain.Aggregates.Movie;

public class MovieId : EntityId
{
    public MovieId(int movieId)
    {
        Movie_id = movieId;
    }

    private int Movie_id { get; }


    protected override string AsString()
    {
        return Value;
    }
}