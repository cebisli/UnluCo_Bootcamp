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
    public class YurutucuController : ControllerBase
    {
        ProjeController projeController = new ProjeController();

        private static List<Yurutucu> yurutucuList = new List<Yurutucu>()
        {
            new Yurutucu
            {
                Id = 1,
                ProjeId = 1,
                YurutucuAdi = "İkram",
                YurutucuSoyadi = "Çebişli"
            },
            new Yurutucu
            {
                Id = 2,
                ProjeId = 2,
                YurutucuAdi = "Mustafa",
                YurutucuSoyadi = "Emin"
            },
            new Yurutucu
            {
                Id = 3,
                ProjeId = 3,
                YurutucuAdi = "Sadık",
                YurutucuSoyadi = "Mehmet"
            }
        };

        [HttpGet]

        public List<Yurutucu> YurutucuGet()
        {
            return yurutucuList;
        }

        [HttpGet("{id}")]

        public Yurutucu yurutucuGetById(int id)
        {
            var yurutucu = yurutucuList.Where(x => x.Id == id).SingleOrDefault();
            return yurutucu;
        }

        /*
         * Yürütücü Ekleme
         */
        [HttpPost]
        public IActionResult AddYurutucu([FromBody] Yurutucu yurutucuAdd)
        {
            yurutucuList.Add(yurutucuAdd);
            return Ok("Ekleme Başarılı");
        }

        [HttpPut("{id}")]
        public IActionResult updateYurutucu(Yurutucu updateYurutucu, int id)
        {
            var yurutucu = yurutucuList.SingleOrDefault(x => x.Id == id);

            /*if (proje == null || ProjeKontrol(updateProje) == false)
                return BadRequest("Güncelleme Başarısız");*/

            yurutucu.ProjeId = updateYurutucu.ProjeId != default ? updateYurutucu.ProjeId : yurutucu.ProjeId;
            yurutucu.YurutucuAdi = updateYurutucu.YurutucuAdi != default ? updateYurutucu.YurutucuAdi : yurutucu.YurutucuAdi;
            yurutucu.YurutucuSoyadi = updateYurutucu.YurutucuSoyadi != default ? updateYurutucu.YurutucuSoyadi : yurutucu.YurutucuSoyadi;

            return Ok();

        }

    }
}
