namespace LibraryManagement.Domain.Interfaces.Entities
{
    public interface IReview
    {
        public int Comment { get; set; }
        public int Rate { get; set; }
        public int BookId { get; set; }
    }
}