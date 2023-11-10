using LibraryManagement.Data.Entities.Base;
using LibraryManagement.Domain.Interfaces.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Book : BaseTable<int>, IBook
    {
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public string? ISBN { get; set; }
        public DateTime PublishDate { get; set; }
        public string? Sumary { get; set; }

        [ForeignKey("Review")]
        public int ReviewId { get; set; }
        public IReview? Review { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public IAuthor? Author { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public IGenre? Genre { get; set; }
    }
}
