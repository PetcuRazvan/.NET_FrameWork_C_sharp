using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar1
{
    public class CasaBilete
    {
        public List<Bilet> Bilete {  get; set; }

        public CasaBilete()
        {
            Bilete = new List<Bilet>();
        }

        public void AdaugaBilete(Bilet bilet)
        {
            Bilete.Add(bilet);
        }

        public double GetIncasariTotale()
        {
            return Bilete.Sum(bilet => bilet.CalculeazaPretFinal());
        }

        public int GetNumarBiletePer<T>() where T : Bilet //filtrare ca T sa fie doar de tipul Bilet, nu e obligatoriu
        {
            return Bilete.OfType<T>().Count();
        }

        public Bilet GetBiletulCelMaiScump()
        {
            return Bilete.OrderByDescending(bilet => bilet.CalculeazaPretFinal()).FirstOrDefault();
        }
    }
}
