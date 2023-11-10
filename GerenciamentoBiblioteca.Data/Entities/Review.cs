using LibraryManagement.Data.Entities.Base;
using LibraryManagement.Domain.Interfaces.Entities;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Review : BaseTable<int>, IReview
    {
        public int Comment { get; set; }
        public int Rate { get; set; }
        public int BookId { get; set; }
    }
}
