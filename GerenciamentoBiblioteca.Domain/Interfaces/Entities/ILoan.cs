using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain.Interfaces.Entities
{
    public interface ILoan
    {
        public DateTime LoanDate { get; set; }
        public DateTime DevolutionDate { get; set; }
        public int Status { get; set; }

        public int BookId { get; set; }
        public IBook? Book { get; set; }

        public int ClientId { get; set; }
        public IClient? Client { get; set; }
    }
}
