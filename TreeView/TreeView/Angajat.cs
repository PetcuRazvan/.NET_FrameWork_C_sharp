using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView
{
    public class Angajat
    {
        public Guid Id { get; set; }
        public string NumeComplet { get; set; }
        public string Functie { get; set; }
        public Departament Departament { get; set; }
        public DateTime DataAngajarii { get; set; }
        public decimal Salariu { get; set; }
        public string Email { get; set; }
        public Guid? ManagerId { get; set; }
        public string NumeImagine { get; set; }

        public Angajat()
        {
            Id = Guid.NewGuid();
        }
    }
}
