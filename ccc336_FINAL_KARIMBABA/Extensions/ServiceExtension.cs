using FINAL_BLL.Services.Airplanes;
using FINAL_BLL.Services.Flights;
using FINAL_BLL.Services.Passengers;
using FINAL_BLL.Services.Pilots;
using FINAL_BLL.Services.ReservationPassengerFlightServices;
using FINAL_BLL.Services.Reservations;
namespace ccc336_FINAL_KARIMBABA.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddScoped<IAirplaneService,Airplaneservice>();
            services.AddScoped<IPilotService, PilotService>();
            services.AddScoped<IPassengerService,PassengerService>();
            services.AddScoped<IReservationService,ReservationService>();
            services.AddScoped<IFlightService,FlightService>();
            services.AddScoped<IReservationPassengerFlight, ReservationPassengerFlight>();

            return services;
        }
    }
}
