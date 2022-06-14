using System.Collections.Generic;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using SearchTrailers.Data.AppServices.Assembler;
using SearchTrailers.Data.Domain.Aggregates.Movie;
using SearchTrailers.Data.Domain.Aggregates.TvShow;
using SearchTrailers.Data.Domain.Aggregates.Video;
using SearchTrailers.Data.DTO;
using SearchTrailers.Services.GoogleApiServices;
using SearchTrailers.Services.TheMovieDBAPI_Services;


namespace SearchTrailers.Data.AppServices;

public class AppServiceSearchTrailers : IAppServiceSearchTrailers
{
    private MovieDomainDataAssembler _assembler = new MovieDomainDataAssembler();
    private TvDomainDataAssembler _tvDomainDataAssembler = new TvDomainDataAssembler();
    private VideoDomainDataAssembler _videoDomainDataAssembler = new VideoDomainDataAssembler();
    
    public AnswerDTO getYoutubeVideo(string title)
    {
        Movie movie = _assembler.toDomain(SearchTrailers.Services.TheMovieDBAPI_Services.SearchMovies.getMovieByName(title));
        string titleToBeUsed = new string("");   
        
        if (movie != null)
        { titleToBeUsed = movie.getTitle();

        }
        else
        {
            TvShow tvShow =
                _tvDomainDataAssembler.toDomain(SearchTrailers.Services.TheMovieDBAPI_Services.SearchSeries
                    .getTvShowByName(title));
            titleToBeUsed = tvShow.getTitle();

        }

        SearchVideo _instance = new SearchVideo();
        
        
        Video video =
            _videoDomainDataAssembler.toDomain(_instance.getVideo(titleToBeUsed).Result);


        return AnswerMapper.toDTO(video);
    }
}