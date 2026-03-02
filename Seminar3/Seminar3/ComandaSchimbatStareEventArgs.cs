using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class ComandaSchimbatStareEventArgs : EventArgs
    {
        public Comanda Comanda { get; set; }
        public StareComanda StareVeche { get; set; }
        public StareComanda StareNoua { get; set; }
    }
}
