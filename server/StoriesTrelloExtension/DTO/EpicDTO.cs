using StoriesTrelloExtension.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace StoriesTrelloExtension.DTO
{
    public class EpicDTO
    {
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

}
