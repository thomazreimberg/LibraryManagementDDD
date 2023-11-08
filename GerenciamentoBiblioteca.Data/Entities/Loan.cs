using LibraryManagement.Data.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Loan : BaseTable<int>
    {
        public DateTime LoanDate { get; set; }
        public DateTime DevolutionDate { get; set; }
        public int Status { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book? Book { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client? Client { get; set; }
    }
}
