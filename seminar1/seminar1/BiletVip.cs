using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar1
{
    internal class BiletVip : Bilet
    {
        public bool IncludePopcorn {  get; set; }
        public bool IncludeBautura { get; set; }

        public BiletVip(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza, bool includePopcorn, bool includeBautura) : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)
        {
            IncludePopcorn = includePopcorn;
            IncludeBautura = includeBautura;
        }

        public override double getReducere()
        {
            return 0;
        }

        public double getExtras()
        {
            double suma = 0;
            if (IncludePopcorn)
            {
                suma += 15;
            }

            if (IncludeBautura)
            {
                suma += 10;
            }

            return suma;
        }

        public override double CalculeazaPretFinal()
        {
            return PretBaza + getExtras();
        }
    }
}
