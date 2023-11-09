using AutoMapper;
using GerenciamentoBiblioteca.Data.Entities;
using LibraryManagement.Application.Dtos.Author;
using LibraryManagement.Domain.Interfaces.Entities;

namespace LibraryManagement.IOC.Mappers
{
    public class AuthorDtoToModelMapping : Profile
    {
        public AuthorDtoToModelMapping() 
        {
            // Add
            CreateMap<AuthorDto, IAuthor>()
                .ForMember(source => source.Name, opt => opt.MapFrom(dest => dest.Name));

            // GetAll()
            CreateMap<IAuthor, AuthorDtoGet>()
                .ForMember(source => source.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(source => source.Name, opt => opt.MapFrom(dest => dest.Name));

            // GetById()
            CreateMap<IAuthor, AuthorDtoGetById>()
                .ForMember(source => source.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(source => source.Name, opt => opt.MapFrom(dest => dest.Name));

            CreateMap<IAuthor, Author>()
                .ForMember(source => source.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(source => source.Name, opt => opt.MapFrom(dest => dest.Name));
        }

        private void Map()
        {
            // Add()
            CreateMap<AuthorDto, IAuthor>()
                .ForMember(source => source.Name, opt => opt.MapFrom(dest => dest.Name));

            // GetAll()
            CreateMap<IAuthor, AuthorDtoGet>()
                .ForMember(source => source.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(source => source.Name, opt => opt.MapFrom(dest => dest.Name));

            // GetById()
            CreateMap<IAuthor, AuthorDtoGetById>()
                .ForMember(source => source.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(source => source.Name, opt => opt.MapFrom(dest => dest.Name));

            CreateMap<IAuthor, Author>()
                .ForMember(source => source.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(source => source.Name, opt => opt.MapFrom(dest => dest.Name));
        }
    }
}
