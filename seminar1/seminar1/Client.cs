using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace seminar1
{
    public class Client
    {
        public string Nume {  get; set; }
        public string Prenume { get; set; }

        private string _email; //comventie: privat -> _incepe cu litera mica
        public string Email
        {
            get { return _email; }

            set
            {
                if(value.Contains('@') && value.Contains('.'))
                    _email = value;
                else
                    throw new ArgumentException("Adresa de email nu este valida");
            }
        }

        private string _telefon;
        public string Telefon
        {
            get { return _telefon; }

            set
            {
                if (value.Length != 10)
                    throw new ArgumentException("Numarul de telefon nu este valid");
                _telefon = value;
            }
        }

        public Client(string nume, string prenuma, string email, string telefon)  //ctor + tab creeaza constructor
        {
            Nume = nume;
            Prenume = prenuma;
            Email = email;
            Telefon = telefon;  
            //pentru ca am facyt geteri, sunt apelati automat
        }
    }
}
