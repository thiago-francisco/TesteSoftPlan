using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("TesteProjetoTestes")]

namespace TesteCalculaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet]
        [Route("/calculaJuros")]
        public ActionResult<decimal> calculaJuros(decimal ValorInicial, int Meses)
        {
            HttpClient http = new HttpClient();

            decimal Juros;
            try
            {
                var data = http.GetAsync("https://localhost:44352/taxaJuros").Result.Content.ReadAsStringAsync().Result;
                Juros = Convert.ToDecimal(data, new CultureInfo("en-US"));

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            decimal ValorFinal = ValorInicial * Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + Juros), Meses));

            return Ok(ValorFinal);
        }

        [HttpGet]
        [Route("/showMeTheCode")]
        public string showMeTheCode()
        {
            return "https://github.com/thiago-francisco/TesteSoftPlan";
        }
    }
}
