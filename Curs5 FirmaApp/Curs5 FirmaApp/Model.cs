using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5_FirmaApp
{
    public class Firma_EvArgs : EventArgs
    {
        int idxm; //index material, doamne fereste
        public Firma_EvArgs(int fidx) { idxm = fidx; } //respect
        public int Index_Salariat => idxm;
    }

    public class Salariat
    {
        public int Marca { get; set; }
        public string Nume { get; set; }
        public int NrOre { get; set; }
        public int Salo { get; set; } //salo = salariu/ora
    }

    public class Firma
    {
        public event EventHandler<Firma_EvArgs> Ev_Modificare_Firma;

        string sfirma;
        List<Salariat> ls = null;
        public Firma(string fnf = "Firma.SRL")
        {
            sfirma = fnf;
            ls = new List<Salariat>();
        }

        public List<Salariat> Salariati => ls;

        public int Numar_salariati => ls.Count;
        public string Nume_firma => sfirma;

        public void Adauga_Sal(Salariat obs)
        {
            Salariat aux = ls.Find(s => s.Marca == obs.Marca);
            if(aux != null)
            {
                throw new Exception("marca deja exista!!!");
            }

            ls.Add(obs);
            Ev_Modificare_Firma?.Invoke(this, new Firma_EvArgs(ls.Count - 1)); //ridic eventul, senderul este firma adica this, iar argumentul este firmaeventargs care contine doar indexul noului salariat
        }

        public Salariat this[int k]
        {
            get => ls[k];
            set
            {
                if (ls[k] != value)
                {
                    ls[k] = value;
                    Ev_Modificare_Firma?.Invoke(this, new Firma_EvArgs(k)); 
                }
            }
        }
    }
}
