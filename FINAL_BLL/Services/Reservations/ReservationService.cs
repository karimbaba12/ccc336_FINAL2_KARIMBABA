using AutoMapper;
using FINAL_BLL.DTO;
using FINAL_BLL.Services._GenericService;
using FINAL_BLL.Services.Pilots;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.PilotRepository;
using FINAL_DAL.Repositories.Reservationrepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.Reservations
{
    public class ReservationService : GenericService<Reservation, ReservationDTO>, IReservationService
    {
        public readonly IReservationrepository _reservationRepository;
        public readonly IMapper _mapper;

        public ReservationService(IReservationrepository reservationRepository, IMapper mapper) : base(reservationRepository, mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }


    }
}