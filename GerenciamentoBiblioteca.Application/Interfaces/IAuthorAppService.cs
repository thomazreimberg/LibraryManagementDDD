using LibraryManagement.Application.Dtos.Author;

namespace LibraryManagement.Application.Interfaces
{
    public interface IAuthorAppService : IBaseAppService<AuthorDto, int, AuthorDtoGet, AuthorDtoGetById>
    {
    }
}
