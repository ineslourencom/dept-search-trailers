using System;
using SearchTrailers.Data.Domain.Shared;

namespace SearchTrailers.Data.Domain.Aggregates.TvShow;

public class TvShow : Entity<TvShowId>, IAggregateRoot
{
    private TvShowId Id { get;  }
    private string? Title { get; }

    private string? OriginalTitle { get; }

    public TvShow(TvShowId id, string title, string originalName)
    {
        Id = id;
        Title = title;
        OriginalTitle = originalName;
    }


    public string getTitle()
    {
        return String.Copy(this.Title);
    }
    
}