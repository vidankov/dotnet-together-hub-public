
using AutoMapper;

namespace Application.Topics.Commands.CreateTopic
{
    public class CreateTopicHandler(
        IApplicationDbContext dbContext, IMapper mapper)
        : ICommandHandler<CreateTopicCommand, CreateTopicResult>
    {
        public async Task<CreateTopicResult> Handle(
            CreateTopicCommand request, CancellationToken cancellationToken)
        {
            var newTopic = CreateTopic(request.TopicDto);
            dbContext.Topics.Add(newTopic);
            await dbContext.SaveChangesAsync(CancellationToken.None);
            
            return new CreateTopicResult(newTopic.ToTopicResponseDto());
        }

        private Topic CreateTopic(CreateTopicDto dto) => mapper.Map<Topic>(dto);
    }
}
