using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoriesTrelloExtension.DTO;
using StoriesTrelloExtension.Services;

namespace StoriesTrelloExtension.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryboardController : ControllerBase
    {
        private readonly IStoryboardService storyboardService;

        public StoryboardController(IStoryboardService storyboardService)
        {
            this.storyboardService = storyboardService;
        }

        [HttpGet]
        public async Task<ActionResult<StoryboardDTO>> Get()
        {
            return await storyboardService.GetStoryboard();
        }
    }
}
