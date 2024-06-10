using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.FlightAirplanePilot
{
    public class PassengerSwitch
    {

        public int PassengerId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public string? PassportNumber { get; set; }

        public int ReservationId { get; set; }
    }
}
