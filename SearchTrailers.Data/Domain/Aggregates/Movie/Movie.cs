using SearchTrailers.Data.Domain.Shared;

namespace SearchTrailers.Data.Domain.Aggregates.Movie;

public class Movie : Entity<MovieId>, IAggregateRoot
{
    
    private MovieId Id { get; }
    private string? OriginalTitle { get; }
    private string? Title { get; }
    
    public Movie( MovieId id, string originalTitle,
        string title)
    {
        
        Id = id;
        OriginalTitle = originalTitle;
        Title = title;
    }
    


    public string getTitle()
    {
        return string.Copy(Title);
    }

    public bool hasId(MovieId id)
    {
        return Id.Equals(id);
    }


    //see later how to implement obj inside lists


    // { for genres
    //  "id": 18,
    //  "name": "Drama"
    // }


    //"production_companies": [
    //  {
    //    "id": 508,
    //    "logo_path": "/7PzJdsLGlR7oW4J0J5Xcd0pHGRg.png",
    //    "name": "Regency Enterprises",
    //    "origin_country": "US"
    //  },
    //  {
    //  "id": 711,
    //    "logo_path": null,
    //    "name": "Fox 2000 Pictures",
    //    "origin_country": ""
    //  },
    //  {
    //  "id": 20555,
    //    "logo_path": null,
    //    "name": "Taurus Film",
    //    "origin_country": ""
    //  },
    //  {
    //  "id": 54050,
    //    "logo_path": null,
    //    "name": "Linson Films",
    //    "origin_country": ""
    //  },
    //  {
    //  "id": 54051,
    //    "logo_path": null,
    //    "name": "Atman Entertainment",
    //    "origin_country": ""
    //  },
    //  {
    //  "id": 54052,
    //    "logo_path": null,
    //    "name": "Knickerbocker Films",
    //    "origin_country": ""
    //  },
    //  {
    //  "id": 25,
    //    "logo_path": "/qZCc1lty5FzX30aOCVRBLzaVmcp.png",
    //    "name": "20th Century Fox",
    //    "origin_country": "US"
    //  }


    //"production_countries": [
    //  {
    //    "iso_3166_1": "US",
    //    "name": "United States of America"
    //  }
    //],


    //"spoken_languages": [
    //  {
    //    "iso_639_1": "en",
    //    "name": "English"
    //  }
    //],
}