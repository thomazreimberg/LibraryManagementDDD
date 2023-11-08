namespace LibraryManagement.Domain.Interfaces.Entities
{
    public interface INotification
    {
        public string? Mensagem { get; set; }
        public DateTime DataEnvio { get; set; }
        public int LoanId { get; set; }
        public ILoan? Loan { get; set; }
    }
}
