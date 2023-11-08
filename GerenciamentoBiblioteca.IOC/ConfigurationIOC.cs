using Autofac;
using AutoMapper;

namespace LibraryManagement.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            #endregion

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                //cfg.Configure<MapperConfiguration>();
            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}
