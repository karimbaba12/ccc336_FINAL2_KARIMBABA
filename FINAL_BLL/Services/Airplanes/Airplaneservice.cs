using AutoMapper;
using FINAL_BLL.DTO;
using FINAL_BLL.Services._GenericService;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.AirplaneRepository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.Airplanes
{

   
    public class Airplaneservice : GenericService<Airplane, AirplaneDTO>, IAirplaneService
    {
        public readonly IAirplaneRepository _airplaneRepository;
        public readonly IMapper _mapper;

        public Airplaneservice(IAirplaneRepository airplaneRepository, IMapper mapper) : base(airplaneRepository, mapper)
        {
            _airplaneRepository = airplaneRepository;
            _mapper = mapper;
        }
    }

}
