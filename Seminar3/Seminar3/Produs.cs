namespace Seminar3
{
    public class Produs
    {
        public string Nume { get; }
        public decimal Pret { get; }
        public int Cantitate { get; }

        public Produs(string nume, decimal pret, int cantitate)
        {
            Nume = nume;
            Pret = pret;
            Cantitate = cantitate;
        }
    }
}
