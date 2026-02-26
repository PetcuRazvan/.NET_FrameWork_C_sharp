using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace curs1 {
    internal class Program {

       
        static void getMedie(List<int> vector, out double medie) //e referinta media
        {
            medie = vector.Average();
        }

        static void Main(string[] args) {

            //int nrElemente;
            //int[] vector = new int[100];

            //Console.Write("Numar elemente: ");
            //nrElemente = int.Parse(Console.ReadLine()); //ReadLine asteapta un string

            //for(int i = 0; i <  nrElemente; i++) {
            //    Console.Write("Introdu elementul {0}: ", i);
            //    vector[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Elementele vectorului:");
            //for (int i = 0; i < nrElemente; i++)
            //    Console.WriteLine("Elementul {0} = {1} ", i, vector[i]); //0, 1 inseamna pozitiile variabilelor dupa virgula

            //Console.WriteLine("Media aritmetica: " + getMedie(vector, nrElemente));
            //Console.WriteLine("Media aritmetica: " + getMedie(vector, nrElemente).ToString(".##"));


            //acum folosim clasa List
            List<int> vector = new List<int>();
            string sirNumar;

            Console.Write("Dati element: ");
            while ((sirNumar = Console.ReadLine()) != null)
            {
                vector.Add(int.Parse(sirNumar));
                Console.Write("Dati element: ");

            }

            double medie = 0;

            getMedie(vector, out medie);
            Console.WriteLine(medie);

            int rez;

            rez = vector.Sum(x => x > 0 ? x : 0); //suma elementelor mai mari decat 0
            Console.WriteLine(rez);

            //facem Linq <3
            var rezultatPrinLinq = from element in vector where element > 0 select element;
            Console.WriteLine("suma prin linq: " + rezultatPrinLinq.Sum());

            //toate tipurile deriva din clasa object
            List<object> vectorDeObiecte = new List<object>();

            vectorDeObiecte.Add(100);
            vectorDeObiecte.Add("Salut");
            vectorDeObiecte.Add(67.69);
        }
    } 
}
