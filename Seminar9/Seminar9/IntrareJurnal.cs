using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar9
{
    [Serializable]  //aici se pun atributele
    public class IntrareJurnal
    {
        public DateTime Data {  get; set; }
        public string Titlu { get; set; }
        public string Continut { get; set; }
        public Dispozitie Dispozitie { get; set; }
        public bool EetePrivat {  get; set; }
    }
}
