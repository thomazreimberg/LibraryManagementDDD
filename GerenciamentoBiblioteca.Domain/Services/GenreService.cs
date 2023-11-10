using FluentValidation;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Domain.Services
{
    public class GenreService
    {
        private GenreValidator _genreValitor;
        public readonly IGenreRepository _genreRepository;
        public GenreService(IGenreRepository genreRepository)
        {
            _genreValitor = new GenreValidator();
            _genreRepository = genreRepository;
        }

        public int Add(IGenre entity)
        {
            Handler.Handler.Handle(_genreValitor.Validate(entity));
            return _genreRepository.Add(entity);
        }

        public IQueryable<IGenre> GetAll() =>
            _genreRepository.GetAll();

        public IGenre GetById(int id) =>
            _genreRepository.GetById(id);

        public void Update(int id, IGenre entity)
        {
            Handler.Handler.Handle(_genreValitor.Validate(entity));
            _genreRepository.Update(id, entity);
        }
    }

    public class GenreValidator : AbstractValidator<IGenre>
    {
        public GenreValidator()
        {
            RuleFor(genre => genre.Name).NotEmpty().NotNull();
        }
    }
}
