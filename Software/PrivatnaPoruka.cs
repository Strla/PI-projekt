using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometni_planer
{
    class PrivatnaPoruka
    {
        public int Id { get; set; }
        public string Posiljatelj { get; set; }
        public string Tekst { get; set; }
        public string Vrijeme { get; set; }
        public bool Procitano { get; set; }
    }
}
