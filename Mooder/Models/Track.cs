namespace Mooder.Models
{
    public class Track
    {
        public string Title { get; set; }
        public string Album { get; set; }
        public string? Artist { get; set; }
        public int TrackNo { get; set; }
        public string? Picture { get; set; }
        public string Path { get; set; }
    }
}
