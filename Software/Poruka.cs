using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometni_planer
{
    public class Poruka
    {
        public int PorukaID { get; set; }
        public int GrupaID { get; set; }
        public string Korisnik { get; set; }
        public string Vrijeme { get; set; }
        public string Tekst { get; set; }

        public Poruka()
        {

        }
    }
}
