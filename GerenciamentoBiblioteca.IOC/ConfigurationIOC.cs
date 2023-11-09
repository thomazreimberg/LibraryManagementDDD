using Autofac;
using AutoMapper;
using LibraryManagement.Application;
using LibraryManagement.Data.Repositories;
using LibraryManagement.Domain.Interfaces.Repositories;
using LibraryManagement.Domain.Services;
using LibraryManagement.IOC.Mappers;

namespace LibraryManagement.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<AuthorAppService>();
            builder.RegisterType<AuthorService>();
            builder.RegisterType<AuthorRepository>().As<IAuthorRepository>();
            #endregion

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AuthorDtoToModelMapping());
            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}
