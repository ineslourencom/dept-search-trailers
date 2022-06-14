using SearchTrailers.Data.Domain.Shared;

namespace SearchTrailers.Data.Domain.Aggregates.TvShow;

public class TvShowId : EntityId
{
    private int Serie_id { get; }


    public TvShowId(int id)
    {
        Serie_id = id;
    }

    protected override string AsString()
    {
        return Value;
    }
}