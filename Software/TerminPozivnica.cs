using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometni_planer
{
    public class TerminPozivnica
    {
        public int TerminPozivnicaId { get; set; }
        public int TerminId { get; set; }
        public string KreatorTermina { get; set; }
        public string Lokacija { get; set; }
        public string VrijemeIDatum { get; set; }
        public string NazivGrupe { get; set; }

        public TerminPozivnica()
        {

        }
    }
}
