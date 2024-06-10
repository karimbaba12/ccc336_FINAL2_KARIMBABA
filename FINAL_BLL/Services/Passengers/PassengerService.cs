using AutoMapper;
using FINAL_BLL.DTO;
using FINAL_BLL.Services._GenericService;
using FINAL_BLL.Services.Flights;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.FlightRepository;
using FINAL_DAL.Repositories.PassengerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.Passengers
{
    public class PassengerService : GenericService<Passenger, PassengerDTO>, IPassengerService
    {
        public readonly IPassengerRepository _passengerRepository;
        public readonly IMapper _mapper;

        public PassengerService(IPassengerRepository passengerRepository, IMapper mapper) : base(passengerRepository, mapper)
        {
            _passengerRepository = passengerRepository;
            _mapper = mapper;
        }


    }
}