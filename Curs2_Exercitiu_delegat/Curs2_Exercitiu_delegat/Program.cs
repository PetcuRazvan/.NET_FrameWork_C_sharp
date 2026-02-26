using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs2_Exercitiu_delegat
{
    internal class Program
    {
        delegate int Delegat_opa(int a, int b);  //referinta la functii
        static void Main(string[] args)
        {
            int aduna(int a, int b) => a + b;
            Delegat_opa ob_func = new Delegat_opa(aduna);
            ob_func += (x, y) => x - y; //am mai adaugat o functie la delegat

            foreach(Delegat_opa f in ob_func.GetInvocationList()) //GetInvocationList returneaza o lista cu toate functiile
                Console.WriteLine(f(60, 7));

            //noi mai putem folosi delegatii fara sa le declaram:
            Func<int, int, int> ob_func2 = new Func<int, int, int> (aduna); //primi 2 int sunt parametrii, al 3 lea e tipul returnat
        }
    }
}

//delegarile gestioneaza mai multe functii
