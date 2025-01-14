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
        private AirlinesService _airlinesService;
        public AirlinesController(AirlinesService airlinesService)
        {
            _airlinesService = airlinesService;
        }

        [HttpGet("GetAirlines", Name = "GetAirlines")]
        public IActionResult GetAirlinesss()
        {
            var allAirlines = _airlinesService.GetAllAirlines();
            return Ok(allAirlines);
        }

        [HttpGet("GetAirlineById", Name = "GetAirlineById")]
        public IActionResult GetAirlineById(int airlineId)
        {
            var airline = _airlinesService.GetAirlineById(airlineId);
            return Ok(airline);
        }

        [HttpDelete("DeleteAirlineById", Name = "DeleteAirlineById")]
        public IActionResult DeleteAirlineById(int airlineId)
        {
            _airlinesService.DeleteAirlineById(airlineId);
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

            _airlinesService.UpdateAirlineById(airlineId, updatedAirline);

            return Ok(updatedAirline);
        }

        [HttpPost("CreateAirline", Name = "CreateAirline")]
        public IActionResult CreateAirline([FromBody] CreateAirlineDto payload)
        {

            //Create new airline object
            var newAirline = new Airline
            {
                Name = payload.Name
            };

            _airlinesService.AddNewAirline(newAirline);


            return Created();
        }
    }
}
