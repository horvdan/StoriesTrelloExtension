using StoriesTrelloExtension.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace StoriesTrelloExtension.DTO
{
    public class StepDTO
    {
        public StepDTO(Step step)
        {
            this.Id = step.Id;
            this.Name = step.Name;

            this.TasksPerRelease = step.Tasks.GroupBy(
                t => t.Release.Id,
                t => t,
                (key, g) => new TasksPerReleaseDTO
                {
                    ReleaseId = key,
                    Tasks = g.Select(t => new TaskDTO { Id = t.Id, Name = t.Name }).ToList()
                })
                .ToList();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<TasksPerReleaseDTO> TasksPerRelease { get; set; }
    }
}
