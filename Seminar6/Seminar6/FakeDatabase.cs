using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    internal static class FakeDatabase
    {
        public static List<Carte> Carti = new List<Carte>()
        {
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Mizerabilii",
                Autor = "Victor Hugo",
                AnAparitie = 1852,
                Gen = GenCarte.Roman
            }
        };
    }
}
