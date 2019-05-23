namespace StoriesTrelloExtension.Data.Models
{
    public class Task : BaseEntity
    {
        public string Name { get; set; }
        public Step Step { get; set; }
        public Release Release { get; set; }
    }
}
