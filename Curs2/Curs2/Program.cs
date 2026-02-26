using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sa te faci bine Catinca!!!!

namespace Curs2
{
    interface Ifigura
    {
        int get_arie();
        int Perimetru { get; }
    }

    abstract class Figura : Ifigura
    {
        protected int lat;  //adica latura
        protected Figura(int flat) { lat = flat; }
        protected abstract int calcul_perimetru();
        protected abstract int calcul_arie();


        public int Perimetru => calcul_perimetru(); //daca apelezi .Perimetru, returneaza rezultatul functiei

        public int get_arie() { return calcul_arie(); }

        public override string ToString() => $"{Tip_FG} are Perimetrul: {Perimetru} si Aria: {calcul_arie()}"; //suprascriem to string ca sa putem afisa
                                                                                                               //semnul dolar inseamna ca e string formatat

        public string Tip_FG => this.GetType().Name; //sa returneze daca e patrat sau dreptunghi    Tip_FG = tip figura geometrica >:( 
    }

    class Patrat : Figura
    {
        public Patrat(int flat) : base(flat) { }

        protected override int calcul_arie() => lat * lat;

        protected override int calcul_perimetru() => 4 * lat;

        //suprascriere de operator + (nu putem suprascrie separat +=, este de ajuns doar +)
        public static Patrat operator +(Patrat p1, Patrat p2) => new Patrat(p1.lat + p2.lat);
        // => inseamna functie lambda
    }

    class Dreptunghi : Figura
    {
        private int lung;

        public Dreptunghi(int flat, int flung) : base(flat) { lung = flung; }

        protected override int calcul_arie() => lung * lat;

        protected override int calcul_perimetru() => 2 * lung + 2 * lat;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Figura obp = new Patrat(10), obd = new Dreptunghi(4, 5); //obp = obiect patrat, obd = obiect dreptunghi
            Console.WriteLine(obp + "\n" + obd);

            Patrat obp1 = new Patrat(3), prez; //prez inseamna patrat rezultat
            prez = (Patrat)obp + obp1; //tre sa facem cast la Patrat pentru obp, ca obp e de tip Figura

            Console.WriteLine(prez);
        }
    }
}