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

    var userId = user.Id; //new Guid("57631c89-3294-4fd0-8571-56fc409fd067");
    var trainerId = trainer.Id;// new Guid("e173c3c2-8278-4790-96f3-72b9d055a0d2");
    var user2Id = user2.Id; // new Guid("a610e319-b84f-43c7-879a-c982ef42c550");
    var courtId = court.Id; // new Guid("9f3d77f4-4151-4be2-ac2f-f8348a8a9e83");

    var courtReservation = await courtReservationService.AddReservationAsync(
        user2Id, courtId, DateTime.Now, DateTime.Now.AddMinutes(90));
    var trainerReservation = await trainerReservationService.AddReservationAsync(
        user2Id, trainerId, courtId, DateTime.Now, DateTime.Now.AddMinutes(80));
    var allCourtUserReservations = await courtReservationService.GetReservationsAsync(user2Id, true);

    var rev = await trainerReviewService.AddReviewAsync(trainerReservation.Id, 9, "ano");

    var revs = await uow.TrainerReviewRepository.GetAllAsync();
    var rezvs = await uow.TrainerReservationRepository.GetAllAsync();

    var reviews = await trainerReviewService.GetTrainerReviewsAsync(trainerId);
    var rating = await trainerReviewService.GetRatingAsync(trainerId);

    var scheduleCourt = await courtService.GetDailyScheduleAsync(courtId, DateTime.Now);
    var scheduleTrainer = await trainerReservationService.GetTrainerDailyScheduleAsync(trainerId, DateTime.Now);
    var res1 = await trainerReservationService.GetReservationsForTrainerAsync(trainerId, true);
    var res2 = await trainerReservationService.GetReservationsForTrainerAsync(trainerId, false);

    await courtReservationService.DeleteReservationAsync(courtReservation.Id);
    await trainerReservationService.DeleteReservationAsync(courtReservation.Id, false);
}