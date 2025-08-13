namespace Application.Topics.Commands.UpdateTopic
{
    public record UpdateTopicCommand(Guid TopicId, UpdateTopicDto Dto) : ICommand<UpdateTopicResult>;

    public record UpdateTopicResult(TopicResponseDto Result);
}
