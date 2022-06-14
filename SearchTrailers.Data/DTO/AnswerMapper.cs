using SearchTrailers.Data.Domain.Aggregates.Video;

namespace SearchTrailers.Data.DTO;

public class AnswerMapper
{
    public static AnswerDTO toDTO(Video video)
    {
        AnswerDTO dto = new AnswerDTO();

        dto.title = video.title;
        dto.id = video.videoId.ToString();
        dto.description = video.description;
        dto.channelTitle = video.channelTitle;
        dto.link = video.link;

        return dto;
    }
}