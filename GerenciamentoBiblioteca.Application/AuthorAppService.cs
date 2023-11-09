using AutoMapper;
using LibraryManagement.Application.Dtos.Author;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Services;

namespace LibraryManagement.Application
{
    public class AuthorAppService : IAuthorAppService
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorAppService(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public int Add(AuthorDto entity) =>
            _authorService.Add(_mapper.Map<IAuthor>(entity));

        public List<AuthorDtoGet> GetAll()
        {
            var a = _authorService.GetAll().ToList();

            return _mapper.Map<List<AuthorDtoGet>>(a);
        }
            

        public AuthorDtoGetById GetById(int id) =>
            _mapper.Map<AuthorDtoGetById>(_authorService.GetById(id));

        public void Update(int id, AuthorDto entity) =>
            _authorService.Update(id, _mapper.Map<IAuthor>(entity));
    }
}
