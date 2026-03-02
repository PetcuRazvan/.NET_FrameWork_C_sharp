using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
   
    internal class Program
    {
        static int ceva(string altCeva)
        {
            return altCeva.Length;
        }

        static bool Altceva(string altceva)
        {
            return true;
        }
        static void Main(string[] args)
        {
            Comanda c1 = new Comanda("Ionel", "ionel@gmail.com");
            c1.AdaugaProdus(new Produs("gogosi", 14, 3));
            c1.AdaugaProdus(new Produs("suc", 4.5m, 10));  //tre sa punem m ca sa fie decimal, m este de la decimal

            Depozit d = new Depozit("Stefanesti");

            //citeste pe gitbook mai mult desore delegati
            NotificareClient notificator = null;

            //Action<string, string> notificator = null; //putem folosi action in loc de delegat, care e doar un  delegat mai special, trebuie neaparat sa fie void, de aia putem inlocui delegatul nostru, pentru ca returnaa void

            string value = Console.ReadLine();
            //switch (value.ToLower())
            //{
            //    case "email":
            //        notificator = NotificareService.NotificaPrinEmail; //acum delegatul pointeaza catre functia NotificaPrinEmail
            //        break;

            //    case "sms":
            //        notificator = NotificareService.NotificaPrinSms;
            //        break;

            //    default:
            //        notificator = NotificareService.Log;
            //        break;
            //}

            //asta e varianta cand punem o singura functie in delegat
            //acum facem ca delegatul sa pointeze catre mai multe functii

            if (value.ToLower().Contains("sms"))
            {
                notificator += NotificareService.NotificaPrinSms;
            }

            if (value.ToLower().Contains("email"))
            {
                notificator += NotificareService.NotificaPrinEmail;
            }

            if (value.ToLower().Contains("log"))
            {
                notificator += NotificareService.Log;
            }


            d.InregistreazaComanda(c1, notificator);

            d.ComandaSchimbatStare += (object sender, ComandaSchimbatStareEventArgs arguments) =>
            {
                Console.WriteLine($"Fac ce vreau eu in main cu comanda {arguments.Comanda.NumarComanda}");
            };

            //notificator(c1.NumarComanda, ....bla bla) puteam sa scriem si asa, dar cu ? si Invoke, verificam daca e null si daca e null, nu crapa

            //Func<string, int> func = ceva;
            //Console.WriteLine(func("Vali"));

            //Predicate<string> predicate = Altceva; //predicate ul este un delegat care pointeaza catre o functie care returneaza bool
            //Console.WriteLine(predicate("Vali"));

        }
    }
}
