using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace Curs5_FirmaApp
{
    public class Firma_EvArgs : EventArgs
    {
        int idxm; //index material, doamne fereste
        public Firma_EvArgs(int fidx) { idxm = fidx; } //respect
        public int Index_Salariat => idxm;
    }

    [DataContract]
    public class Salariat
    {
        [DataMember] public int Marca { get; set; } //marcam ce campuri vrem sa fie serializate
        [DataMember] public string Nume { get; set; }
        [DataMember] public int NrOre { get; set; }
        [DataMember] public int Salo { get; set; } //salo = salariu/ora
        public int Salariu => NrOre * Salo;
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

        public int Numar_salariati => ls.Count;
        public string Nume_firma => sfirma;
        public int Fond_sal => ls.Sum(s => s.Salariu);

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

        public void Serializeaza(string nfis)
        {
            FileStream fs = new FileStream(nfis, FileMode.Create);
            DataContractSerializer obs = new DataContractSerializer(typeof(Firma));

            obs.WriteObject(fs, this);
            fs.Close();
        }

        public void Deserializeaza(string nfis)
        {
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
