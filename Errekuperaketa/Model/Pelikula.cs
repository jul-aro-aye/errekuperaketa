using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errekuperaketa.Model
{
    public class Pelikula
    {
        public int PelikulaId { get; set; }
        public string Izenburua { get; set; }
        public string Deskribapena { get; set; }
        public int EserlekuGuztira { get; set; }
        public bool Ezabatuta { get; set; }
    }
}
