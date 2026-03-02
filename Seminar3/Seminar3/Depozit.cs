using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class Depozit
    {
        public string Nume { get; set; }
        private List<Comanda> _comenzi;

        public EventHandler<ComandaSchimbatStareEventArgs> ComandaSchimbatStare;
        public EventHandler ComandaLivrata;

        public Depozit(string nume)
        {
            Nume = nume;
            _comenzi = new List<Comanda>();
        }

        public void InregistreazaComanda(Comanda comanda, NotificareClient notificareClient = null) //egalam cu null ca sa facem parametru optional
        {
            _comenzi.Add(comanda);
            notificareClient?.Invoke(comanda.NumarComanda, "Comanda a fost inregistrata");
        }

        public void AvanseazaStare(string NumarComanda)
        {
            var comanda = _comenzi.FirstOrDefault(c => c.NumarComanda == NumarComanda);

            if (comanda == null)
            {
                return;
            }

            if (comanda.Stare == StareComanda.Livrata)
            {
                return;
            }

            StareComanda stareVeche = comanda.Stare;
            comanda.Stare = (StareComanda)((int)comanda.Stare + 1);

            ComandaSchimbatStare.Invoke(this, new ComandaSchimbatStareEventArgs()
            {
                Comanda = comanda,
                StareVeche = stareVeche,
                StareNoua = comanda.Stare
            });

        }
    }
}
