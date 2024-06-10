using ccc336_FINAL_KARIMBABA.Controllers.GenericControllers;
using FINAL_BLL.DTO;
using FINAL_BLL.Services.Passengers;
using FINAL_BLL.Services.Pilots;
using Microsoft.AspNetCore.Mvc;

namespace ccc336_FINAL_KARIMBABA.Controllers
{
    public class PassengerController : GenericController<PassengerDTO>
    {
        private readonly IPassengerService _passengerService;
        public PassengerController(IPassengerService service) : base(service)
        {
            _passengerService = service;
        }


    }
}