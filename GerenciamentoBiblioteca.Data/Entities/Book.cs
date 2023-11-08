using LibraryManagement.Data.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Book : BaseTable<int>
    {
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public string? ISBN { get; set; }
        public DateTime PublishDate { get; set; }
        public string? Sumary { get; set; }

        [ForeignKey("Review")]
        public int ReviewId { get; set; }
        public Review? Review { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}
