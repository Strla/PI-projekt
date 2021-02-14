using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometni_planer
{
    public class Termin
    {
        public int Id { get; set; }
        public string DatumIVrijeme { get; set; }
        public string Lokacija { get; set; }
        public int Grupa { get; set; }
        public int Kreator { get; set; }
    }
}
