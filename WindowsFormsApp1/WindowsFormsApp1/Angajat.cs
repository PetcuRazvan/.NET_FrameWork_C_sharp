using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Angajat
    {
        public string Nume {  get; set; }
        public string Prenume { get; set; }
        public decimal Salariu { get; set; }
        public DateTime DataAngajarii { get; set; }
        public string Departament { get; set; }
        public bool EstePermanent { get; set; }

        public override string ToString()
        {
            return $"{Prenume} {Nume}";
        }
    }
}
