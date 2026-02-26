using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Client c = new Client("Vilce", "Lucian", "lucian@ase.ro", "0759116012");
            }
            catch (Exception e)  //toate exceptiile deriva din clasa Exception
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
