using StoriesTrelloExtension.DTO;
using System.Threading.Tasks;

namespace StoriesTrelloExtension.Services
{
    public interface IStoryboardService
    {
        Task<StoryboardDTO> GetStoryboard();
    }
}
