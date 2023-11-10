namespace LibraryManagement.Domain.Interfaces.Entities
{
    public interface IBook
    {
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public string? ISBN { get; set; }
        public DateTime PublishDate { get; set; }
        public string? Sumary { get; set; }

        public int ReviewId { get; set; }
        public IReview? Review { get; set; }

        public int AuthorId { get; set; }
        public IAuthor? Author { get; set; }

        public int GenreId { get; set; }
        public IGenre? Genre { get; set; }
    }
}
