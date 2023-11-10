using LibraryManagement.Data.Entities.Base;
using LibraryManagement.Domain.Interfaces.Entities;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Genre : BaseTable<int>, IGenre
    {
        public string? Name { get; set; }
    }
}
