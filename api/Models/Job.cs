namespace api.Models
{
    public class Job
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public List<SubItem> SubItems { get; set; }

    }
}
