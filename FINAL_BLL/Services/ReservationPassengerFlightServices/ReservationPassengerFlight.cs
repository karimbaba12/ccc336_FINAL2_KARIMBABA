using AutoMapper;
using FINAL_BLL.Services.FlightAirplanePilot;
using FINAL_BLL.Wrapping;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.FlightRepository;
using FINAL_DAL.Repositories.PassengerRepository;
using FINAL_DAL.Repositories.Reservationrepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FINAL_BLL.Services.ReservationPassengerFlightServices
{
    public class ReservationPassengerFlight : IReservationPassengerFlight
    {
        public readonly IPassengerRepository _passengerRepository;
        public readonly IFlightRepository _flightRepository;
        public readonly IReservationrepository _reservationRepository;
        public readonly IMapper _mapper;


        public ReservationPassengerFlight(IPassengerRepository passengerRepository, IFlightRepository flightRepository, IReservationrepository reservationRepository, IMapper mapper)
        {
            _passengerRepository = passengerRepository;
            _flightRepository = flightRepository;
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }
    

        public ApiResponse<ReservationSwitch> AddReservationPassengerFlight(ReservationSwitch reservationSwitch)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var response = new ApiResponse<ReservationSwitch>();

                    var reservationTransaction = _mapper.Map<Reservation>(reservationSwitch);
                    var passengerTransaction = _mapper.Map<Passenger>(reservationSwitch.Passengers);
                    var flightTransaction = _mapper.Map<FlightSwitch>(reservationSwitch.Flights);

                    reservationSwitch.PassengerId = reservationTransaction.PassengerId;
                    reservationSwitch.FlightId = reservationTransaction.FlightId;

                    _reservationRepository.Add(reservationTransaction);

                    scope.Complete();

                }
                catch (Exception ex)
                {
                    throw new ValidationException("Validation failed for the request.");
                    scope.Dispose();
                }

            }
            
            return new ApiResponse<ReservationSwitch>(reservationSwitch);
        }
    }

    }
