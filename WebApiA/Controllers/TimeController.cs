using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiA.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public string GetNow()
        {
            return DateTime.Now.ToString("hh:mm:ss");
        }
    }
}