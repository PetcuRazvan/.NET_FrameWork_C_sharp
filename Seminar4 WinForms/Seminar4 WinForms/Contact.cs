using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4_WinForms
{
    public sealed class Contact //sealed este final din Java, nu pot deriva clasa asta
    {
        
        public string Nume {  get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool NotificariActive { get; set; }

        public override string ToString()
        {
            return $"{Prenume} {Nume} - {Telefon}";
        }
    }
}
