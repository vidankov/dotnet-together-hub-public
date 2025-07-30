using Domain.ValueObjects;

namespace Application.Topics
{
    public interface ITopicsService
    {
        Task<List<Topic>> GetTopics();
        Task<Topic> GetTopicAsync(TopicId id);
        Task<Topic> CreateTopicAsync(Topic topicRequestDto);
        Task<Topic> UpdateTopicAsync(TopicId id, Topic topicRequestDto);
        Task DeleteTopicAsync(TopicId id);
    }
}
