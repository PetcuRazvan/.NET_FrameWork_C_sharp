using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3_Windows_Forms
{
    internal class Element
    {
        public event Action<Element> Ev_Mod_Valoare;

        int vel;
        public Element() { vel = 0; }
        public int Valoare
        {
            get => vel;
            set
            {
                if (vel != value)
                {
                    vel = value;
                    if (Ev_Mod_Valoare != null) Ev_Mod_Valoare(this);
                }
            }
        }

        public int Patrat => vel * vel;
    }
}
