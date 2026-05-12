using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sminar12dartrebuiasafie11
{
    public class TodoTask
    {
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public Prioritate Prioritate { get; set; }
        public DateTime DataCreare { get; set; }
        public bool Efectuat { get; set; }
    }
}
