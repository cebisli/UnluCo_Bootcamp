using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }
    }
}
