using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Sprint.BL.Dto.User;
using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerPhoto;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Dto.TrainerReview;
using Sprint.DAL.EFCore.Models;

namespace Sprint.BL.Configs;

public class BusinessMappingConfig
{
    public static void ConfigureMapping(IMapperConfigurationExpression config)
    {
        config.CreateMap<UserCreateDto, User>()
            .ForMember(dest => dest.PasswordHash, cfg => cfg.MapFrom(src => GetPasswordHash(src.Password)));
        
        config.CreateMap<User, UserDto>()
            .ForMember(dest => dest.Age, cfg => cfg.MapFrom(src => GetAge(src.DateOfBirth)));
        
        config.CreateMap<TrainerCreateDto, Trainer>();
        
        config.CreateMap<Trainer, TrainerDto>();
        
        config.CreateMap<Court, CourtDto>().ReverseMap();
        
        config.CreateMap<CourtReservation, CourtReservationDto>().ReverseMap();

        config.CreateMap<TrainerReservation, TrainerReservationDto>().ReverseMap();
        
        config.CreateMap<TrainerReview, TrainerReviewDto>().ReverseMap();
        
        config.CreateMap<TrainerPhoto, TrainerPhotoDto>().ReverseMap();
    }

    private static int GetAge(DateTime dateOfBirth) =>
        DateTime.Today.Subtract(dateOfBirth).Days / 365;

    /*
     * UserDto type is not actually used in the function, but it has to be there
     */
    private static string GetPasswordHash(string password) =>
        new PasswordHasher<UserDto>().HashPassword(null!, password);

}
