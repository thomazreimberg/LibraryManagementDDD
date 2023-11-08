using LibraryManagement.Data.Entities.Base;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Review : BaseTable<int>
    {
        public int Comment { get; set; }
        public int Rate { get; set; }
        public int BookId { get; set; }
    }
}
