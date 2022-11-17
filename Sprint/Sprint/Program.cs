// See https://aka.ms/new-console-template for more information
using Autofac;
using Sprint;
using Sprint.BL.Services.Interfaces;
using Sprint.Infrastructure.UnitOfWork;

using var _ioc = new Bootstrapper();

using (var scope = _ioc.Container.BeginLifetimeScope())
{
    using var uow = scope.Resolve<IUnitOfWork>();

    var service = scope.Resolve<IUserService>();

    var user = await service.AddUser("jitka", "vic", "ahoj@gmail.com", DateTime.Now);

    await uow.CommitAsync();

    var users = await uow.UserRepository.GetAllAsync();
}