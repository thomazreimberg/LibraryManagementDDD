using LibraryManagement.Data.Entities.Base;
using LibraryManagement.Domain.Interfaces.Entities;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Client : BaseTable<int>, IClient
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime RegistrationDate { get; set; }

        public bool SpecialClient(Client cliente) =>
             DateTime.Now.Year - cliente.RegistrationDate.Year >= 5;
    }
}
