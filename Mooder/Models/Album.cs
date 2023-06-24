namespace Mooder.Models
{
    public class Album
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Artist { get; set; }
        public string? Picture { get; set; }
        public Track[] Track { get; set; }
    }
}
