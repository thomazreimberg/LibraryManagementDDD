namespace LibraryManagement.Application.Dtos.Book
{
    public class BookDto
    {
        public string Title { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
        public string Sumary { get; set; } = string.Empty;
        public int ReviewId { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
    }
}
