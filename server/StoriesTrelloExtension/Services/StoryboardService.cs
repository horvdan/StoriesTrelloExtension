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

        StoryboardDTO GetStoryboard()
        {
            throw new System.NotImplementedException();
        }
    }
}
