using ccc336_FINAL_KARIMBABA.Controllers.GenericControllers;
using FINAL_BLL.DTO;
using FINAL_BLL.Services.Airplanes;
using FINAL_BLL.Services.Flights;
using FINAL_BLL.Services.Pilots;
using Microsoft.AspNetCore.Mvc;

namespace ccc336_FINAL_KARIMBABA.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class FlightController : GenericController<FlightDTO>
    {
        private readonly IFlightService _flightService;
        public FlightController(IFlightService service) : base(service)
        {
            _flightService = service;
        }


    }
}