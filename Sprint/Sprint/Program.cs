// See https://aka.ms/new-console-template for more information
using Autofac;
using Sprint;
using Sprint.BL.Facades.Interfaces;
using Sprint.BL.Services.Interfaces;
using Sprint.Infrastructure.UnitOfWork;

using var _ioc = new Bootstrapper();

using (var scope = _ioc.Container.BeginLifetimeScope())
{

    var userFacade = scope.Resolve<IUserFacade>();
    var trainerFacade = scope.Resolve<ITrainerFacade>();
    var courtFacade = scope.Resolve<ICourtFacade>();
    var courtReservationFacade = scope.Resolve<ICourtReservationFacade>();
    var trainerReservationFacade = scope.Resolve<ITrainerReservationFacade>();
    var trainerReviewFacade = scope.Resolve<ITrainerReviewFacade>();

    var user = await userFacade.AddUserAsync("trener", "vic", "ahoj@gmail.com", DateTime.Now);
    var trainer = await trainerFacade.AddTrainerAsync(user.Id, "jsem trener", 250);

    var user2 = await userFacade.AddUserAsync("user", "vic", "ahoj@gmail.com", DateTime.Now);

    var court = await courtFacade.AddCourtAsync("A", 250);

    var userId = user.Id; //new Guid("57631c89-3294-4fd0-8571-56fc409fd067");
    var trainerId = trainer.Id;// new Guid("e173c3c2-8278-4790-96f3-72b9d055a0d2");
    var user2Id = user2.Id; // new Guid("a610e319-b84f-43c7-879a-c982ef42c550");
    var courtId = court.Id; // new Guid("9f3d77f4-4151-4be2-ac2f-f8348a8a9e83");

    var courtReservation = await courtReservationFacade.AddReservationAsync(
        user2Id, courtId, DateTime.Now, DateTime.Now.AddMinutes(90));
    var trainerReservation = await trainerReservationFacade.AddReservationAsync(
        user2Id, trainerId, courtId, DateTime.Now, DateTime.Now.AddMinutes(80));
    var allCourtUserReservations = await courtReservationFacade.GetReservationsAsync(user2Id, true);

    var rev = await trainerReviewFacade.AddReviewAsync(trainerReservation.Id, 9, "ano");
    var reviewRes = await trainerReviewFacade.GetReviewForReservationAsync(trainerReservation.Id);

    //var revs = await uow.TrainerReviewRepository.GetAllAsync();
    //var rezvs = await uow.TrainerReservationRepository.GetAllAsync();

    var reviews = await trainerReviewFacade.GetTrainerReviewsAsync(trainerId);
    var rating = await trainerReviewFacade.GetRatingAsync(trainerId);

    var scheduleCourt = await courtFacade.GetDailyScheduleAsync(courtId, DateTime.Now);
    var scheduleTrainer = await trainerReservationFacade.GetTrainerDailyScheduleAsync(trainerId, DateTime.Now);
    var res1 = await trainerReservationFacade.GetReservationsForTrainerAsync(trainerId, true);
    var res2 = await trainerReservationFacade.GetReservationsForUserAsync(user2Id, true);

    await courtReservationFacade.DeleteReservationAsync(courtReservation.Id);
    await trainerReservationFacade.DeleteReservationAsync(courtReservation.Id, false);
}