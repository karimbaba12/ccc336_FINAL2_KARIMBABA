using FINAL_BLL.Services.FlightAirplanePilot;
using FINAL_BLL.Services.ReservationPassengerFlightServices;
using FINAL_BLL.Wrapping;
using Microsoft.AspNetCore.Mvc;

namespace ccc336_FINAL_KARIMBABA.Controllers
{
    public class ReservationPassengerFlightController : Controller
    {
       private readonly IReservationPassengerFlight _reservationPassengerFlight;

        public ReservationPassengerFlightController(IReservationPassengerFlight reservationPassengerFlight)
        {
            _reservationPassengerFlight = reservationPassengerFlight;
        }
        [HttpPost("Add")]

        public ApiResponse<ReservationSwitch> AddReservationPassengerFlight(ReservationSwitch reservationSwitch)
        {
            return _reservationPassengerFlight.AddReservationPassengerFlight(reservationSwitch);
        }
    }
}
