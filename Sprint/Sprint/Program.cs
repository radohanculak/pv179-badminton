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
    var courtService = scope.Resolve<ICourtService>();
    var courtReservationService = scope.Resolve<ICourtReservationService>();
    var trainerReservationService = scope.Resolve<ITrainerReservationService>();
    var trainerReviewService = scope.Resolve<ITrainerReviewService>();

    var user = await userService.AddUserAsync("trener", "vic", "ahoj@gmail.com", DateTime.Now);
    var trainer = await trainerService.AddTrainerAsync(user.Id, "jsem trener", 250);

    var user2 = await userService.AddUserAsync("user", "vic", "ahoj@gmail.com", DateTime.Now);

    var court = await courtService.AddCourtAsync("A", 250);

    var courtReservation = await courtReservationService.AddReservationAsync(
        user.Id, court.Id, DateTime.Now, DateTime.Now.AddMinutes(90));
    var trainerReservation = await trainerReservationService.AddReservationAsync(
        user.Id, trainer.Id, court.Id, DateTime.Now, DateTime.Now.AddMinutes(80));

    var scheduleCourt = await courtService.GetDailyScheduleAsync(court.Id, DateTime.Now);
    var scheduleTrainer = await trainerReservationService.GetTrainerDailyScheduleAsync(court.Id, DateTime.Now);
    var userReservations = await courtReservationService.GetReservationAsync(user.Id);
}