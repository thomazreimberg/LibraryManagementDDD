using LibraryManagement.Data.Entities.Base;
using LibraryManagement.Domain.Interfaces.Entities;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Status : BaseTable<int>, IStatus
    {
        public string? Name { get; set; }
    }
}
