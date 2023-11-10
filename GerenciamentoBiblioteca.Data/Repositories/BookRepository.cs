using AutoMapper;
using GerenciamentoBiblioteca.Data.Context;
using GerenciamentoBiblioteca.Data.Entities;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public readonly LibraryManagementContext _libraryManagementContext;
        private readonly IMapper _mapper;

        public BookRepository(LibraryManagementContext libraryManagementContext, IMapper mapper)
        {
            _libraryManagementContext = libraryManagementContext;
            _mapper = mapper;
        }
        public int Add(IBook entity)
        {
            var book = _mapper.Map<Author>(entity);

            _libraryManagementContext.Add(book);
            _libraryManagementContext.SaveChanges();

            return book.Id;
        }

        public IQueryable<IBook> GetAll() => _libraryManagementContext.Book;

        public IBook GetById(int id)
        {
            var book = _libraryManagementContext.Book.FirstOrDefault(x => x.Id == id);
            return book ?? throw new Exception("Book was not found."); ;
        }

        public void Update(int id, IBook entity)
        {
            var bookUpdate = _mapper.Map<Book>(entity);
            var book = GetById(id);

            book.AuthorId = bookUpdate.AuthorId;
            book.ReviewId = bookUpdate.ReviewId;
            book.GenreId = bookUpdate.GenreId;
            book.ISBN = bookUpdate.ISBN;
            book.PublishDate = bookUpdate.PublishDate;
            book.Publisher = bookUpdate.Publisher;
            book.Title = bookUpdate.Title;
            book.Sumary = bookUpdate.Sumary;

            _libraryManagementContext.SaveChanges();
        }
    }
}
