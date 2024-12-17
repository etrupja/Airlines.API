using Airlines.API.Data;
using Airlines.API.Dtos;
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
            return Ok();
        }

        [HttpDelete("DeleteAirlineById", Name = "DeleteAirlineById")]
        public IActionResult DeleteAirlineById(int airlineId)
        {
            return Ok();
        }

        [HttpPut("UpdateAirlineById", Name = "UpdateAirlineById")]
        public IActionResult UpdateAirlineById(int airlineId, [FromBody]UpdateAirlineDto payload) 
        {
            if(airlineId != payload.Id)
                return BadRequest("The airline id is not valid");

            return Ok();
        }

        [HttpPost("CreateAirline", Name = "CreateAirline")]
        public IActionResult CreateAirline([FromBody] CreateAirlineDto payload)
        {
            return Created();
        }
    }
}
