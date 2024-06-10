using FINAL_DAL.Models;
using FINAL_DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_DAL.Repositories.Reservationrepository
{
    public class Reservationrepository : GenericRepository<Reservation>, IReservationrepository
    {
        public Reservationrepository(AirplaneSystemContext AirplaneSystemContext) : base(AirplaneSystemContext)
        {
        }
    }
}
