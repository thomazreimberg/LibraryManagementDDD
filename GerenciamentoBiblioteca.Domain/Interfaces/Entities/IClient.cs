namespace LibraryManagement.Domain.Interfaces.Entities
{
    public interface IClient
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
