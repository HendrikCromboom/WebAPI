using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] //routing
    [ApiController] // serves http response
    public class CityController : ControllerBase
    {
        [HttpGet] // following function is a http get
        public IEnumerable<string> Get()
        {
            return new string[] { "Atlanta", "New Yourk" };
        }

        [HttpGet("{id}")] // passes an id to return a string
        public string Get( int id )
        {
            return "Atlanta";
        }
    }
}
