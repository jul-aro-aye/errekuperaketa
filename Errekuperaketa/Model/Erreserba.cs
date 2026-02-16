using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errekuperaketa.Model
{
    public class Erreserba
    {
        public int ErreserbaId { get; set; }

        public int PelikulaId { get; set; }

        public string ErreserbaIzena { get; set; }

        public int EserlekuKopurua { get; set; }

        public DateTime ErreserbaData { get; set; }
    }
}
