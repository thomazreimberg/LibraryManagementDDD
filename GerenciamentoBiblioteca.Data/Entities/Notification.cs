using LibraryManagement.Data.Entities.Base;
using LibraryManagement.Domain.Interfaces.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Notification : BaseTable<int>, INotification
    {
        public string? Mensagem { get; set; }
        public DateTime DataEnvio { get; set; }

        [ForeignKey("Loan")]
        public int LoanId { get; set; }
        public Loan? Loan { get; set; }
    }
}
