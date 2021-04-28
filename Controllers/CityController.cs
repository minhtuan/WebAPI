
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController: ControllerBase
    {
        public CityController(){

        }

        //GET api/city
        [HttpGet("")]
        public IEnumerable<string> GetStrins(){
            return new string[] {"Ho Chi Minh", "Da Lat", "Da Nang", "Ha Noi", "New York", "Atlanta" };
        }
    }
}