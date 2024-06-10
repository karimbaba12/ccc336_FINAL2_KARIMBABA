using AutoMapper;
using FINAL_BLL.DTO;
using FINAL_BLL.Services._GenericService;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.FlightRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.Flights
{
    public class FlightService : GenericService<Flight, FlightDTO>, IFlightService
    {
        public readonly IFlightRepository _flightRepository;
        public readonly IMapper _mapper;

        public FlightService(IFlightRepository flightRepository, IMapper mapper) : base(flightRepository, mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }


    }
}