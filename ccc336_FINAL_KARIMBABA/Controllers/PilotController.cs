using ccc336_FINAL_KARIMBABA.Controllers.GenericControllers;
using FINAL_BLL.DTO;
using FINAL_BLL.Services.Pilots;
using Microsoft.AspNetCore.Mvc;

namespace ccc336_FINAL_KARIMBABA.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PilotController : GenericController<PilotDTO>
    {
        private readonly IPilotService _pilotService;
        public PilotController(IPilotService service) : base(service)
        {
            _pilotService = service;
        }


    }
}