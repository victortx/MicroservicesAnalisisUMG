using Microsoft.AspNetCore.Mvc;
using ServicesCorporal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCorporal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FraseController : ControllerBase
    {
        // GET: Posits
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(FrasesData.GetShortDescription($"{DateTime.Now.Day}"));
        }
    }
}
