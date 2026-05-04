using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar11
{
    public static class FakeDatabase
    {
        public static List<Student> Studenti = new List<Student>
        {
            new Student { Nume = "Andrei Popescu",   Matematica = 9,  Informatica = 10, Fizica = 8, Chimie = 7,  Biologie = 9  },
            new Student { Nume = "Maria Ionescu",    Matematica = 7,  Informatica = 8,  Fizica = 6, Chimie = 9,  Biologie = 8  },
            new Student { Nume = "Alexandru Marin",  Matematica = 5,  Informatica = 7,  Fizica = 6, Chimie = 5,  Biologie = 6  },
            new Student { Nume = "Elena Constantin", Matematica = 10, Informatica = 9,  Fizica = 9, Chimie = 8,  Biologie = 10 },
            new Student { Nume = "Mihai Dumitrescu", Matematica = 6,  Informatica = 5,  Fizica = 7, Chimie = 6,  Biologie = 5  },
            new Student { Nume = "Ioana Stanescu",   Matematica = 8,  Informatica = 9,  Fizica = 8, Chimie = 7,  Biologie = 8  },
            new Student { Nume = "Cristian Popa",    Matematica = 4,  Informatica = 6,  Fizica = 5, Chimie = 4,  Biologie = 5  },
            new Student { Nume = "Andreea Dragomir", Matematica = 9,  Informatica = 8,  Fizica = 7, Chimie = 9,  Biologie = 8  },
        };
    }
}
