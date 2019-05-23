using System.Collections.Generic;

namespace StoriesTrelloExtension.Data.Models
{
    public class Release : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
