// See https://aka.ms/new-console-template for more information
using Autofac;
using Sprint;
using Sprint.BL.Services.Interfaces;
using Sprint.Infrastructure.UnitOfWork;

using var _ioc = new Bootstrapper();

using (var scope = _ioc.Container.BeginLifetimeScope())
{
    using var uow = scope.Resolve<IUnitOfWork>();

    var userService = scope.Resolve<IUserService>();
    var trainerService = scope.Resolve<ITrainerService>();

    var user = await userService.AddUser("jitka", "vic", "ahoj@gmail.com", DateTime.Now);

    var thisUser = await userService.GetUser(user.Id);
    var nonExistentUser = await userService.GetUser(Guid.NewGuid());

    var trainer = await trainerService.AddTrainer(user.Id, "jsem trener", 250);
    var nullTrainer = await trainerService.AddTrainer(user.Id, "jsem trener", -50);
    var nonTrainer = await trainerService.AddTrainer(Guid.NewGuid(), "jsem trener", 250);

    var trainers = await uow.TrainerRepository.GetAllAsync();
}