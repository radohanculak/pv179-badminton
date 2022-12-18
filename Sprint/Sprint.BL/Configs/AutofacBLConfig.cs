using System.Reflection;
using Autofac;
using Module = Autofac.Module;
using AutoMapper;
using Sprint.Infrastructure;

namespace Sprint.BL.Configs;

public class AutofacBLConfig : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule(new AutofacInfrastructureConfig());

        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .Where(t => t.Namespace == "Sprint.BL.QueryObjects")
            .InstancePerDependency();

        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .Where(t => t.Namespace == "Sprint.BL.Services")
            .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name)!)
            .InstancePerDependency();
        
        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .Where(t => t.Namespace == "Sprint.BL.Facades")
            .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name)!)
            .InstancePerDependency();

        builder.RegisterInstance(new Mapper(new MapperConfiguration(BusinessMappingConfig.ConfigureMapping)))
            .As<IMapper>()
            .SingleInstance();
    }

    public static IContainer Configure()
    {
        var builder = new ContainerBuilder();

        builder.RegisterModule(new AutofacInfrastructureConfig());

        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .Where(t => t.Namespace == "Sprint.BL.QueryObjects")
            .AsSelf()
            .InstancePerDependency();

        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .Where(t => t.Namespace == "Sprint.BL.Services")
            .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name)!)
            .InstancePerDependency();
        
        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .Where(t => t.Namespace == "Sprint.BL.Facades")
            .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name)!)
            .InstancePerDependency();

        builder.RegisterInstance(new Mapper(new MapperConfiguration(BusinessMappingConfig.ConfigureMapping)))
            .As<IMapper>()
            .SingleInstance();
        
        return builder.Build();
    }
}
