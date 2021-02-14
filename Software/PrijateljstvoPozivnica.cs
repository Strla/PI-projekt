using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometni_planer
{
    public class PrijateljstvoPozivnica
    {
        public int Id { get; set; }
        public int Pozivatelj { get; set; }
        public int Primatelj { get; set; }
        public int Odgovorena { get; set; }
        public string KorImePozivatelj { get; set; }
    }
}
