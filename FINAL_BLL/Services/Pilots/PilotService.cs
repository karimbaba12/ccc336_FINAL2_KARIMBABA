using AutoMapper;
using FINAL_BLL.DTO;
using FINAL_BLL.Services._GenericService;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.PassengerRepository;
using FINAL_DAL.Repositories.PilotRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.Pilots
{
    public class PilotService : GenericService<Pilot,PilotDTO> , IPilotService
    {
        public readonly IPilotRepository _pilotRepository;
    public readonly IMapper _mapper;

    public PilotService(IPilotRepository pilotRepository, IMapper mapper) : base(pilotRepository, mapper)
    {
            _pilotRepository = pilotRepository;
        _mapper = mapper;
    }


}
}