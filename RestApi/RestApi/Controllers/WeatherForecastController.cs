using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApi.Models;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        /*
         * Get Liste
         */
        [HttpGet]
        public IActionResult Get()
        {
            List<int> sayilar = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                sayilar.Add(i);
            }

            return Ok(sayilar);
        }

        [HttpGet("{kategori}/{id}")]
        public IActionResult GetById(int id, string kategori)
        {
            return Ok(new { id, kategori });
        }
    }
}
