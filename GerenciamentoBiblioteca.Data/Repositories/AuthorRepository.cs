using AutoMapper;
using GerenciamentoBiblioteca.Data.Context;
using GerenciamentoBiblioteca.Data.Entities;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public readonly LibraryManagementContext _libraryManagementContext;
        private readonly IMapper _mapper;

        public AuthorRepository(LibraryManagementContext libraryManagementContext, IMapper mapper)
        {
            _libraryManagementContext = libraryManagementContext;
            _mapper = mapper;
        }

        public int Add(IAuthor entity)
        {
            var author = _mapper.Map<Author>(entity);

            _libraryManagementContext.Add(author);
            _libraryManagementContext.SaveChanges();

            return author.Id;
        }

        public IQueryable<IAuthor> GetAll() => _libraryManagementContext.Author;

        public IAuthor GetById(int id)
        {
            var author = _libraryManagementContext.Author.FirstOrDefault(x => x.Id == id);
            return author ?? throw new Exception("Author not found.");
        }

        public void Update(int id, IAuthor entity)
        {
            var authorUpdate = _mapper.Map<Author>(entity);
            var author = GetById(id);

            author.Name = authorUpdate.Name;

            _libraryManagementContext.SaveChanges();
        }
    }
}
