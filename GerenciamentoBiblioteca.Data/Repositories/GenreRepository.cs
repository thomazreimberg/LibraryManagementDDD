using AutoMapper;
using GerenciamentoBiblioteca.Data.Context;
using GerenciamentoBiblioteca.Data.Entities;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Data.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        public readonly LibraryManagementContext _libraryManagementContext;
        private readonly IMapper _mapper;

        public GenreRepository(LibraryManagementContext libraryManagementContext, IMapper mapper)
        {
            _libraryManagementContext = libraryManagementContext;
            _mapper = mapper;
        }
        public int Add(IGenre entity)
        {
            var genre = _mapper.Map<Genre>(entity);

            _libraryManagementContext.Add(genre);
            _libraryManagementContext.SaveChanges();

            return genre.Id;
        }

        public IQueryable<IGenre> GetAll() => _libraryManagementContext.Genre;

        public IGenre GetById(int id)
        {
            var genre = _libraryManagementContext.Genre.FirstOrDefault(x => x.Id == id);
            return genre ?? throw new Exception("Genre was not found."); ;
        }

        public void Update(int id, IGenre entity)
        {
            var genreUpdate = _mapper.Map<Genre>(entity);
            var genre = GetById(id);

            genre.Name = genreUpdate.Name;

            _libraryManagementContext.SaveChanges();
        }
    }
}
