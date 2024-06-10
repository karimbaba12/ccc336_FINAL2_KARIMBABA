using FINAL_DAL.Models;
using FINAL_DAL.Repositories.AirplaneRepository;
using FINAL_DAL.Repositories.FlightRepository;
using FINAL_DAL.Repositories.PassengerRepository;
using FINAL_DAL.Repositories.PilotRepository;
using FINAL_DAL.Repositories.Reservationrepository;

namespace ccc336_FINAL_KARIMBABA.Extensions
{
    public static class RepositoryExtension
    { 
        public static IServiceCollection AddRepositories(this IServiceCollection services)
    {

        services.AddScoped<IAirplaneRepository, AirplaneRepository>();
        services.AddScoped<IPassengerRepository, PassengerRepository>();
        services.AddScoped<IPilotRepository,PilotRepository>();
        services.AddScoped<IFlightRepository, FlightRepository>();
        services.AddScoped<IReservationrepository,Reservationrepository >();
        return services;
    }
}
}

