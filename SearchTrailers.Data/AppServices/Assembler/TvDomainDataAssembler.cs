using SearchTrailers.Data.Domain.Aggregates.TvShow;

namespace SearchTrailers.Services.TheMovieDBAPI_Services;

public class TvDomainDataAssembler
{
    public TvShow toDomain(TMDbLib.Objects.Search.SearchTv tvShow)
    {
        TvShowId newTvShowID = new TvShowId(tvShow.Id);
        TvShow tvShowDomain = new TvShow(newTvShowID, tvShow.Name, tvShow.OriginalName);

        return tvShowDomain;
    }
}