using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class User2Controller : ControllerBase
    {
        [HttpGet]
        public string GetSex(string name)
        {
            return "Man";
        }


        [HttpGet]
        public int GetAge(string name)
        {
            return 12;
        }
    }
}