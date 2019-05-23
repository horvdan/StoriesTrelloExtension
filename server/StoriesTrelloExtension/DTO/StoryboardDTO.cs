using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoriesTrelloExtension.DTO
{
    public class StoryboardDTO
    {
        public List<EpicDTO> Epics { get; set; }
        public List<ReleaseDTO> Releases { get; set; }
    }

    public class EpicDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StepDTO> Steps { get; set; }
    }

    public class StepDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TasksPerReleaseDTO> Releases { get; set; }
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
