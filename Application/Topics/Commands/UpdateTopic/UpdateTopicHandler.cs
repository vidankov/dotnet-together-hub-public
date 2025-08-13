
namespace Application.Topics.Commands.UpdateTopic
{
    public class UpdateTopicHandler(IApplicationDbContext dbContext)
        : ICommandHandler<UpdateTopicCommand, UpdateTopicResult>
    {
        public async Task<UpdateTopicResult> Handle(
            UpdateTopicCommand request, CancellationToken cancellationToken)
        {
            TopicId topicId = TopicId.Of(request.TopicId);

            var topic = await dbContext.Topics.FindAsync(topicId);

            if (topic is null || topic.IsDeleted)
            {
                throw new TopicNotFoundException(request.TopicId);
            }

            var dto = request.Dto;

            topic.Title = dto.Title ?? topic.Title;
            topic.Summary = dto.Summary ?? topic.Summary;
            topic.TopicType = dto.TopicType ?? topic.TopicType;
            topic.EventStart = dto.EventStart;
            topic.Location = Location.Of(
                dto.Location.City,
                dto.Location.Street
            );

            await dbContext.SaveChangesAsync(CancellationToken.None);

            return new UpdateTopicResult(topic.ToTopicResponseDto());
        }
    }
}
