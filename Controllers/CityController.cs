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
            return new string[] { "Antwerpen", "Brussel", "Gent", "Mechelen", "Leuven" };
        }

        [HttpGet("{id}")] // passes an id to return a string, for example localhost/api/city/1
        public string Get( int id )
        {
            return "Mortsel";
        }
    }
}
