using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    public class CarteRepository
    {
        public List<Carte> GetAll()
        {
            return new List<Carte>(FakeDatabase.Carti); //facem o copie ca sa nu modificam direct baza de date falsa
        }

        public void Add(Carte carte)
        {
            FakeDatabase.Carti.Add(carte);
        }

        public Carte GetById(Guid id)
        {
            return FakeDatabase.Carti.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Carte carte)
        {
            var index = FakeDatabase.Carti.FindIndex(x => x.Id == carte.Id);
            if (index >= 0)
            {
                FakeDatabase.Carti[index] = carte;
            }
        }
    }
}
