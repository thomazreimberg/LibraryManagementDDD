using FluentValidation;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;
using LibraryManagement.Domain.Interfaces.Services;

namespace LibraryManagement.Domain.Services
{
    public class AuthorService : IAuthorService
    {
        private AuthorValidator _authorValitor;
        public readonly IAuthorRepository _authorRepository;
        public AuthorService(IAuthorRepository authorRepository) 
        {
            _authorValitor = new AuthorValidator();
            _authorRepository = authorRepository;
        }

        public int Add(IAuthor entity) 
        {
            Handler.Handler.Handle(_authorValitor.Validate(entity));
            return _authorRepository.Add(entity);
        } 

        public IQueryable<IAuthor> GetAll() =>
            _authorRepository.GetAll();

        public IAuthor GetById(int id) =>
            _authorRepository.GetById(id);

        public void Update(int id, IAuthor entity)
        {
            Handler.Handler.Handle(_authorValitor.Validate(entity));
            _authorRepository.Update(id, entity);
        }
    }

    public class AuthorValidator : AbstractValidator<IAuthor>
    {
        public AuthorValidator()
        {
            RuleFor(author => author.Name).NotEmpty().NotNull();
        }
    }
}
