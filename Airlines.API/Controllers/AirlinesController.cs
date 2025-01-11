using Airlines.API.Data;
using Airlines.API.Dtos;
using Airlines.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airlines.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlinesController : ControllerBase
    {
        public AirlinesController()
        {
        }

        [HttpGet("GetAirlines", Name = "GetAirlines")]
        public IActionResult GetAirlinesss()
        {
            var allAirlines = FakeDb.GetAllAirlines();
            return Ok(allAirlines);
        }

        [HttpGet("GetAirlineById", Name = "GetAirlineById")]
        public IActionResult GetAirlineById(int airlineId)
        {
            var airline = FakeDb.GetAirlineById(airlineId);
            return Ok(airline);
        }

        [HttpDelete("DeleteAirlineById", Name = "DeleteAirlineById")]
        public IActionResult DeleteAirlineById(int airlineId)
        {
            FakeDb.DeleteAirlineById(airlineId);
            return Ok();
        }

        [HttpPut("UpdateAirlineById", Name = "UpdateAirlineById")]
        public IActionResult UpdateAirlineById(int airlineId, [FromBody]UpdateAirlineDto payload) 
        {
            if(airlineId != payload.Id)
                return BadRequest("The airline id is not valid");

            var updatedAirline = new Airline()
            {
                Id = payload.Id,
                Name = payload.Name
            };

            FakeDb.UpdateAirlineById(airlineId, updatedAirline);

            return Ok(updatedAirline);
        }

        [HttpPost("CreateAirline", Name = "CreateAirline")]
        public IActionResult CreateAirline([FromBody] CreateAirlineDto payload)
        {

            //Create new airline object
            var newAirline = new Airline
            {
                Id = FakeDb.allAirlinesFakeDb.Count + 1,
                Name = payload.Name
            };

            FakeDb.AddNewAirline(newAirline);


            return Created();
        }
    }
}
