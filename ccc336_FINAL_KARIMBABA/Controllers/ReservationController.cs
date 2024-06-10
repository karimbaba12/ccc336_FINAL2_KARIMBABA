using ccc336_FINAL_KARIMBABA.Controllers.GenericControllers;
using FINAL_BLL.DTO;
using FINAL_BLL.Services.Pilots;
using FINAL_BLL.Services.Reservations;
using Microsoft.AspNetCore.Mvc;

namespace ccc336_FINAL_KARIMBABA.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ReservationController : GenericController<ReservationDTO>
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService service) : base(service)
        {
            _reservationService = service;
        }


    }
}