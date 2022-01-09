using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeApi.Models
{
    public class Proje
    {
        public int Id { get; set; }

        public int ProjeTurId { get; set; }

        public string ProjeNo { get; set; }

        public string ProjeTitle { get; set; }

        public string ProjeDate { get; set; }

    }
}
