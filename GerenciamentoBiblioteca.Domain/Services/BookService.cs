using FluentValidation;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Domain.Services
{
    public class BookService
    {
        private BookValidator _bookValitor;
        public readonly IBookRepository _bookRepository;
        public BookService(IBookRepository authorRepository)
        {
            _bookValitor = new BookValidator();
            _bookRepository = authorRepository;
        }

        public int Add(IBook entity)
        {
            Handler.Handler.Handle(_bookValitor.Validate(entity));
            return _bookRepository.Add(entity);
        }

        public IQueryable<IBook> GetAll() =>
            _bookRepository.GetAll();

        public IBook GetById(int id) =>
            _bookRepository.GetById(id);

        public void Update(int id, IBook entity)
        {
            Handler.Handler.Handle(_bookValitor.Validate(entity));
            _bookRepository.Update(id, entity);
        }
    }

    public class BookValidator : AbstractValidator<IBook>
    {
        public BookValidator()
        {
            RuleFor(book => book.Title).NotEmpty().NotNull();
        }
    }
}
