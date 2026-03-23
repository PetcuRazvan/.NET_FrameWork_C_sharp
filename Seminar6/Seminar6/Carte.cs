using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    public class Carte
    {
        public Guid Id { get; set; } //global unic identifier ... niciodata nmn nu va genera acelasi id, nici pe calculatoare diferite, 2 obiecte nu vor avea in tot universul acelasi id
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public int AnAparitie { get; set; }
        public GenCarte Gen { get; set; }
    }
}
