namespace Mooder.Models
{
    public class Library
    {
        public string Title { get; set; }
        public string Path { get; set; }
        public Album[] Albums { get; set; }
    }
}
