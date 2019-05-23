using System.Collections.Generic;

namespace StoriesTrelloExtension.Data.Models
{
    public class Epic : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Step> Steps { get; set; }
    }
}
