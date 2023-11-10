using LibraryManagement.Data.Entities.Base;
using LibraryManagement.Domain.Interfaces.Entities;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Author : BaseTable<int>, IAuthor
    {
        public string? Name { get; set; }
    }
}
