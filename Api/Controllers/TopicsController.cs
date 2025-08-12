using Application.Topics.Queries.GetTopics;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TopicResponseDto>>> GetTopics()
        {
            return Ok(await mediator.Send(new GetTopicsQuery(/*ct*/)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TopicResponseDto>> GetTopic(Guid id)
        {
            return Ok(null);
        }

        [HttpPost]
        public async Task<ActionResult<TopicResponseDto>> CreateTopic(CreateTopicDto dto)
        {
            return Ok(null);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TopicResponseDto>> UpdateTopic(Guid id, [FromBody] UpdateTopicDto dto)
        {
            return Ok(null);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TopicResponseDto>> DeleteTopic(Guid id)
        {
            return Ok(null);
        }
    }
}
