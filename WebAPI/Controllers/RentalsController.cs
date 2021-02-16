using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService .GetAll();
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest();

        }
        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("checkreturndate")]
        public IActionResult CheckReturnDate(int id)
        {
            var result = _rentalService.CheckReturnDate(id);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
