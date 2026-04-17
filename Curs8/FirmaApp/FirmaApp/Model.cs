using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace FirmaApp
{
    public class Firma_EvArgs : EventArgs
    {
        int idxm;
        public Firma_EvArgs(int fidx) { idxm = fidx; }
        public int Index_Salariat => idxm;
    }
    [DataContract]
    public class Salariat
    {
        [DataMember] public int Marca  {    get; set;   }
        [DataMember] public string Nume { get; set; }
        [DataMember] public int Nr_ore { get; set; }
        [DataMember] public int Salo { get; set; }
        public int Salariu => Nr_ore * Salo;
    }

    [DataContract]
    public class Firma
    {
        public event EventHandler<Firma_EvArgs> Ev_Modificare_Firma;
        [DataMember] string sfirma;
        [DataMember] List<Salariat> ls = null;
        public Firma(string fnf = "Firma.SRL")
        {
            sfirma = fnf;
            ls = new List<Salariat>();
        }
        public List<Salariat> Salariati => ls;
        public int Nunar_salariati => ls.Count;
        public string Nume_firma => sfirma;
        public int Fond_sal => ls.Sum(s => s.Salariu);
        public void Adauga_Sal(Salariat obs)
        {
            //Salariat aux = ls.Find(s => s.Marca == obs.Marca);
            //if (aux != null) throw new Exception("Marca Duplicata!!!");
            ls.Add(obs);
            Ev_Modificare_Firma?.Invoke(this, new Firma_EvArgs(ls.Count - 1));
        }

        public Salariat this[int k]
        {
            get => ls[k];
            set
            {
                if(ls[k]!=value)
                {
                    ls[k] = value;
                    Ev_Modificare_Firma?.Invoke(this, new Firma_EvArgs(k));
                }
            }
        }

        public void Serializeaza(string nfis) {
            FileStream fs = new FileStream(nfis, FileMode.Create);
            DataContractSerializer obs = new DataContractSerializer(typeof(Firma));
            obs.WriteObject(fs, this);
            fs.Close();
        }

        public void Deserializeaza(string nfis) {
            FileStream fs = new FileStream(nfis, FileMode.Open);
            DataContractSerializer obs = new DataContractSerializer(typeof(Firma));
            Firma aux = obs.ReadObject(fs) as Firma;
            sfirma = aux.sfirma;
            ls.Clear();
            foreach (Salariat s in aux.Salariati) Adauga_Sal(s);
            fs.Close();
        }
    }
}
