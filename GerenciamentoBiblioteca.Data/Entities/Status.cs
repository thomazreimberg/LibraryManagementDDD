using LibraryManagement.Data.Entities.Base;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Status : BaseTable<int>
    {
        public string? Name { get; set; }
    }
}
