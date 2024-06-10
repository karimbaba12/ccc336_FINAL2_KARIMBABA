using AutoMapper;
using FINAL_BLL.DTO;
using FINAL_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
        CreateMap<Airplane,AirplaneDTO>().ReverseMap();
            CreateMap<Flight,FlightDTO>().ReverseMap();
            CreateMap<Passenger,PassengerDTO>().ReverseMap();
            CreateMap<Reservation,ReservationDTO>().ReverseMap();
            CreateMap<Pilot,PilotDTO>().ReverseMap();
        }
    }
}
