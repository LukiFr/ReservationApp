using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservationService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Azure.ServiceBus;


namespace ReservationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ReservationsController : ControllerBase
    {
        public readonly DataContext _context;

        public ReservationsController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            return Ok(_context.Reservations.ToList());
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Add(Reservation p)
        {
            _context.Reservations.Add(p);
            _context.SaveChanges();

            return Created("/api/reservations/", p);

        }

    }
}
