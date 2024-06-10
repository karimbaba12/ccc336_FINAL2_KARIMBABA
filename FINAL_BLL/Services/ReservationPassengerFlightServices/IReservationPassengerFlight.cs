using FINAL_BLL.Services.FlightAirplanePilot;
using FINAL_BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.ReservationPassengerFlightServices
{
    public interface IReservationPassengerFlight
    {
        ApiResponse<ReservationSwitch> AddReservationPassengerFlight(ReservationSwitch reservationSwitch);
    }
}

