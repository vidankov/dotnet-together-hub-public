using Application.ModelsDto;
using Application.Topics;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController(ITopicsService topicsService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TopicResponseDto>>> GetTopics()
        {
            return Ok(await topicsService.GetTopicsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TopicResponseDto>> GetTopic(Guid id)
        {
            return Ok(await topicsService.GetTopicAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<TopicResponseDto>> CreateTopic(CreateTopicDto dto)
        {
            return Ok(await topicsService.CreateTopicAsync(dto));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TopicResponseDto>> UpdateTopic(Guid id, [FromBody] UpdateTopicDto dto)
        {
            return Ok(await topicsService.UpdateTopicAsync(id, dto));
        }
    }
}
