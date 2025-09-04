﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Authorize]
        [HttpGet("test1")]
        public async Task<IResult> test1()
        {
            await Task.CompletedTask;
            return Results.Ok(new { result = "test1 ok"});
        }

        [HttpGet("test2")]
        public async Task<IResult> test2()
        {
            await Task.CompletedTask;
            return Results.Ok(new { result = "test2 ok" });
        }
    }
}
