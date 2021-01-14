using System;
using Microsoft.AspNetCore.Mvc;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("TesteProjetoTestes")]

namespace TesteJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JurosController : ControllerBase
    {
        [HttpGet]
        [Route("/taxaJuros")]
        public decimal taxaJuros()
        {
            return Convert.ToDecimal(0.01);
        }
    }
}
