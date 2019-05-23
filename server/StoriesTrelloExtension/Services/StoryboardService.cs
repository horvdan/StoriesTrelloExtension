using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoriesTrelloExtension.Data;
using StoriesTrelloExtension.DTO;

namespace StoriesTrelloExtension.Services
{
    public class StoryboardService : IStoryboardService
    {
        private readonly StoriesContext context;

        public StoryboardService(StoriesContext context)
        {
            this.context = context;
        }

        public async Task<StoryboardDTO> GetStoryboard()
        {
            var epics = await context.Epics
                .Include(e => e.Steps)
                    .ThenInclude(s => s.Tasks)
                    .ThenInclude(t => t.Release)
               .ToListAsync();

            return new StoryboardDTO(epics);
        }
    }
}
