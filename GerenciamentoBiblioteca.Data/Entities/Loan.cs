using LibraryManagement.Data.Entities.Base;
using LibraryManagement.Domain.Interfaces.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Loan : BaseTable<int>, ILoan
    {
        public DateTime LoanDate { get; set; }
        public DateTime DevolutionDate { get; set; }
        public int Status { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public IBook? Book { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public IClient? Client { get; set; }
    }
}
