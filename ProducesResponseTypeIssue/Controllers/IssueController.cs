using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ProducesResponseTypeIssue.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IssueController : ControllerBase
    {            
        public IssueController()
        {         
        }

        [ProducesResponseType<string>(StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [HttpGet("GetWithContentTypeInProducesResponseTypeAttribute")]
        public IActionResult GetWithContentTypeInProducesResponseTypeAttribute()
        {
            return Ok("sample");
        }

        [ProducesResponseType<string>(StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        [HttpGet("GetWithContentTypeInProducesAttribute")]
        public IActionResult GetWithContentTypeInProducesAttribute()
        {
            return Ok("sample");
        }

    }
}
