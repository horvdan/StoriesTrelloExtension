using StoriesTrelloExtension.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace StoriesTrelloExtension.DTO
{
    public class StoryboardDTO
    {
        public StoryboardDTO(List<Epic> epics)
        {
            this.Epics = epics.Select(e => new EpicDTO(e)).ToList();
            this.Releases = epics
                .SelectMany(e => e.Steps
                    .SelectMany(s => s.Tasks
                        .Select(t => new ReleaseDTO{ Id = t.Release.Id, Name = t.Release.Name })))
                        .GroupBy(r => r.Id)
                        .Select(r => r.First())
                        .ToList();
        }

        public List<EpicDTO> Epics { get; set; }
        public List<ReleaseDTO> Releases { get; set; }
    }
}
