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

    public class EpicDTO
    {
        //TODO: Add AutoMapper
        public EpicDTO(Epic epic)
        {
            this.Id = epic.Id;
            this.Name = epic.Name;
            this.Steps = epic.Steps.Select(s => new StepDTO(s)).ToList();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<StepDTO> Steps { get; set; }
    }

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

    public class TasksPerReleaseDTO
    {
        public int ReleaseId { get; set; }
        public List<TaskDTO> Tasks;
    }

    public class TaskDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ReleaseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
