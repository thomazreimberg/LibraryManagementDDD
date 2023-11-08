using LibraryManagement.Data.Entities.Base;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Genre :BaseTable<int>
    {
        public string? Name { get; set; }
    }
}
