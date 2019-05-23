using System.Collections.Generic;

namespace StoriesTrelloExtension.DTO
{
    public class TasksPerReleaseDTO
    {
        public int ReleaseId { get; set; }
        public List<TaskDTO> Tasks;
    }
}
