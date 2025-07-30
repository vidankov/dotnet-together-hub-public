﻿using Application.Data.DataBaseContext;
using Domain.ValueObjects;
using Microsoft.Extensions.Logging;

namespace Application.Topics
{
    public class TopicsService(IApplicationDbContext dbContext,
        ILogger<TopicsService> logger) : ITopicsService
    {
        public Task<Topic> CreateTopicAsync(Topic topicRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTopicAsync(TopicId id)
        {
            throw new NotImplementedException();
        }

        public async Task<Topic> GetTopicAsync(TopicId id)
        {
            
        }

        public async Task<List<Topic>> GetTopics()
        {
            var topics = await dbContext.Topics
                .AsNoTracking()
                .ToListAsync();

            return topics;
        }

        public Task<Topic> UpdateTopicAsync(TopicId id, Topic topicRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
