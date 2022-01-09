using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjeApi.Models;

namespace ProjeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjeTurController : ControllerBase
    {

        public static List<ProjeTur> projeTursList = new List<ProjeTur>()
        {
            new ProjeTur{
                Id = 1,
                TurAd = "Lisans Projesi",
                Aktif = true
            },
            new ProjeTur
            {
                Id = 2,
                TurAd = "Doktora Projesi",
                Aktif = true
            },
            new ProjeTur
            {
                Id = 3,
                TurAd = "Bitirme Projesi",
                Aktif = true
            }

        };

        [HttpGet]

        public List<ProjeTur> projeTurs()
        {
            return projeTursList;
        }

        [HttpGet("{id}")]

        public ProjeTur ProjeTur(int id)
        {
            var tur = projeTursList.Where(x => x.Id == id).SingleOrDefault();
            return tur;
        }

        /*
         * Proje Tur Ekleme
         */
        [HttpPost]
        public IActionResult AddProjeTur([FromBody] ProjeTur projeTur)
        {
            var tur = projeTursList.SingleOrDefault(x => x.TurAd == projeTur.TurAd);

            if (tur != null)
                return BadRequest();

            projeTursList.Add(projeTur);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProjeTur(int id, [FromBody] ProjeTur projeTur)
        {
            var tur = projeTursList.SingleOrDefault(x => x.Id == id);

            if (tur is null)
                return BadRequest();

            tur.TurAd = projeTur.TurAd != default ? projeTur.TurAd : tur.TurAd;
            tur.Aktif = projeTur.Aktif != default ? projeTur.Aktif : tur.Aktif;

            return Ok();
        }
    }
}
