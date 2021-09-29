using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCorporal.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasaMuscularController : ControllerBase
    {
        // GET: Posits
        [HttpPost]
        public IActionResult Index([FromBody] FormCorporal data)
        {
            var result = data.peso / (data.Estatura * data.Estatura);
            var mensaje = "";
            if (result < 18)
            {
                mensaje = "Bajo peso";
            } else
            {
                if (result <= 24) 
                {
                    mensaje = "Peso normal";
                } else
                {
                    if (result <= 29) 
                    {
                        mensaje = "Sobre peso";
                    } else
                    {
                        mensaje = "Obesidad";
                    }
                } 
            }
            return Ok(mensaje);
        }
    }
}
