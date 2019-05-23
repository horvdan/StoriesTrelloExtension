using System.Collections.Generic;

namespace StoriesTrelloExtension.Data.Models
{
    public class Step : BaseEntity
    {
        public string Name { get; set; }
        public Epic Epic { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
