using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeApi.Models
{
    public class Yurutucu
    {
        public int Id { get; set; }

        public int ProjeId { get; set; }

        public string YurutucuAdi { get; set; }

        public string YurutucuSoyadi { get; set; }
    }
}
