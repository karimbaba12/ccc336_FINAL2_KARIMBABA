using ccc336_FINAL_KARIMBABA.Controllers.GenericControllers;
using FINAL_BLL.DTO;
using FINAL_BLL.Services.Airplanes;
using FINAL_BLL.Services.Pilots;
using Microsoft.AspNetCore.Mvc;

namespace ccc336_FINAL_KARIMBABA.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AirplaneController : GenericController<AirplaneDTO>
    {
        private readonly IAirplaneService _airplaneService;
        public AirplaneController(IAirplaneService service) : base(service)
        {
            _airplaneService = service;
        }


    }
}