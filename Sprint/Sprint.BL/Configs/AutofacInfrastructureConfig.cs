using Autofac;
using Sprint.DAL.EFCore.Data;
using Sprint.Infrastructure.EFCore.Repository;
using Sprint.Infrastructure.Repository;
using Sprint.Infrastructure.UnitOfWork;
using Sprint.Infrastructure.EFCore.UnitOfWork;

namespace Sprint.Infrastructure;

public class AutofacInfrastructureConfig : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<EFUnitOfWork>()
            .As<IUnitOfWork>()
            .InstancePerLifetimeScope();

        builder.RegisterType<EFCourtReservationRepository>()
            .As<ICourtReservationRepository>()
            .InstancePerLifetimeScope();

        builder.RegisterType<EFTrainerRepository>()
            .As<ITrainerRepository>()
            .InstancePerLifetimeScope();

        builder.RegisterType<EFUserRepository>()
            .As<IUserRepository>()
            .InstancePerLifetimeScope();

        builder.RegisterGeneric(typeof(EFGenericRepository<>))
            .As(typeof(IRepository<>))
            .InstancePerDependency();

       

        builder.RegisterType<SprintDbContext>()
            .AsSelf()
            .InstancePerLifetimeScope();
    }
}
